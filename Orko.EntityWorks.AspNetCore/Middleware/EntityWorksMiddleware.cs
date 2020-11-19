using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orko.EntityWorks.Exceptions;
using System;
using System.Threading.Tasks;

namespace Orko.EntityWorks.AspNetCore
{
	/// <summary>
	/// Indicated request culture casing.
	/// </summary>
	public enum RequestCultureCasing
	{
		// Indicates upper case for culture code. (EN-US, EN)
		UpperCase,

		// Indicates lower case for culture code. (en-us, en)
		LowerCase
	}

	/// <summary>
	/// Entity works configurations options.
	/// </summary>
	public class EntityWorksOptions
	{
		#region Constructors
		/// <summary>
		/// Creates entityworks options object.
		/// </summary>
		public EntityWorksOptions()
		{
			// Defaults boolean.
			this.UserContextTransformation = false;
			this.UseRequestCulture = true;
			this.UseNeutralCulture = true;
			this.DebugMode = false;

			// Defaults null.
			this.RequestCultureCasing = null;
		}
		#endregion

		#region Flags
		/// <summary>
		/// If true, usercontext will be transformed with provided claim parameters after user has been authenticated.
		/// Identity claims must be set [missing].
		/// </summary>
		public bool UserContextTransformation { get; set; }
		/// <summary>
		/// If true, entity works will use request culture to find language / culture code.
		/// If false, default culture must be provided with CultureCode property.
		/// </summary>
		public bool UseRequestCulture { get; set; }
		/// <summary>
		/// If true and UseRequestCulture is true, entity works will use request culture to find language / culture neutral code.
		/// If false, default culture must be provided with CultureCode property.
		/// </summary>
		public bool UseNeutralCulture { get; set; }
		/// <summary>
		/// If true, entity works will convert culture code to uppercase.
		/// If false, default user provided culture code casing is used.
		/// </summary>
		public RequestCultureCasing? RequestCultureCasing { get; set; }
		/// <summary>
		/// If true, entity works will include more validations and exception throwing, which can degrade performance a bit.
		/// Set false to better performance, but harder error debuging.
		/// </summary>
		public bool DebugMode { get; set; }
		#endregion

		#region Localization
		/// <summary>
		/// 
		/// </summary>
		public string CultureCode { get; set; }
		#endregion

		#region Authentication
		/// <summary>
		/// User identity claim name that holds sql database name.
		/// If set after user is authenticated user context will be set to use specified sql database.
		/// UserContextTransformation must be set to true otherwise it will be ignored.
		/// </summary>
		public string DatabaseClaimName { get; set; }
		/// <summary>
		/// User identity user claim name that holds sql user name.
		/// If set after user is authenticated user context will be set to use specified sql user name.
		/// UserContextTransformation must be set to true otherwise it will be ignored.
		/// </summary>
		public string UserClaimName { get; set; }
		/// <summary>
		/// User identity password claim name that holds sql user password.
		/// If set after user is authenticated user context will be set to use specified sql user password.
		/// UserContextTransformation must be set to true otherwise it will be ignored.
		/// </summary>
		public string PasswordClaimName { get; set; }
		#endregion
	}

	/// <summary>
	/// Entity works runtime middleware.
	/// </summary>
	public class EntityWorksMiddleware
	{
		#region Members
		/// <summary>
		/// Request delegate.
		/// </summary>
		private readonly RequestDelegate m_next;
		/// <summary>
		/// Entity works options exposing entity works context.
		/// </summary>
		private EntityWorksOptions m_options;
		#endregion

		#region Constructors
		/// <summary>
		/// Creates entityworks middleware object.
		/// </summary>
		public EntityWorksMiddleware(RequestDelegate next)
		{
			// Set members.
			this.m_next = next;
			this.m_options = new EntityWorksOptions()
			{
				UseRequestCulture = true,
				UseNeutralCulture = true,
				UserContextTransformation = false,
				RequestCultureCasing = null,
				DebugMode = false,
			};

			// Set properties.
			this.CultureCode = null;
		}
		/// <summary>
		/// Creates entityworks middleware object.
		/// </summary>
		/// <param name="options">EntityWorks configuration options</param>
		public EntityWorksMiddleware(RequestDelegate next, Action<EntityWorksOptions> options)
		{
			// Set members.
			this.m_next = next;
			options(m_options);
		}
		#endregion

		#region Context
		/// <summary>
		/// Guest connection string name.
		/// </summary>
		private string GuestContextName { get; set; }
		/// <summary>
		/// Root connection string name.
		/// </summary>
		private string RootContextName { get; set; }
		/// <summary>
		/// User connection string name.
		/// </summary>
		private string UserContextName { get; set; }
		#endregion

		#region Culture
		/// <summary>
		/// Represents user defined language code.
		/// </summary>
		public string CultureCode { get; private set; }
		#endregion

		#region Invoke
		public async Task Invoke(HttpContext context, IConfiguration configuration)
		{
			// Setup and configure culture code.
			SetupCultureCodeProvider(context);

			// Initialize entityworks context.
			SetupEntityWorksContext(context);

			// Setup and transform query context.
			SetupQueryContext(context);

			// Continue.
			await m_next(context);
		}
		#endregion

		#region Private methods
		/// <summary>
		/// Determines and configures culture code.
		/// </summary>
		private void SetupCultureCodeProvider(HttpContext context)
		{
			// Determine language code.
			if (m_options.UseRequestCulture)
			{
				// Get ui culture.
				var uiCulture = context
					.Features?.Get<IRequestCultureFeature>()
					.RequestCulture?
					.UICulture;

				// If set convert to neutral.
				if (m_options.UseNeutralCulture)
					this.CultureCode = uiCulture.TwoLetterISOLanguageName;
				else this.CultureCode = uiCulture.DisplayName;
			}
			else
			{
				// Set language code constant for now.
				if (string.IsNullOrWhiteSpace(m_options.CultureCode))
					throw new EntityWorksException("Culture code not set. Please set UseRequestCulture to true or provide culture manually.", null);
				this.CultureCode = m_options.CultureCode;
			}

			// If set convert casing to requested casing.
			if (m_options.RequestCultureCasing.HasValue)
				if (m_options.RequestCultureCasing == RequestCultureCasing.LowerCase)
					this.CultureCode = this.CultureCode.ToLower();
				else this.CultureCode = this.CultureCode.ToUpper();
		}
		/// <summary>
		/// Configures entity works context.
		/// </summary>
		private void SetupEntityWorksContext(HttpContext context)
		{
			// Get entityworks context.
			var entityWorksContext = context.RequestServices.GetRequiredService<EntityWorksContext>();

			// Initialize entityworks context.
			entityWorksContext
				.RegisterGuestContext()
				.RegisterRootContext()
				.RegisterUserContext()
				.SetLanguageCode(this.CultureCode)
				.SetDebugMode(m_options.DebugMode);
		}
		/// <summary>
		/// Transforms query context depending on authentification state.
		/// </summary>
		private void SetupQueryContext(HttpContext context)
		{
			// Get entityworks context.
			var entityWorksContext = context.RequestServices.GetRequiredService<EntityWorksContext>();

			// If user is authenticated.
			if (context.User?.Identity != null &&
				context.User.Identity.IsAuthenticated)
			{
				// If user context transformation set than transform user context.
				if (m_options.UserContextTransformation)
				{
					// Get sql database name.
					var sqlDatabaseName = context.User.FindFirst(m_options.DatabaseClaimName).Value;

					// Transform user query context.
					entityWorksContext.TransformUserContext(sqlDatabaseName);
				}

				// Set user context as default context.
				entityWorksContext.SetDefaultContext(QueryContextType.UserQueryContext);
			}
			else
			{
				// Set guest user context as default.
				entityWorksContext.SetDefaultContext(QueryContextType.GuestQueryContext);
			}
		}
		#endregion
	}
}

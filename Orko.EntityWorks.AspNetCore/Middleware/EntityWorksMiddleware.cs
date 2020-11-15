using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Orko.EntityWorks.AspNetCore
{
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
		/// If true, entity works will include more validations and exception throwing, which can degrade performance a bit.
		/// Set false to better performance, but harder error debuging.
		/// </summary>
		public bool DebugMode { get; set; }
		#endregion

		#region Context
		/// <summary>
		/// Guest connection string name.
		/// </summary>
		public string GuestContextName { get; set; }
		/// <summary>
		/// Root connection string name.
		/// </summary>
		public string RootContextName { get; set; }
		/// <summary>
		/// User connection string name.
		/// </summary>
		public string UserContextName { get; set; }
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
		private Action<EntityWorksOptions> m_options;
		#endregion

		#region Constructors
		/// <summary>
		/// Creates entityworks middleware object.
		/// </summary>
		/// <param name="options">EntityWorks configuration options</param>
		public EntityWorksMiddleware(RequestDelegate next, Action<EntityWorksOptions> options)
		{
			// Set members.
			this.m_next = next;
			this.m_options = options;
		}
		#endregion

		#region Invoke
		public async Task Invoke(HttpContext context, IConfiguration configuration)
		{
			// Get entityworks context.
			var entityWorksContext = context.RequestServices.GetRequiredService<EntityWorksContext>();

			// Create entityworks options.
			var entityWorksOptions = new EntityWorksOptions();

			// Initialize entityworks options.
			m_options(entityWorksOptions);

			// Get language code from current culture.
			var languageCode = entityWorksOptions.UseRequestCulture ? 
				context.Features?.Get<IRequestCultureFeature>()
				.RequestCulture?
				.UICulture?
				.TwoLetterISOLanguageName
				.ToUpper() : entityWorksOptions.CultureCode?.ToUpper();

			// Initialize entityworks context.
			entityWorksContext
				.RegisterGuestContext(entityWorksOptions.GuestContextName)
				.RegisterRootContext(entityWorksOptions.RootContextName)
				.RegisterUserContext(entityWorksOptions.UserContextName)
				.SetDebugMode(entityWorksOptions.DebugMode)
				.SetLanguageCode(languageCode);

			// If user is authenticated.
			if (context.User.Identity.IsAuthenticated)
			{
				// Get sql database name.
				var sqlDatabaseName = context.User.FindFirst(entityWorksOptions.DatabaseClaimName).Value;

				// Transform user query context.
				entityWorksContext.TransformUserContext(sqlDatabaseName);

				// Set user context as default context.
				entityWorksContext.SetDefaultContext(QueryContextType.UserQueryContext);
			}
			else
			{
				// Set guest user context as default.
				entityWorksContext.SetDefaultContext(QueryContextType.GuestQueryContext);
			}

			// Nastavi.
			await m_next(context);
		}
		#endregion
	}
}

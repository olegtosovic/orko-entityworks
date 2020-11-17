using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orko.EntityWorks;
using System;
using System.Linq;

namespace Orko.EntityWorks.AspNetCore
{
	/// <summary>
	/// Extensions for entity works configuration.
	/// </summary>
	public static class EntityWorksExtensions
	{
		#region Konfiguracija
		/// <summary>
		/// Add entityworks required services.
		/// appsettings.json must have section name "ConnectionStrings" containing at least one connection string.
		/// </summary>
		public static void AddEntityWorks(this IServiceCollection services, IConfiguration configuration)
		{
			// Validation.
			if (configuration == null)
				throw new ArgumentNullException("configuration", 
					"Valid application IConfiguration instance must be provided. " +
					"It is required to access application settings json file for entity works configuration section.");

			// Add scoped entity works instance.
			services.AddScoped<EntityWorksContext>();

			// Add http context accessor.
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

			// Create connection string dictionary.
			var connectionStrings = configuration
				.GetSection("ConnectionStrings")
				.GetChildren()
				.ToDictionary(x => x.Key, x => x.Value);

			// Set connection string source.
			EntityWorksContext.SetConnectionStringSource(connectionStrings);
		}

		/// <summary>
		/// EntityWorks middleware registration.
		/// </summary>
		public static IApplicationBuilder UseEntityWorks(this IApplicationBuilder app, Action<EntityWorksOptions> options)
		{
			// Set entity works provider for scoped instance.
			EntityWorksContextProvider.SetEntityWorksContextFactory(() =>
			{
				// Get httpcontext accessor.
				var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();

				// Get entitworks service.
				return httpContextAccessor.HttpContext.RequestServices.GetRequiredService<EntityWorksContext>();
			});

			// Use entityworks middleware.
			app.UseMiddleware<EntityWorksMiddleware>(options);

			// Return app builder.
			return app;
		}
		#endregion
	}
}

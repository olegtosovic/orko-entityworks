using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orko.EntityWorks;
using Orko.EntityWorks.Exceptions;
using System;
using System.Linq;

namespace Orko.EntityWorks.AspNetCore
{
	/// <summary>
	/// Extensions for entity works configuration.
	/// </summary>
	public static class EntityWorksExtensions
	{
		#region Main middleware extensions
		/// <summary>
		/// Adds entityworks required services.
		/// </summary>
		public static void AddEntityWorks(this IServiceCollection services, IConfiguration configuration)
		{
			// Validate configuration instance.
			if (configuration == null)
				throw new ArgumentNullException("configuration", 
					"Valid application IConfiguration instance must be provided. " +
					"It is required to access application settings json file for entity works configuration section. " +
					"Please refer to documentation.");

			// Get entity works configuration section.
			var configurationSection = configuration.GetSection("EntityWorks") ??
				throw new EntityWorksException("appsettings.json or appconfig does not have required EntityWorksConfiguration section. " +
					"Please refer to documentation.");

			// Set connection strings source.
			SetConnectionStringSource(configuration);

			// Set context mappings source.
			SetContextMappingsSource(configurationSection);

			// Add http context accessor.
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

			// Add scoped entity works instance.
			services.AddScoped<EntityWorksContext>();
		}
		/// <summary>
		/// EntityWorks middleware registration.
		/// </summary>
		public static IApplicationBuilder UseEntityWorks(this IApplicationBuilder app)
		{
			// Set entity works provider for scoped instance.
			EntityWorksContextProvider.SetEntityWorksContextFactory(() =>
			{
				// Get httpcontext accessor.
				var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();

				// Get entitworks service.
				return httpContextAccessor.HttpContext.RequestServices.GetRequiredService<EntityWorksContext>();
			});

			// Create default options.
			var _options = new EntityWorksOptions();

			// Use entityworks middleware.
			app.UseMiddleware<EntityWorksMiddleware>(_options);

			// Return app builder.
			return app;
		}
		/// <summary>
		/// EntityWorks middleware registration.
		/// </summary>
		public static IApplicationBuilder UseEntityWorks(this IApplicationBuilder app, Action<EntityWorksOptions> options)
		{
			// Validate options instance.
			if (options == null)
				throw new ArgumentNullException("options", "EntityWorksOptions can not be null. ");

			// Set entity works provider for scoped instance.
			EntityWorksContextProvider.SetEntityWorksContextFactory(() =>
			{
				// Get httpcontext accessor.
				var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();

				// Get entitworks service.
				return httpContextAccessor.HttpContext.RequestServices.GetRequiredService<EntityWorksContext>();
			});

			// Create options.
			var _options = new EntityWorksOptions();

			// Configure options.
			options(_options);

			// Use entityworks middleware.
			app.UseMiddleware<EntityWorksMiddleware>(options);

			// Return app builder.
			return app;
		}
		#endregion

		#region Configuration
		/// <summary>
		/// Sets connection strings source to static entity works context.
		/// </summary>
		private static void SetConnectionStringSource(IConfiguration configuration)
		{
			// Get connection strings section.
			var connectionStringsSection = configuration.GetSection("ConnectionStrings") ??
				throw new EntityWorksException("Configuration does not have ConnectionStrings section. " +
					"Please refer to documentation.");

			// Get connection contexts.
			var connectionContexts = connectionStringsSection
				.GetChildren()
				.ToDictionary(x => x.Key, x => new ConnectionContext(
					connectionString: x.GetSection("ConnectionString").Value,
					providerAssembly: x.GetSection("ProviderAssembly").Value,
					providerFactory: x.GetSection("ProviderFactory").Value
				));

			// Set connection string source.
			EntityWorksContext.SetConnectionStringSource(connectionContexts);
		}
		/// <summary>
		/// Sets context mappings source to static entity works context.
		/// </summary>
		private static void SetContextMappingsSource(IConfigurationSection section)
		{
			// Get connection strings section.
			var contextMappingsSection = section.GetSection("ContextMappings") ??
				throw new EntityWorksException("EntityWorks section does not have ContextMappings section. " +
					"Please refer to documentation.");

			// Get context mappings.
			var contextMappings = contextMappingsSection
				.GetChildren()
				.ToDictionary(x => x.Key, x => x.Value);

			// Set connection string source.
			EntityWorksContext.SetContextMappingsSource(contextMappings);
		}
		#endregion
	}
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

namespace Orko.EntityWorks.Generator.AspNetCore
{
	/// <summary>
	/// Extensions for entity works configuration.
	/// </summary>
	public static class EntityWorksGeneratorExtensions
	{
		#region Main middleware extensions
		/// <summary>
		/// Adds entityworks required services.
		/// </summary>
		public static void AddEntityWorksGenerator(this IServiceCollection services, IConfiguration configuration)
		{
			// Validate configuration instance.
			if (configuration == null)
				throw new ArgumentNullException("configuration", 
					"Valid application IConfiguration instance must be provided. " +
					"It is required to access application settings json file for entity works generator configuration section. " +
					"Please refer to documentation.");

			// Get entity works configuration section.
			var configurationSection = configuration.GetSection("EntityWorksConfiguration");
			if (configurationSection == null)
				throw new EntityWorksGeneratorException("appsettings.json or appconfig does not have required EntityWorksConfiguration section. " +
					"Please refer to documentation.");

			// Get entity works generator connection string name.
			var connectionStringName = configurationSection
				.GetSection("EntityWorksGenerator")
				.GetChildren().Where(x => x.Key == "GeneratorContext")
				.First().Value;

			// Get connection string.
			var connectionString = configurationSection
				.GetSection("ConnectionStrings")
				.GetChildren().Where(x => x.Key == connectionStringName)
				.First().Value;

			// Create database.
			var database = new Database(
				new EntityWorksGeneratorOptions(),
				connectionString,
				false);

			// Create generator service instance.
			var entityWorksGenerator = new EntityWorksGenerator(database,
				new DirectoryInfo("C:\\GeneratorTestMiddleware\\"));

			// Add http context accessor.
			services.AddSingleton(entityWorksGenerator);
		}
		/// <summary>
		/// EntityWorks middleware registration.
		/// </summary>
		public static IApplicationBuilder UseEntityWorksGenerator(this IApplicationBuilder app, Action<EntityWorksGeneratorOptions> options = null)
		{
			// Set entity works provider for scoped instance.
			//EntityWorksContextProvider.SetEntityWorksContextFactory(() =>
			//{
			//	// Get httpcontext accessor.
			//	var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();

			//	// Get entitworks service.
			//	return httpContextAccessor.HttpContext.RequestServices.GetRequiredService<EntityWorksContext>();
			//});

			// Use entityworks middleware.
			if (options != null)
				app.UseMiddleware<EntityWorksGeneratorMiddleware>(options);
			else app.UseMiddleware<EntityWorksGeneratorMiddleware>();

			// Return app builder.
			return app;
		}
		#endregion

		#region Configuration
		/// <summary>
		/// Sets connection strings source to static entity works context.
		/// </summary>
		private static void SetConnectionStringSource(IConfigurationSection section)
		{
			// Get connection strings section.
			//var connectionStringsSection = section.GetSection("ConnectionStrings");
			//if (connectionStringsSection == null)
			//	throw new EntityWorksException("EntityWorksConfiguration section does not have ConnectionStrings section. " +
			//		"Please refer to documentation.");

			//// Get connection strings.
			//var connectionStrings = connectionStringsSection
			//	.GetChildren()
			//	.ToDictionary(x => x.Key, x => x.Value);

			//// Set connection string source.
			//EntityWorksContext.SetConnectionStringSource(connectionStrings);
		}
		/// <summary>
		/// Sets context mappings source to static entity works context.
		/// </summary>
		private static void SetContextMappingsSource(IConfigurationSection section)
		{
			// Get connection strings section.
			//var contextMappingsSection = section.GetSection("ContextMappings");
			//if (contextMappingsSection == null)
			//	throw new EntityWorksException("EntityWorksConfiguration section does not have ContextMappings section. " +
			//		"Please refer to documentation.");

			//// Get context mappings.
			//var contextMappings = contextMappingsSection
			//	.GetChildren()
			//	.ToDictionary(x => x.Key, x => x.Value);

			//// Set connection string source.
			//EntityWorksContext.SetContextMappingsSource(contextMappings);
		}
		#endregion
	}
}

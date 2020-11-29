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
			var entityWorksSection = configuration.GetSection("EntityWorks") ??
				throw new EntityWorksGeneratorException("appsettings.json or appconfig does not have required EntityWorks section. " +
					"Please refer to documentation.");

			// Get connection string from configuration.
			var connectionString = GetEntityWorksGeneratorConnectionFromConfiguration(configuration, entityWorksSection);

			// Create entity works generator service instance without populating database data.
			var database = new Database(connectionString);
			var entityWorksGenerator = new EntityWorksGenerator(database);

			// Add entity works generator service instance.
			services.AddSingleton(entityWorksGenerator);
		}
		/// <summary>
		/// EntityWorks middleware registration.
		/// </summary>
		public static IApplicationBuilder UseEntityWorksGenerator(this IApplicationBuilder app)
		{
			// Create default entity works generator options.
			var options = new EntityWorksGeneratorOptions();

			// Use entityworks generator middleware.
			app.UseMiddleware<EntityWorksGeneratorMiddleware>(options);

			// Return app builder.
			return app;
		}
		/// <summary>
		/// EntityWorks middleware registration.
		/// </summary>
		public static IApplicationBuilder UseEntityWorksGenerator(this IApplicationBuilder app, Action<EntityWorksGeneratorOptions> options)
		{
			// Validate options instance.
			if (options == null)
				throw new ArgumentNullException("options", "EntityWorksGeneratorOptions can not be null. ");

			// Create options.
			var _options = new EntityWorksGeneratorOptions();

			// Configure options.
			options(_options);

			// Use entityworks generator middleware.
			app.UseMiddleware<EntityWorksGeneratorMiddleware>(_options);

			// Return app builder.
			return app;
		}

		#endregion

		#region Configuration
		/// <summary>
		/// Reads entity works generator connection string from appseetings.
		/// </summary>
		private static string GetEntityWorksGeneratorConnectionFromConfiguration(IConfiguration configuration, IConfigurationSection entityWorksSection)
		{
			// Get connection string name.
			var connectionStringName = entityWorksSection
				.GetSection("QueryContexts")?
				.GetSection("EntityContext")?.Value;
			if (string.IsNullOrWhiteSpace(connectionStringName))
				throw new EntityWorksGeneratorException("EntityWorks Generator model context not defined. " +
					"Please refer to documentation.");

			// Get connection string.
			var connectionString = configuration
				.GetSection("ConnectionStrings")
				.GetSection(connectionStringName)?.Value;
			if (string.IsNullOrWhiteSpace(connectionString))
				throw new EntityWorksGeneratorException("Connection string named: \"" + connectionStringName + "\" does not exists in ConnectionStrings section. " +
					"Please refer to documentation.");

			// Return connection string.
			return connectionString;
		}
		#endregion
	}
}

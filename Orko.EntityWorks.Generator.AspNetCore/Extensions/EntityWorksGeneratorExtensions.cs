using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
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

			// Get connection strings section.
			var connectionStringsSection = configuration.GetSection("ConnectionStrings") ??
				throw new EntityWorksGeneratorException("Configuration does not have ConnectionStrings section. " +
					"Please refer to documentation.");

			// Get entity works generator configuration section.
			var entityWorksGeneratorSection = configuration.GetSection("EntityWorksGenerator") ??
				throw new EntityWorksGeneratorException("appsettings.json or appconfig does not have required EntityWorksGenerator section. " +
					"Please refer to documentation.");

			// Get database models configuration section.
			var contextModelsSection = entityWorksGeneratorSection.GetSection("ContextModels") ??
				throw new EntityWorksGeneratorException("EntityWorksGenerator section does not have required ContextModels section. " +
					"Please refer to documentation.");

			// Get context models from configuration.
			var databases = GetDatabaseModelsFromConfiguration(connectionStringsSection, contextModelsSection);

			// Create entity works generator service instance without populating database data.
			var entityWorksGenerator = new EntityWorksGenerator(databases);

			// Add entity works generator service instance.
			services.AddSingleton(entityWorksGenerator);
		}
		/// <summary>
		/// EntityWorks middleware registration.
		/// </summary>
		public static IApplicationBuilder UseEntityWorksGenerator(this IApplicationBuilder app)
		{
			// Create default entity generator options.
			var options = new EntityGeneratorOptions();

			// Use entityworks generator middleware.
			app.UseMiddleware<EntityWorksGeneratorMiddleware>(options);

			// Return app builder.
			return app;
		}
		/// <summary>
		/// EntityWorks middleware registration.
		/// </summary>
		public static IApplicationBuilder UseEntityWorksGenerator(this IApplicationBuilder app, Action<EntityGeneratorOptions> options)
		{
			// Validate options instance.
			if (options == null)
				throw new ArgumentNullException("options", "EntityGeneratorOptions can not be null. ");

			// Create options.
			var _options = new EntityGeneratorOptions();

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
		/// Gets context models from configuration.
		/// </summary>
		/// <param name="stringsSection">Configuration section containing connection strings</param>
		/// <param name="modelsSection">Configuration section containing database models</param>
		private static IEnumerable<Database> GetDatabaseModelsFromConfiguration(IConfigurationSection stringsSection, IConfigurationSection modelsSection)
		{
			// Create default database generator instance.
			// Main source of defaultness must always be defined by object itself.
			var options = new DatabaseGeneratorOptions();

			// Get database context models with options.
			var databases = modelsSection

				// Get all database model sections.
				.GetChildren()

				// Project to Database model object.
				.Select(section => new Database(

					// Pass connection string.
					stringsSection.GetSection(GetSectionValue<string>("ConnectionName", true, section, section.Key, null)).Value,
					
					// Pass entity generator options.
					new DatabaseGeneratorOptions()
					{
						UseLanguageTables = GetSectionValue("UseLanguageTables", false, section, section.Key, options.UseLanguageTables),
						RemoveGlobalTablePreffix = GetSectionValue("RemoveGlobalTablePreffix", false, section, section.Key, options.RemoveGlobalTablePreffix),
						GlobalTablePreffix = GetSectionValue<string>("GlobalTablePreffix", false, section, section.Key, options.GlobalTablePreffix),
						LanguageTableSuffix = GetSectionValue<string>("LanguageTableSuffix", false, section, section.Key, options.LanguageTableSuffix),
						ForeignKeyNamingConvention = GetSectionValue("ForeignKeyNamingConvention", true, section, section.Key, options.ForeignKeyNamingConvention),
						ForeignKeyNameNamingConverter = options.ForeignKeyNameNamingConverter
					}
				));

			// Return context models.
			return databases;
		}
		/// <summary>
		/// Gets generation option value from section.
		/// </summary>
		/// <param name="optionKey">Option name</param>
		/// <param name="optionMustExist">Does option value must be set both right and left side</param>
		/// <param name="section">Database section</param>
		/// <param name="modelName">Database name</param>
		/// <param name="defaultValue">Default value to set if not exists</param>
		private static T GetSectionValue<T>(string optionKey, bool optionMustExist, IConfigurationSection section, string modelName, T defaultValue)
		{
			// Get section string value.
			var sectionValue = section?.GetSection(optionKey).Value;

			// Value reference.
			T returnValue;

			// If section value not set or whole section not exists.
			if (string.IsNullOrWhiteSpace(sectionValue))
			{
				// If value must be set by user throw.
				if (optionMustExist)
				{
					throw new EntityWorksGeneratorException(
						string.Format("Generator model option '{0}' for database model '{1}' not properly set. " +
						"Please refer to documentation.", optionKey, modelName));
				}

				// Else set default value.
				else returnValue = defaultValue;
			}

			// If section value set.
			else
			{
				try
				{
					// Special case foreign key convention.
					// Not the best way to convert enums but for this case is sufficent for now.
					if (typeof(T) == typeof(ForeignKeyNamingConvention))
					{
						if (sectionValue == nameof(ForeignKeyNamingConvention.FK_FC_FN))
							returnValue = (T)Convert.ChangeType(ForeignKeyNamingConvention.FK_FC_FN, typeof(T));
						else if (sectionValue == nameof(ForeignKeyNamingConvention.FK_FC_NTBL_FN))
							returnValue = (T)Convert.ChangeType(ForeignKeyNamingConvention.FK_FC_NTBL_FN, typeof(T));
						else if (sectionValue == nameof(ForeignKeyNamingConvention.FK_FN))
							returnValue = (T)Convert.ChangeType(ForeignKeyNamingConvention.FK_FN, typeof(T));
						else if (sectionValue == nameof(ForeignKeyNamingConvention.FK_LS))
							returnValue = (T)Convert.ChangeType(ForeignKeyNamingConvention.FK_LS, typeof(T));
						else throw new EntityWorksGeneratorException(
							string.Format("ForeignKeyNamingConvention model option '{0}' with value '{1}' for database model '{2}' is not valid value." +
								"Please refer to documentation.", optionKey, modelName, sectionValue));
					}

					// Try convert to generic type.
					else returnValue = (T)Convert.ChangeType(sectionValue, typeof(T));
				}
				catch (FormatException e)
				{
					// Throw generator exception and wrap.
					throw new EntityWorksGeneratorException(
						string.Format("Generator model option '{0}' with value '{1}' for database model '{2}' is not valid value." +
						"Please refer to documentation.", optionKey, modelName, sectionValue), e
						);
				}
			}

			// Return value.
			return returnValue;
		}
		#endregion
	}
}

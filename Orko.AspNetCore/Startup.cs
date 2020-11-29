using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orko.EntityWorks.AspNetCore;
using Orko.EntityWorks.Generator;
using Orko.EntityWorks.Generator.AspNetCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Orko.AspNetCore
{
	/// <summary>
	/// Application startup services and middleware configuration.
	/// </summary>
	public class Startup
	{
		/// <summary>
		/// Configuration constructor.
		/// </summary>
		public Startup(IConfiguration configuration, IWebHostEnvironment environment)
		{
			// Set configuration.
			Configuration = configuration;

			// Set environment.
			Environment = environment;
		}

		#region Propertiji
		/// <summary>
		/// Environment.
		/// </summary>
		public IWebHostEnvironment Environment { get; }
		/// <summary>
		/// Configuration.
		/// </summary>
		public IConfiguration Configuration { get; }
		#endregion

		/// <summary>
		/// Adding services to the container.
		/// </summary>
		public void ConfigureServices(IServiceCollection services)
		{
			// Only development environment.
			if (Environment.IsDevelopment())
			{
				// Add EntityWorks Generator.
				services.AddEntityWorksGenerator(Configuration);
			}

			// Add routing.
			services.AddRouting(options => { options.LowercaseUrls = true; options.LowercaseQueryStrings = true; });

			// Add controllers and views.
			services.AddControllersWithViews();

			// Add EntityWorks.
			services.AddEntityWorks(Configuration);
		}

		/// <summary>
		/// Configuration of the HTTP request pipeline.
		/// </summary>
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// Only development environment.
			if (Environment.IsDevelopment())
			{
				// Use developer exception page.
				app.UseDeveloperExceptionPage();

				// Use entity works generator.
				app.UseEntityWorksGenerator(options =>
				{
					// Global language table directive.
					options.UseLanguageTables = true;

					// Global language table suffix.
					options.LanguageTableSuffix = "_jezik";

					// Global target directory.
					options.TargetDirectory = new System.IO.DirectoryInfo(@"C:\EWTest");

					// Global predefined foreign key name converting convention.
					options.ForeignKeyNamingConvention = ForeignKeyNamingConvention.ForeignKeyFullName;

					// Global custom foreign key name converter.
					options.ForeignKeyNameNamingConverter = (sqlForeignKeyName, sqlForeignKeyColumns) =>
					{
						// Custom logic.
						return sqlForeignKeyName;
					};
				});
			}

			// Koristi HRV culture.
			var cultureString = "en";
			var supportedCultures = new[] { new CultureInfo(cultureString) };
			app.UseRequestLocalization(new RequestLocalizationOptions
			{
				DefaultRequestCulture = new RequestCulture(cultureString),
				SupportedCultures = supportedCultures,
				SupportedUICultures = supportedCultures
			});

			// Use EntityWorks.
			app.UseEntityWorks();

			// Use routing.
			app.UseRouting();

			// Use endpoints.
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}

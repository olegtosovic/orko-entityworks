using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Data.SqlClient;
using Orko.EntityWorks.AspNetCore;
using Orko.EntityWorks.Generator.AspNetCore;
using System.Data.Common;
using System.Globalization;
using System;

namespace Orko.AspNetCore
{
	/// <summary>
	/// Application startup services and middleware configuration.
	/// </summary>
	public class Startup
	{
		#region Constructors
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
		#endregion

		#region Properties
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
			// services.AddEntityWorks(Configuration);

			var qName = typeof(SqlClientFactory).AssemblyQualifiedName;
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
					// Global target directory.
					options.OutputDirectory = new System.IO.DirectoryInfo(@"C:\EWTest");
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
			// app.UseEntityWorks();

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

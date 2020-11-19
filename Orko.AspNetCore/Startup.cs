using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orko.EntityWorks.AspNetCore;
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
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		#region Propertiji
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
			// Add routing.
			services.AddRouting(options => { options.LowercaseUrls = true; options.LowercaseQueryStrings = true; });

			// Add controllers and views.
			services.AddControllersWithViews();

			// Add EntityWorks.
			services.AddEntityWorks(Configuration);

			// Add EntityWorks Generator.
			services.AddEntityWorksGenerator(Configuration);
		}

		/// <summary>
		/// Configuration of the HTTP request pipeline.
		/// </summary>
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// Environment prologue.
			if (env.IsDevelopment())
			{
				// Use developer exception page.
				app.UseDeveloperExceptionPage();

				// Use entity works generator.
				app.UseEntityWorksGenerator();
			}

			// Koristi HRV culture.
			var cultureString = "hr";
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

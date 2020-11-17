using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orko.EntityWorks.AspNetCore;
using System;
using System.Collections.Generic;
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
		}

		/// <summary>
		/// Configuration of the HTTP request pipeline.
		/// </summary>
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// Environment prologue.
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			// Use EntityWorks.
			app.UseEntityWorks(options =>
			{
				// Map context names.
				options.GuestContextName = "EntityWorksGuest";
				options.RootContextName = "EntityWorksRoot";
				options.UserContextName = "EntityWorksUser";

				// Debug mode on.
				options.DebugMode = true;

				// Localization.
				options.CultureCode = "EN";

				// User context transformation.
				//options.DatabaseClaimName = nameof(OrkoClaimTypes.UserDatabase);
			});

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

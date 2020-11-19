using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Orko.AspNetCore
{
	/// <summary>
	/// Main application class.
	/// </summary>
	public class Program
	{
		/// <summary>
		/// Application entry point.
		/// </summary>
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		/// <summary>
		/// Creates host builder.
		/// </summary>
		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}

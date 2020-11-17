using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orko.AspNetCore;
using Orko.EntityWorks;
using System.Text.Json;
using Orko.AspNetCore.Models;
using Orko.EntityWorks.Generator;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Orko.AspNetCore.Controllers
{
	/// <summary>
	/// EntityWorks test controller.
	/// </summary>
	public class TestController : Controller
	{
		#region Constructrors
		public TestController(IConfiguration configuration)
		{

		}
		#endregion

		/// <summary>
		/// Database read test.
		/// </summary>
		[HttpGet("/")]
		public async Task<IActionResult> QueryTest1()
		{
			// Simple query.
			var query = new Query();
			
			// Select.
			query.Select("Drzava.DrzavaDrzava", "TwoLetterCode");
			query.Select("Drzava.DrzavaTroslovnaKratica", "ThreeLetterCode");
			query.Select("Drzava.DrzavaKod", "Code");
			query.Select("DrzavaNaziv", "Name");
			query.From("Base.Drzava");

			// Join language table.
			query.Join("Base.Drzava_jezik AS jezik",
				new QueryCondition("jezik.DrzavaDrzava", QueryOp.Equal, "Drzava.DrzavaDrzava"),
				new QueryCondition("jezik.DrzavaJezik", QueryOp.Equal, Query.Quote("EN")));

			// Map to model.
			var result = await query.GetObjectCollectionAsync<Country>();

			// To Json.
			var jsonResult = JsonSerializer.Serialize<IEnumerable<Country>>(result, null);

			return Content(jsonResult, "application/json");
		}

		/// <summary>
		/// Database generator test.
		/// </summary>
		[HttpGet("/generate")]
		public async Task<IActionResult> GeneratorTest()
		{
			// Create settings.
			var settings = new EntityGeneratorSettings();
			settings.LanguageTableSuffix = "jezik";
			settings.UseLanguageTables = true;
			settings.UseParallelProcessing = true;
			settings.UseSchemaNamespacing = true;

			// Get connection string.
			var connectionString = "Data Source=DESKTOP-JLE7CPB;Initial Catalog=Orko;Integrated Security=True";

			// Create generator.
			var generator = new Generator(
				new Database(settings, connectionString, true),
				new DirectoryInfo("C:\\GeneratorTest\\"));

			// Generate domain and logic classes.
			await generator.GenerateAllAsync();

			// Return OK.
			return Content("OK");
		}
	}
}

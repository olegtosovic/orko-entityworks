using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
//using Northwind;
//using Northwind.Dbo;
using Orko.AspNetCore.Models;
using Orko.EntityWorks;
using Orko.EntityWorks.Generator;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Orko.AspNetCore.Controllers
{
	/// <summary>
	/// EntityWorks test controller.
	/// </summary>
	public class TestController : Controller
	{
		#region Constructrors
		public TestController(EntityWorksContext context)
		{
			// It's a same instance throught request lifecycle.
			var guidConstructor = context.m_guid;
			var guidStaticCall = EntityWorksContext.GetEntityWorksContext().m_guid;
		}
		#endregion

		/// <summary>
		/// Database read test.
		/// </summary>
		[HttpGet("/test-entityworks")]
		public async Task<IActionResult> TestDbEntityWorks()
		{

			// Simple query.
			var query = new Query();

			// Get entity works context.
			var entityWorksContext = EntityWorksContext.GetEntityWorksContext();
			
			// Select.
			query.Select("Drzava.DrzavaDrzava", "TwoLetterCode");
			query.Select("Drzava.DrzavaTroslovnaKratica", "ThreeLetterCode");
			query.Select("Drzava.DrzavaKod", "Code");
			query.Select("DrzavaNaziv", "Name");
			query.From("Base.Drzava");

			// Join language table.
			query.Join("Base.Drzava_jezik AS jezik",
				new QueryCondition("jezik.DrzavaDrzava", QueryOp.Equal, "Drzava.DrzavaDrzava"),
				new QueryCondition("jezik.DrzavaJezik", QueryOp.Equal, Query.Quote(entityWorksContext.LanguageCode)));

			// Map to model.
			var result = await query.GetObjectCollectionAsync<Country>();

			// To Json.
			var jsonResult = JsonSerializer.Serialize<IEnumerable<Country>>(result, null);

			return Content(jsonResult, "application/json");
		}

		/// <summary>
		/// Database read test.
		/// </summary>
		[HttpGet("/test-adventureworks")]
		public async Task<IActionResult> TestDbAventureWorks()
		{
			// Simple query.
			var query = new Query();

			// Get entity works context.
			var entityWorksContext = EntityWorksContext.GetEntityWorksContext();

			// Select.
			query.Select("Drzava.DrzavaDrzava", "TwoLetterCode");
			query.Select("Drzava.DrzavaTroslovnaKratica", "ThreeLetterCode");
			query.Select("Drzava.DrzavaKod", "Code");
			query.Select("DrzavaNaziv", "Name");
			query.From("Base.Drzava");

			// Join language table.
			query.Join("Base.Drzava_jezik AS jezik",
				new QueryCondition("jezik.DrzavaDrzava", QueryOp.Equal, "Drzava.DrzavaDrzava"),
				new QueryCondition("jezik.DrzavaJezik", QueryOp.Equal, Query.Quote(entityWorksContext.LanguageCode)));

			// Map to model.
			var result = await query.GetObjectCollectionAsync<Country>();

			// To Json.
			var jsonResult = JsonSerializer.Serialize<IEnumerable<Country>>(result, null);

			return Content(jsonResult, "application/json");
		}

		/// Database read test.
		/// </summary>
		//[HttpGet("/test-northwind")]
		//public async Task<IActionResult> TestDbNorthwind()
		//{
		//	var result = await Categories.GetCategories(5);

		//	// To Json.
		//	var jsonResult = JsonSerializer.Serialize<IEnumerable<Categories>>(result, null);

		//	return Content(jsonResult, "application/json");
		//}

		/// <summary>
		/// Database generator test.
		/// </summary>
		[HttpGet("/generate")]
		public async Task<IActionResult> TestEntityWorksGenerator()
		{
			// Get generator instance. Could be done via constructor injection but it not important.
			var entityWorksGenerator = this.HttpContext.RequestServices.GetService<EntityWorksGenerator>();

			// Generate domain and logic classes.
			await entityWorksGenerator.GenerateAllAsync();

			// Return OK.
			return Content("OK");
		}
	}
}

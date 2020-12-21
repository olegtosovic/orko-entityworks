using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Dbo;
using Orko.AspNetCore.Models;
using Orko.EntityWorks;
using Orko.EntityWorks.Generator;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace Orko.AspNetCore.Controllers
{
	/// <summary>
	/// EntityWorks test controller.
	/// </summary>
	public class TestController : Controller
	{
		#region Constructrors
		/// <summary>
		/// Creates instance of test controller.
		/// </summary>
		public TestController()
		{

		}
		#endregion

		#region CRUD actions
		[HttpGet("/test-northwind")]
		public async Task<IActionResult> TestNorthwind()
		{
			// Get all orders.
			var orders = await Northwind.Dbo.Orders.GetByAnyAsync();

			// Convert data to json.
			var jsonResult = JsonSerializer.Serialize(orders, null);

			// Display json data.
			return Content(jsonResult, "application/json");
		}

		#endregion

		#region QUERY actions
		#endregion

		#region Entity mapping actions
		/// <summary>
		/// Database read test.
		/// </summary>
		[HttpGet("/test-orko")]
		public async Task<IActionResult> TestEntityContext()
		{
			// Use specific query context, instead of ambient.
			//using (var context = new QueryContext("Orko"))
			//{
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
				new QueryCondition("jezik.DrzavaJezik", QueryOp.Equal, Query.Quote("HR")));

			// Get data.
			var result = await query.GetObjectCollectionAsync<Country>();

			// Convert data to json.
			var jsonResult = JsonSerializer.Serialize(result, null);

			// Display json data.
			return Content(jsonResult, "application/json");
			//}
		}

		// Database read test.
		[HttpGet("/test-northwind1")]
		public async Task<IActionResult> TestDbNorthwind1()
		{
			// Use northwind.
			using (var context = new QueryContext("Northwind"))
			{
				// Get data.
				var result = await OrderDetails.GetByAnyAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize<IEnumerable<OrderDetails>>(result, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		#endregion

		#region Entity generator test actions
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
		#endregion
	}
}

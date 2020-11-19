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
		#region Generator
		/// <summary>
		/// Entity works generator service.
		/// </summary>
		private EntityWorksGenerator m_generator;
		#endregion

		#region Constructrors
		public TestController(EntityWorksGenerator entityWorksGenerator)
		{
			// Set service.
			m_generator = entityWorksGenerator;
		}
		#endregion

		/// <summary>
		/// Database read test.
		/// </summary>
		[HttpGet("/")]
		public async Task<IActionResult> TestEntityWorks()
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
		/// Database generator test.
		/// </summary>
		[HttpGet("/generate")]
		public async Task<IActionResult> TestEntityWorksGenerator()
		{
			// Generate domain and logic classes.
			await m_generator.GenerateAllAsync();

			// Return OK.
			return Content("OK");
		}
	}
}

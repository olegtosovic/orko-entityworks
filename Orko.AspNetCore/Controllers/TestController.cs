using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using AdventureWorks;
using Northwind;
using Orko.AspNetCore.Models;
using Orko.EntityWorks;
using Orko.EntityWorks.Generator;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System;
using System.Linq;

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

		#region Default
		/// <summary>
		/// Default route.
		/// </summary>
		[HttpGet("/")]
		public IActionResult Index()
		{
			return Content("Ready");
		}
		#endregion

		#region CRUD actions

		#region Northwind
		/// <summary>
		/// Gets all records from northwind orders table and displays them as json data.
		/// </summary>
		[HttpGet("/nw-orders-get-all")]
		public async Task<IActionResult> NorthwindGetAll()
		{
			// Use northwind tunnel.
			using (var context = new NorthwindContext())
			{
				// Get all orders.
				var orders = await Northwind.Dbo.Orders.GetByAnyAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(orders, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		/// <summary>
		/// Gets single record by primary key from northwind orders table and displays it as json data.
		/// </summary>
		[HttpGet("/nw-orders-get-single")]
		public async Task<IActionResult> NorthwindGetSingle()
		{
			// Use northwind tunnel.
			using (var context = new NorthwindContext())
			{
				// Get order where id == 10248.
				var order = await Northwind.Dbo.Orders.GetByPrimaryKeyAsync(10248);

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(order, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		/// <summary>
		/// Gets single record by primary key, update it's data on northwind orders table and displays it as json data.
		/// </summary>
		[HttpGet("/nw-orders-get-singleupdate")]
		public async Task<IActionResult> NorthwindGetSingleUpdate()
		{
			// Use northwind tunnel.
			using (var context = new NorthwindContext())
			{
				// Get order where id == 10248.
				var order = await Northwind.Dbo.Orders.GetByPrimaryKeyAsync(10248);

				// Update record with random data.
				order.Freight = (decimal)new Random().NextDouble();
				order.ShipName = order.ShipName + " _rand" + new Random().Next();
				order.ShipAddress = order.ShipAddress + " _rand" + new Random().Next();
				order.ShippedDate = DateTime.Now;
				order.RequiredDate = DateTime.Now.AddDays(-1);

				// Persist.
				await order.SaveAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(order, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		/// <summary>
		/// Inserts single record, set it's data by copying data from other record on northwind orders table and displays it as json data.
		/// </summary>
		[HttpGet("/nw-orders-insert")]
		public async Task<IActionResult> NorthwindGetSingleInsert()
		{
			// Use northwind tunnel.
			using (var context = new NorthwindContext())
			{
				// Get order where id == 10248.
				var order = await Northwind.Dbo.Orders.GetByPrimaryKeyAsync(10248);

				// Create copy of order object.
				var newOrder = order.Clone();

				// Persist.
				await newOrder.SaveAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(newOrder, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		/// <summary>
		/// Gets last record on northwind orders table, delete it and display it as json data.
		/// </summary>
		[HttpGet("/nw-orders-delete")]
		public async Task<IActionResult> NorthwindGetSingleDelete()
		{
			// Use northwind tunnel.
			using (var context = new NorthwindContext())
			{
				// Last query.
				var lastOrderQuery = new Query()
					.Select("MAX(OrderID)")
					.From("Orders");

				// Get last order.
				var order = (await Northwind.Dbo.Orders.GetByAnyAsync(
					new QueryCondition("OrderID", QueryOp.Equal, lastOrderQuery)))
					.FirstOrDefault();

				// Delete.
				await order.DeleteAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(order, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		#endregion

		#region AventureWorks
		/// <summary>
		/// Gets all records from adventureworks orders table and displays them as json data.
		/// </summary>
		[HttpGet("/aw-orders-get-all")]
		public async Task<IActionResult> AdventureWorksGetAll()
		{
			// Use adventureworks tunnel.
			using (var context = new AdventureWorksContext())
			{
				// Get all orders.
				var orders = await AdventureWorks.Sales.SalesOrderHeader.GetByAnyAsync();

				// Get all addresses.
				var addresses = await AdventureWorks.Person.Address.GetByAnyAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(addresses, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		/// <summary>
		/// Gets single record by primary key from adventureworks orders table and displays it as json data.
		/// </summary>
		[HttpGet("/aw-orders-get-single")]
		public async Task<IActionResult> AdventureWorksGetSingle()
		{
			// Use adventureworks tunnel.
			using (var context = new AdventureWorksContext())
			{
				// Get order where id == 10248.
				var order = await Northwind.Dbo.Orders.GetByPrimaryKeyAsync(10248);

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(order, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		/// <summary>
		/// Gets single record by primary key, update it's data on adventureworks orders table and displays it as json data.
		/// </summary>
		[HttpGet("/aw-orders-get-singleupdate")]
		public async Task<IActionResult> AdventureWorksGetSingleUpdate()
		{
			// Use adventureworks tunnel.
			using (var context = new AdventureWorksContext())
			{
				// Get order where id == 10248.
				var order = await Northwind.Dbo.Orders.GetByPrimaryKeyAsync(10248);

				// Update record with random data.
				order.Freight = (decimal)new Random().NextDouble();
				order.ShipName = order.ShipName + " _rand" + new Random().Next();
				order.ShipAddress = order.ShipAddress + " _rand" + new Random().Next();
				order.ShippedDate = DateTime.Now;
				order.RequiredDate = DateTime.Now.AddDays(-1);

				// Persist.
				await order.SaveAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(order, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		/// <summary>
		/// Inserts single record, set it's data by copying data from other record on adventureworks orders table and displays it as json data.
		/// </summary>
		[HttpGet("/aw-orders-insert")]
		public async Task<IActionResult> AdventureWorksGetSingleInsert()
		{
			// Use adventureworks tunnel.
			using (var context = new AdventureWorksContext())
			{
				// Get order where id == 10248.
				var order = await Northwind.Dbo.Orders.GetByPrimaryKeyAsync(10248);

				// Create copy of order object.
				var newOrder = order.Clone();

				// Persist.
				await newOrder.SaveAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(newOrder, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		/// <summary>
		/// Gets last record on adventureworks orders table, delete it and display it as json data.
		/// </summary>
		[HttpGet("/aw-orders-delete")]
		public async Task<IActionResult> AdventureWorksGetSingleDelete()
		{
			// Use adventureworks tunnel.
			using (var context = new AdventureWorksContext())
			{
				// Last query.
				var lastOrderQuery = new Query()
					.Select("MAX(OrderID)")
					.From("Orders");

				// Get last order.
				var order = (await Northwind.Dbo.Orders.GetByAnyAsync(
					new QueryCondition("OrderID", QueryOp.Equal, lastOrderQuery)))
					.FirstOrDefault();

				// Delete.
				await order.DeleteAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize(order, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		#endregion

		#endregion

		#region QUERY actions

		#region Northwind
		#endregion

		#region AdventureWorks
		#endregion

		#endregion

		#region FEATURES actions
		#endregion

		#region ENTITY GENERATOR actions
		/// <summary>
		/// Performs entity class generation for provided connection contexts.
		/// </summary>
		[HttpGet("/generate")]
		public async Task<IActionResult> GenerateEntites()
		{
			// Get generator instance. Could be done via constructor injection but it not important.
			var entityWorksGenerator = this.HttpContext.RequestServices.GetService<EntityWorksGenerator>();

			// Generate domain, logic and static classes.
			await entityWorksGenerator.GenerateAllAsync();

			// Return OK.
			return Content("OK");
		}
		#endregion
	}
}

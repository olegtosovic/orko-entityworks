using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using AdventureWorks.Sales;
using Orko.EntityWorks;

namespace Orko.WinConsole.Benchmarks
{
	/// <summary>
	/// Object performing benchmark on CRUD operations.
	/// </summary>
	[MemoryDiagnoser]
	public class BenchmarkAdventureWorks
	{
		#region Members
		/// <summary>
		/// Consumer.
		/// </summary>
		private readonly Consumer consumer = new Consumer();
		#endregion

		#region Constructors
		/// <summary>
		/// Creates northwind benchmark object.
		/// </summary>
		public BenchmarkAdventureWorks()
		{
			// Create entity works runtime configurator.
			var entityWorksConfiguration = new EntityWorksConfiguration();

			// Initialize entity works runtime.
			entityWorksConfiguration.InitializeEntityWorks();

			// Type metadata caching.
			var orders = SalesOrderDetail.GetByAnyAsync().Result;
		}
		#endregion

		#region CRUD
		/// <summary>
		/// Gets all orders from adwentureworks database.
		/// </summary>
		[Benchmark]
		public async Task GetOrdersAsync()
		{
			// Get orders.
			var orders = await SalesOrderDetail.GetByAnyAsync();

			// Consume.
			orders.Consume(consumer);
		}
		#endregion
	}
}

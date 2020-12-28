using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Northwind.Dbo;
using Orko.EntityWorks;

namespace Orko.WinConsole.Benchmarks
{
	/// <summary>
	/// Object performing benchmark on CRUD operations.
	/// </summary>
	[MemoryDiagnoser]
	public class BenchmarkNorthwind
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
		public BenchmarkNorthwind()
		{
			// Create entity works runtime configurator.
			var entityWorksConfiguration = new EntityWorksConfiguration();

			// Initialize entity works runtime.
			entityWorksConfiguration.InitializeEntityWorks();
		}
		#endregion
		
		#region CRUD
		/// <summary>
		/// Gets all orders from northwind database.
		/// </summary>
		[Benchmark]
		public async Task GetOrdersAsync()
		{
			// Get orders.
			var orders = await Orders.GetByAnyAsync();

			// Consume.
			orders.Consume(consumer);
		}
		#endregion
	}
}

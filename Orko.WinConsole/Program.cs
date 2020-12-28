using System;
using System.Threading.Tasks;
using AdventureWorks.Sales;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using Northwind.Dbo;
using Orko.WinConsole.Benchmarks;

namespace Orko.WinConsole
{
	/// <summary>
	/// Main class.
	/// </summary>
	class Program
	{
		/// <summary>
		/// Entry method.
		/// </summary>
		static void Main(string[] args)
		{
			// Run benchmark.
			BenchmarkRunner.Run<BenchmarkAdventureWorks>();

			// Create entity works runtime configurator.
			var entityWorksConfiguration = new EntityWorksConfiguration();

			// Initialize entity works runtime.
			entityWorksConfiguration.InitializeEntityWorks();

			// Type metadata caching.
			var orders = SalesOrderDetail.GetByAnyAsync().Result;

			// Write ok.
			Console.WriteLine("Done!");
		}
	}
}

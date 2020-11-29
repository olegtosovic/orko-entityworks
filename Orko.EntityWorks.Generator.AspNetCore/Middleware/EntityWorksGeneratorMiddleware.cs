using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator.AspNetCore
{
	/// <summary>
	/// Entity works runtime middleware.
	/// </summary>
	public class EntityWorksGeneratorMiddleware
	{
		#region Members
		/// <summary>
		/// Request delegate.
		/// </summary>
		private readonly RequestDelegate m_next;
		/// <summary>
		/// Entity works options exposing entity works context.
		/// </summary>
		private EntityWorksGeneratorOptions m_options;
		#endregion

		#region Constructors
		/// <summary>
		/// Creates entityworks middleware object.
		/// </summary>
		/// <param name="options">EntityWorksGenerator configuration options</param>
		public EntityWorksGeneratorMiddleware(RequestDelegate next, EntityWorksGeneratorOptions options)
		{
			// Set members.
			this.m_next = next;
			this.m_options = options;
		}
		#endregion

		#region Invoke
		/// <summary>
		/// Middleware invoke method.
		/// </summary>
		public async Task Invoke(HttpContext context, IConfiguration configuration)
		{
			// Get entity works generator instance.
			var entityWorksGenerator = context.RequestServices.GetService<EntityWorksGenerator>();

			// Set options to each database.
			entityWorksGenerator.SetEntityWorksGeneratorOptions(m_options);

			// Continue.
			await m_next(context);
		}
		#endregion		
	}
}

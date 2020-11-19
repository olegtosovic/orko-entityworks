using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
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
		public EntityWorksGeneratorMiddleware(RequestDelegate next)
		{
			// Set members.
			this.m_next = next;
			this.m_options = new EntityWorksGeneratorOptions()
			{
				
			};
		}
		/// <summary>
		/// Creates entityworks middleware object.
		/// </summary>
		/// <param name="options">EntityWorks configuration options</param>
		public EntityWorksGeneratorMiddleware(RequestDelegate next, Action<EntityWorksGeneratorOptions> options)
		{
			// Set members.
			this.m_next = next;
			options(m_options);
		}
		#endregion

		#region Invoke
		public async Task Invoke(HttpContext context, IConfiguration configuration)
		{
			// Get entity works generator instance.
			var entityWorksGenerator = context.RequestServices.GetService<EntityWorksGenerator>();

			// Set additional options.

			// Continue.
			await m_next(context);
		}
		#endregion

		#region Private methods		
		#endregion
	}
}

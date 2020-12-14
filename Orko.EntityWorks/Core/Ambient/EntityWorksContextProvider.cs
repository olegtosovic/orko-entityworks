using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks.Exceptions;

[assembly: InternalsVisibleTo("Orko.EntityWorks.AspNetCore")]
namespace Orko.EntityWorks
{
	/// <summary>
	/// Entity works context provider.
	/// In desktop environments static constructor will give single instance per application.
	/// In web enviroment this instance will not be used if context factory method is set.
	/// </summary>
	internal static class EntityWorksContextProvider
	{
		#region Members
		/// <summary>
		/// Static entityworks context instance for desktop environment.
		/// </summary>
		private static EntityWorksContext m_entityWorksContext;
		/// <summary>
		/// Dynamic entitity context instance for web environment.
		/// </summary>
		private static Func<EntityWorksContext> m_contextFactory;
		#endregion

		#region Constructors
		/// <summary>
		/// Default static constructor.
		/// </summary>
		static EntityWorksContextProvider()
		{
			// Set defaults.
			m_entityWorksContext = new EntityWorksContext();
			m_contextFactory = null;
		}
		#endregion

		#region Factory
		/// <summary>
		/// Set entityworks context factory.
		/// This is uses for web environments where every request has to have it's own instance.
		/// </summary>
		public static void SetEntityWorksContextFactory(Func<EntityWorksContext> factory)
		{
			// Validate factory.
			if (m_contextFactory != null)
				throw new EntityWorksException("EntityWorksContext factory already set.");
			if (factory == null)
				throw new EntityWorksException("EntityWorksContext factory cannot be null. Make sure to initialize proper method that retrieves valid instance.");

			// Set factory.
			m_contextFactory = factory;
		}
		#endregion

		#region Public static metode
		public static EntityWorksContext GetEntityWorksContext()
		{
			// Instance reference.
			EntityWorksContext instance = null;

			// Get instance.
			if (m_contextFactory != null)
				instance = m_contextFactory();
			else instance = m_entityWorksContext;

			// Return instance.
			return instance;
		}
		#endregion
	}
}

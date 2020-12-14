using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Provides functionality for object mapping.
	/// </summary>
	internal static class ObjectMechanic<TObject> where TObject : class, new()
    {
        #region Constructors
        static ObjectMechanic()
        {
            // Create entity context.
            ObjectContext = new ObjectContext<TObject>();
        }
        #endregion

        #region Context
        public static ObjectContext<TObject> ObjectContext { get; private set; }
        #endregion

        #region Main methods
        /// <summary>
        /// Get collection by sql command.
        /// </summary>
        public static IEnumerable<TObject> GetByQueryCommand(DbCommand command, ObjectMappingType objectMappingType)
        {
            // Create instance of return collection
            var objectCollection = new List<TObject>();

			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

			// Create connection to database from ambient query context.
			using (DbConnection connection = ambientContext.CreateConnection())
			{
                // Pass connection to command object.
                command.Connection = connection;

                // Open connection to database
                connection.Open();

                // Execute Sql data reader
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    // Create mapper.
                    var objectMapper = new ObjectMapper<TObject>(objectMappingType, dataReader);

                    // Read data.
                    while (dataReader.Read())
                    {
                        // Create new TEntity instance
                        var @object = new TObject();

                        // Map raw data to object.
                        objectMapper.MapToObject(@object, dataReader);

                        // Add entity to collection
                        objectCollection.Add(@object);
                    }
                }
            }

            // Return object collection.
            return objectCollection;
        }        
		/// <summary>
		/// Get collection by sql command async.
		/// </summary>
		public static async Task<IEnumerable<TObject>> GetByQueryCommandAsync(DbCommand command, ObjectMappingType objectMappingType)
		{
			// Create instance of return collection
			var objectCollection = new List<TObject>();

			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

			// Create connection to database from ambient query context.
			using (var connection = ambientContext.CreateConnection())
			{
				// Pass connection to command object.
				command.Connection = connection;

				// Open connection to database
				await connection.OpenAsync();

				// Execute Sql data reader
				using (var dataReader = await command.ExecuteReaderAsync())
				{
					// Create mapper.
					var objectMapper = new ObjectMapper<TObject>(objectMappingType, dataReader);

					// Read data.
					while (await dataReader.ReadAsync())
					{
						// Create new TEntity instance
						var @object = new TObject();

						// Map raw data to object.
						objectMapper.MapToObject(@object, dataReader);

						// Add entity to collection
						objectCollection.Add(@object);
					}
				}
			}

			// Return object collection.
			return objectCollection;
		}
		#endregion
	}
}

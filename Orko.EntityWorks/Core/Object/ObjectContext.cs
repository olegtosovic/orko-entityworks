using System.Collections.Generic;
using System.Reflection;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Contains all net type metadata for object in context.
	/// This object is created only once for particular object type and it's called from static clr cache for future usage.
	/// </summary>
	public class ObjectContext<TObject> where TObject : class, new()
    {
        #region Constructors
        internal ObjectContext()
        {
            // Create instances.
            Properties = new Dictionary<string, Property<TObject>>();

            // Caching.
            CacheTypeInfo();
            CacheProperties();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Dictionary containing all entity object properties.
        /// </summary>
        public Dictionary<string, Property<TObject>> Properties { get; private set; }
        /// <summary>
        /// Object type info.
        /// </summary>
        public TypeInfo ObjectTypeInfo { get; internal set; }
        #endregion

        #region Cache methods
        protected virtual void CacheProperties()
        {
            // Get reflection properties.
            BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic;
            PropertyInfo[] properties = ObjectTypeInfo.GetProperties(bindingFlags);

            // Create property.
            foreach (var propertyInfo in properties)
            {
                var property = new Property<TObject>(propertyInfo);
                Properties.Add(property.PropertyName, property);
            }
        }
        protected void CacheTypeInfo()
        {
            TypeInfo objectTypeInfo = typeof(TObject).GetTypeInfo();
            ObjectTypeInfo = objectTypeInfo;
        }
        #endregion

        #region Public static methods
        /// <summary>
        /// Retrieves entity data context of calling static type.
        /// </summary>
        public static ObjectContext<TObject> GetObjectContext()
        {
            return ObjectMechanic<TObject>.ObjectContext;
        }
        #endregion
    }
}

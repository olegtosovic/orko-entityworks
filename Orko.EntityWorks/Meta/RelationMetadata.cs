using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    /// <summary>
    /// Represent entity member properties foreign key relations.
    /// </summary>
    public class RelationMetadata
    {
        #region Constructors
        /// <summary>
        /// Creates instance of entity foreign key relationship metadata.
        /// </summary>
        /// <param name="propertyName">Name of the property that represents foreign key entity</param>
        /// <param name="foreignKeyField">Name of the property that represents entity foreign key column in this table</param>
        /// <param name="primaryKeyField">Name of the property that represents entity primary key column in external table</param>
        public RelationMetadata(string propertyName, string foreignKeyProperty, string primaryKeyProperty)
        {
            // Set members.
            PropertyName = propertyName;
            ForeignKeyProperty = foreignKeyProperty;
            PrimaryKeyProperty = primaryKeyProperty;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Property of entity type that represents foreign key relation.
        /// </summary>
        public string PropertyName { get; private set; }
        /// <summary>
        /// Column property that represents column in primary key table.
        /// </summary>
        public string ForeignKeyProperty { get; private set; }
        /// <summary>
        /// Column property that represents column in foreign key table.
        /// </summary>
        public string PrimaryKeyProperty { get; private set; }
        #endregion
    }
}

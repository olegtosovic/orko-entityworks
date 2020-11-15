using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
    public class RelationMetadata
    {
        #region Constructors
        public RelationMetadata(string entityColumnName, string foreignKeyField, string primaryKeyField)
        {
            EntityColumnName = entityColumnName;
            PrimaryKeyField = primaryKeyField;
            ForeignKeyField = foreignKeyField;
        }
        #endregion

        #region Properties
        public string EntityColumnName { get; private set; }
        public string PrimaryKeyField { get; private set; }
        public string ForeignKeyField { get; private set; }
        #endregion
    }
}

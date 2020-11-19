using System;

namespace Orko.EntityWorks.Generator
{
    public class Relation
    {
        #region Constructors
        public Relation
            (
            string foreignKeyTableName,
            string foreignKeyTableSchema,
            string foreignKeyTableFullName,
            string foreignKeyTableColumnName,
            string primaryKeyTableName,
            string primaryKeyTableSchema,
            string primaryKeyTableColumnName,
            string primaryKeyTableFullName
            )
        {
            ForeignKeyTableColumnName = foreignKeyTableColumnName;
            ForeignKeyTableName = foreignKeyTableName;
            ForeignKeyTableSchema = foreignKeyTableSchema;
            ForeignKeyTableFullName = foreignKeyTableFullName;
            PrimaryKeyTableFullName = primaryKeyTableFullName;
            PrimaryKeyTableName = primaryKeyTableName;
            PrimaryKeyTableSchema = primaryKeyTableSchema;
            PrimaryKeyTableColumnName = primaryKeyTableColumnName;
        }
        #endregion

        #region Properties
        public string PrimaryKeyTableName { get; private set; }
        public string PrimaryKeyTableSchema { get; private set; }
        public string PrimaryKeyTableFullName { get; private set; }
        public string PrimaryKeyTableColumnName { get; private set; }
        public string ForeignKeyTableName { get; private set; }
        public string ForeignKeyTableColumnName { get; private set; }
        public string ForeignKeyTableSchema { get; private set; }
        public string ForeignKeyTableFullName { get; private set; }
        #endregion
    }
}

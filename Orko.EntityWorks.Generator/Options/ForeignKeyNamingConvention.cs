using System.IO;

namespace Orko.EntityWorks.Generator
{
    /// <summary>
    /// Foreign key name entity generator convention.
    /// </summary>
    public enum ForeignKeyNamingConvention
    {
        /// <summary>
        /// Full foreign key name will be used as entity name.
        /// </summary>
        FK_FN,
        /// <summary>
        /// Last segment of foreign key name will be used as entity name.
        /// </summary>
        FK_LS,
        /// <summary>
        /// First ordinal column (that is party of foreign key) full name will be used as entity name.
        /// </summary>
        FK_FC_FN,
        /// <summary>
        /// First ordinal column (that is party of foreign key) full name will be used as entity name with id suffix stripped.
        /// </summary>
        FK_FC_FN_NID,
        /// <summary>
        /// First ordinal column (that is party of foreign key) name without table name preffix will be used as entity name.
        /// </summary>
        FK_FC_NTBL_FN
    }
}
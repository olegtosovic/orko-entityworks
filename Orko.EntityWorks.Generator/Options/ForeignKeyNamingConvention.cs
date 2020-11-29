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
        ForeignKeyFullName,
        /// <summary>
        /// Last segment of foreign key name will be used as entity name.
        /// </summary>
        ForeignKeyNameLastSegment,
        /// <summary>
        /// Second segment of foreign key name will be used as entity name.
        /// </summary>
        ForeignKeyNameLastTwoSegments,
        /// <summary>
        /// First ordinal column (that is party of foreign key) full name will be used as entity name.
        /// </summary>
        FirstColumnFullName,
        /// <summary>
        /// First ordinal column (that is party of foreign key) name without table name preffix will be used as entity name.
        /// </summary>
        FirstColumnNoTablePreffixName
    }
}
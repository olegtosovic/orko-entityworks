using System;
using System.Collections.Generic;
using System.IO;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Entity generator options for profiling entity generation.
	/// </summary>
	public class EntityGeneratorOptions
    {
        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public EntityGeneratorOptions()
        {
            // Must be set by the user.
            OutputDirectory = null;

            // Generate only async methods by default.
            GenerateOnlyAsyncTemplates = true;
        }
        #endregion

        #region Delegates
        /// <summary>
        /// Custom foreign key converter delegate.
        /// </summary>
        /// <param name="dbForeignKeyName">Foreign key constraint name</param>
        /// <param name="dbForeignKeyColumnsNames">Foreign key columns names</param>
        /// <returns>Entity property C# valid name</returns>
        public delegate string ForeignKeyNameNamingConverterDelegate(string dbForeignKeyName, IEnumerable<string> dbForeignKeyColumnsNames = null);
        #endregion

        #region Directives
        /// <summary>
        /// If true, generator will only generate async version of methods that may exist in class templates.
        /// </summary>
        public bool GenerateOnlyAsyncTemplates { get; set; }
        #endregion

        #region Options
        /// <summary>
        /// Output directory where code files will be generated.
        /// </summary>
        public DirectoryInfo OutputDirectory { get; set; }
        #endregion
    }
}

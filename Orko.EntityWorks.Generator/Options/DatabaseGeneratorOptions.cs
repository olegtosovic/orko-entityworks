﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;

namespace Orko.EntityWorks.Generator
{
    /// <summary>
    /// Database generator options for profiling entity generation.
    /// </summary>
    public class DatabaseGeneratorOptions
    {
        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public DatabaseGeneratorOptions()
        {
            // Safest options by default is to name entity by full foreign key name.
            ForeignKeyNamingConvention = ForeignKeyNamingConvention.FK_FN;

            // True by default. Was left for debuging purposes.
            UseParallelProcessing = false;

            // We can not presume by default that user will use entityworks language table structure.
            UseLanguageTables = false;

            // We can not presume by default that user database has all tables preffixed by some value.
            RemoveGlobalTablePreffix = false;

            // Default namespace is sql database name.
            Namespace = null;

            // Default provider assembly.
            DbProviderAssembly = null;

            // Default provider factory name.
            DbProviderFactory = null;
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
        /// If true, multiple threads will be used for database metadata construction.
        /// </summary>
        internal bool UseParallelProcessing { get; set; }
        /// <summary>
        /// if true, generator will take into account language tables which are named by user defined suffix.
        /// </summary>
        public bool UseLanguageTables { get; set; }
        /// <summary>
        /// If true, generator will remove table name name preffix, so generated entitys would have prettier name.
        /// </summary>
        public bool RemoveGlobalTablePreffix { get; set; }
        #endregion

        #region Options
        /// <summary>
        /// Custom foreign key converter delegate.
        /// </summary>
        public ForeignKeyNameNamingConverterDelegate ForeignKeyNameNamingConverter { get; set; }
        /// <summary>
        /// Foreign key name generator convention.
        /// </summary>
        public ForeignKeyNamingConvention ForeignKeyNamingConvention { get; set; }
        /// <summary>
        /// Db Provider assembly name.
        /// </summary>
        public string DbProviderAssembly { get; set; }
        /// <summary>
        /// Db Provider assembly factory.
        /// </summary>
        public string DbProviderFactory { get; set; }
        /// <summary>
        /// Table preffix to be removed for generated entities.
        /// </summary>
        public string GlobalTablePreffix { get; set; }
        /// <summary>
        /// Language table name suffix that marks table as language table.
        /// </summary>
        public string LanguageTableSuffix { get; set; }
        /// <summary>
        /// Custom namespace instead of default, where default is exact sql database name.
        /// </summary>
        public string Namespace { get; set; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
    /// <summary>
    /// Entity generator settings for profiling entity generation.
    /// </summary>
    public class EntityGeneratorSettings
    {
        #region Constructors
        public EntityGeneratorSettings()
        {
            // Set default values.
            SetDefaultValues();
        }
        #endregion

        #region Flags
        public bool UseParallelProcessing { get; set; }
        public bool UseLanguageTables { get; set; }
        public bool UseSchemaNamespacing { get; set; }
        public bool UseCustomNamespacing { get; set; }
        public bool RemoveGlobalTablePreffix { get; set; }
        #endregion

        #region Settings
        public string GlobalTablePreffix { get; set; }
        public string LanguageTableSuffix { get; set; }
        #endregion

        #region Private methods
        private void SetDefaultValues()
        {
            UseParallelProcessing = true;
            UseLanguageTables = false;
            UseSchemaNamespacing = true;
            UseCustomNamespacing = false;
            RemoveGlobalTablePreffix = false;
        }
        #endregion
    }
}

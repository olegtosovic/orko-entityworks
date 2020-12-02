// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.GuletCroatia
{
    /// <summary>
    /// VrstaOpreme entity.
    /// </summary>
    public sealed partial class VrstaOpreme : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static VrstaOpreme()
        {
            // Cache field metadata.
            EntityMeta<VrstaOpreme>.LoadColumnMetadata
			(
				new ColumnMetadata("VrstaOpremeVrstaOpreme", @"VrstaOpremeVrstaOpreme", SqlDbType.NVarChar, isPrimaryKey: true),
                new ColumnMetadata("VrstaOpremeNazivSlike", @"VrstaOpremeNazivSlike", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("VrstaOpremeBrojivo", @"VrstaOpremeBrojivo", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaOpremeAktivnost", @"VrstaOpremeAktivnost", SqlDbType.Bit, isRequired: true),
                new ColumnMetadata("VrstaOpremeJezik", @"VrstaOpremeJezik", SqlDbType.Char, isLanguageCode: true, isPrimaryKey: true),
                new ColumnMetadata("VrstaOpremeNaziv", @"VrstaOpremeNaziv", SqlDbType.NVarChar, isRequired: true, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<VrstaOpreme>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<VrstaOpreme>.HasLanguageTable = true;
            EntityMeta<VrstaOpreme>.TableSchema = @"GuletCroatia";
            EntityMeta<VrstaOpreme>.TableName = @"VrstaOpreme";
            EntityMeta<VrstaOpreme>.LanguageTableSchema = @"GuletCroatia";
            EntityMeta<VrstaOpreme>.LanguageTableName = @"VrstaOpreme_jezik";
        }
        #endregion

        #region Columns
        public string VrstaOpremeVrstaOpreme { get; set; }
        public string VrstaOpremeNazivSlike { get; set; }
        public bool? VrstaOpremeBrojivo { get; set; }
        public bool? VrstaOpremeAktivnost { get; set; }
        public string VrstaOpremeJezik { get; private set; }
        public string VrstaOpremeNaziv { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<VrstaOpreme>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<VrstaOpreme>(queryConditions);
        }
        public static async Task<IEnumerable<VrstaOpreme>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<VrstaOpreme>(columnName, queryOp, value);
        }
		public static async Task<VrstaOpreme> GetByPrimaryKeyAsync(string VrstaOpremeVrstaOpreme)
        {
            return await GetByPrimaryKeyAsync<VrstaOpreme>(VrstaOpremeVrstaOpreme);
        }
		public static async Task<VrstaOpreme> TryGetByPrimaryKeyAsync(string VrstaOpremeVrstaOpreme)
        {
            return await TryGetByPrimaryKeyAsync<VrstaOpreme>(VrstaOpremeVrstaOpreme);
        }
		#endregion

        #region Public methods
		public static IEnumerable<VrstaOpreme> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<VrstaOpreme>(queryConditions);
        }
        public static IEnumerable<VrstaOpreme> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<VrstaOpreme>(columnName, queryOp, value);
        }
		public static VrstaOpreme GetByPrimaryKey(string VrstaOpremeVrstaOpreme)
        {
            return GetByPrimaryKey<VrstaOpreme>(VrstaOpremeVrstaOpreme);
        }
		public static VrstaOpreme TryGetByPrimaryKey(string VrstaOpremeVrstaOpreme)
        {
            return TryGetByPrimaryKey<VrstaOpreme>(VrstaOpremeVrstaOpreme);
        }
        #endregion
    }
}
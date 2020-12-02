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

namespace Orko.Watersports
{
    /// <summary>
    /// RezervacijaStavkaUsluga entity.
    /// </summary>
    public sealed partial class RezervacijaStavkaUsluga : Entity
    {
		#region Members
		private Base.Protokol m_FK_RezervacijaStavkaUsluga_Rezervacija;
        private RezervacijaStavka m_FK_RezervacijaStavkaUsluga_RezervacijaStavka;
        private UslugaStavke m_FK_RezervacijaStavkaUsluga_UslugaStavke;
        #endregion
        
		#region Constructors
        static RezervacijaStavkaUsluga()
        {
            // Cache field metadata.
            EntityMeta<RezervacijaStavkaUsluga>.LoadColumnMetadata
			(
				new ColumnMetadata("RezervacijaStavkaUslugaID", @"RezervacijaStavkaUslugaID", SqlDbType.Int, isIdentity: true, isPrimaryKey: true),
                new ColumnMetadata("RezervacijaStavkaUslugaStavkaID", @"RezervacijaStavkaUslugaStavkaID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaUslugaProtokolID", @"RezervacijaStavkaUslugaProtokolID", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaUslugaRedniBroj", @"RezervacijaStavkaUslugaRedniBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaUslugaUslugaStavke", @"RezervacijaStavkaUslugaUslugaStavke", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("RezervacijaStavkaUslugaKolicina", @"RezervacijaStavkaUslugaKolicina", SqlDbType.Int, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<RezervacijaStavkaUsluga>.LoadRelationMetadata
			(
				new RelationMetadata("FK_RezervacijaStavkaUsluga_Rezervacija", "RezervacijaStavkaUslugaProtokolID", "ProtokolID"),
                new RelationMetadata("FK_RezervacijaStavkaUsluga_RezervacijaStavka", "RezervacijaStavkaUslugaStavkaID", "RezervacijaStavkaID"),
                new RelationMetadata("FK_RezervacijaStavkaUsluga_UslugaStavke", "RezervacijaStavkaUslugaUslugaStavke", "UslugaStavkeUslugaStavke")
			);

			// Cache table metadata.
			EntityMeta<RezervacijaStavkaUsluga>.HasLanguageTable = false;
            EntityMeta<RezervacijaStavkaUsluga>.TableSchema = @"Watersports";
            EntityMeta<RezervacijaStavkaUsluga>.TableName = @"RezervacijaStavkaUsluga";
            EntityMeta<RezervacijaStavkaUsluga>.LanguageTableSchema = null;
            EntityMeta<RezervacijaStavkaUsluga>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? RezervacijaStavkaUslugaID { get; private set; }
        public int? RezervacijaStavkaUslugaStavkaID { get; set; }
        public int? RezervacijaStavkaUslugaProtokolID { get; set; }
        public int? RezervacijaStavkaUslugaRedniBroj { get; set; }
        public string RezervacijaStavkaUslugaUslugaStavke { get; set; }
        public int? RezervacijaStavkaUslugaKolicina { get; set; }
        #endregion

        #region Entities
		public Base.Protokol FK_RezervacijaStavkaUsluga_Rezervacija
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_FK_RezervacijaStavkaUsluga_Rezervacija, this, "FK_RezervacijaStavkaUsluga_Rezervacija"); }
            set { EntityContext<Base.Protokol>.Set(ref m_FK_RezervacijaStavkaUsluga_Rezervacija, this, value, "FK_RezervacijaStavkaUsluga_Rezervacija"); }
        }
        public RezervacijaStavka FK_RezervacijaStavkaUsluga_RezervacijaStavka
        {
            get { return EntityContext<RezervacijaStavka>.Get(ref m_FK_RezervacijaStavkaUsluga_RezervacijaStavka, this, "FK_RezervacijaStavkaUsluga_RezervacijaStavka"); }
            set { EntityContext<RezervacijaStavka>.Set(ref m_FK_RezervacijaStavkaUsluga_RezervacijaStavka, this, value, "FK_RezervacijaStavkaUsluga_RezervacijaStavka"); }
        }
        public UslugaStavke FK_RezervacijaStavkaUsluga_UslugaStavke
        {
            get { return EntityContext<UslugaStavke>.Get(ref m_FK_RezervacijaStavkaUsluga_UslugaStavke, this, "FK_RezervacijaStavkaUsluga_UslugaStavke"); }
            set { EntityContext<UslugaStavke>.Set(ref m_FK_RezervacijaStavkaUsluga_UslugaStavke, this, value, "FK_RezervacijaStavkaUsluga_UslugaStavke"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<RezervacijaStavkaUsluga>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<RezervacijaStavkaUsluga>(queryConditions);
        }
        public static async Task<IEnumerable<RezervacijaStavkaUsluga>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<RezervacijaStavkaUsluga>(columnName, queryOp, value);
        }
		public static async Task<RezervacijaStavkaUsluga> GetByPrimaryKeyAsync(int RezervacijaStavkaUslugaID)
        {
            return await GetByPrimaryKeyAsync<RezervacijaStavkaUsluga>(RezervacijaStavkaUslugaID);
        }
		public static async Task<RezervacijaStavkaUsluga> TryGetByPrimaryKeyAsync(int RezervacijaStavkaUslugaID)
        {
            return await TryGetByPrimaryKeyAsync<RezervacijaStavkaUsluga>(RezervacijaStavkaUslugaID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<RezervacijaStavkaUsluga> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<RezervacijaStavkaUsluga>(queryConditions);
        }
        public static IEnumerable<RezervacijaStavkaUsluga> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<RezervacijaStavkaUsluga>(columnName, queryOp, value);
        }
		public static RezervacijaStavkaUsluga GetByPrimaryKey(int RezervacijaStavkaUslugaID)
        {
            return GetByPrimaryKey<RezervacijaStavkaUsluga>(RezervacijaStavkaUslugaID);
        }
		public static RezervacijaStavkaUsluga TryGetByPrimaryKey(int RezervacijaStavkaUslugaID)
        {
            return TryGetByPrimaryKey<RezervacijaStavkaUsluga>(RezervacijaStavkaUslugaID);
        }
        public static RezervacijaStavkaUsluga GetByUnique1(int RezervacijaStavkaUslugaProtokolID, int RezervacijaStavkaUslugaStavkaID, string RezervacijaStavkaUslugaUslugaStavke)
        {
            return GetByCallingParameters<RezervacijaStavkaUsluga>(RezervacijaStavkaUslugaProtokolID, RezervacijaStavkaUslugaStavkaID, RezervacijaStavkaUslugaUslugaStavke);
        }
		public static RezervacijaStavkaUsluga TryGetByUnique1(int RezervacijaStavkaUslugaProtokolID, int RezervacijaStavkaUslugaStavkaID, string RezervacijaStavkaUslugaUslugaStavke)
        {
            return TryGetByCallingParameters<RezervacijaStavkaUsluga>(RezervacijaStavkaUslugaProtokolID, RezervacijaStavkaUslugaStavkaID, RezervacijaStavkaUslugaUslugaStavke);
        }
        #endregion
    }
}
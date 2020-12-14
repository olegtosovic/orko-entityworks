// Generated on 12/14/2020 9:29 PM using EntityWorks code generation tool.
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
		private Base.Protokol m_Rezervacija;
        private RezervacijaStavka m_RezervacijaStavka;
        private UslugaStavke m_UslugaStavke;
        #endregion
        
		#region Constructors
        static RezervacijaStavkaUsluga()
        {
            // Cache field metadata.
            EntityMeta<RezervacijaStavkaUsluga>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(RezervacijaStavkaUslugaID), @"RezervacijaStavkaUslugaID", DbType.Int32, isIdentity: true, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaUslugaStavkaID), @"RezervacijaStavkaUslugaStavkaID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaUslugaProtokolID), @"RezervacijaStavkaUslugaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaUslugaRedniBroj), @"RezervacijaStavkaUslugaRedniBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaUslugaUslugaStavke), @"RezervacijaStavkaUslugaUslugaStavke", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(RezervacijaStavkaUslugaKolicina), @"RezervacijaStavkaUslugaKolicina", DbType.Int32, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<RezervacijaStavkaUsluga>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Rezervacija), nameof(RezervacijaStavkaUslugaProtokolID), nameof(Orko.Base.Protokol.ProtokolID)),
                new RelationMetadata(nameof(RezervacijaStavka), nameof(RezervacijaStavkaUslugaStavkaID), nameof(Orko.Watersports.RezervacijaStavka.RezervacijaStavkaID)),
                new RelationMetadata(nameof(UslugaStavke), nameof(RezervacijaStavkaUslugaUslugaStavke), nameof(Orko.Watersports.UslugaStavke.UslugaStavkeUslugaStavke))
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
		public Base.Protokol Rezervacija
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_Rezervacija, this, nameof(Rezervacija)); }
            set { EntityContext<Base.Protokol>.Set(ref m_Rezervacija, this, value, nameof(Rezervacija)); }
        }
        public RezervacijaStavka RezervacijaStavka
        {
            get { return EntityContext<RezervacijaStavka>.Get(ref m_RezervacijaStavka, this, nameof(RezervacijaStavka)); }
            set { EntityContext<RezervacijaStavka>.Set(ref m_RezervacijaStavka, this, value, nameof(RezervacijaStavka)); }
        }
        public UslugaStavke UslugaStavke
        {
            get { return EntityContext<UslugaStavke>.Get(ref m_UslugaStavke, this, nameof(UslugaStavke)); }
            set { EntityContext<UslugaStavke>.Set(ref m_UslugaStavke, this, value, nameof(UslugaStavke)); }
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
    }
}
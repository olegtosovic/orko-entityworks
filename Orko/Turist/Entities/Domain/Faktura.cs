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

namespace Orko.Turist
{
    /// <summary>
    /// Faktura entity.
    /// </summary>
    public sealed partial class Faktura : Entity
    {
		#region Members
		private Base.Firma m_FK_Faktura_Firma;
        private Gost m_FK_Faktura_Gost;
        private Obveznik m_FK_Faktura_Obveznik;
        private Base.Protokol m_FK_Faktura_Protokol;
        private Base.TecajnaLista m_FK_Faktura_TecajnaLista;
        private Base.Valuta m_FK_Faktura_ValutaDevizna;
        private Base.Valuta m_FK_Faktura_ValutaOsnovna;
        #endregion
        
		#region Constructors
        static Faktura()
        {
            // Cache field metadata.
            EntityMeta<Faktura>.LoadColumnMetadata
			(
				new ColumnMetadata("FakturaProtokolID", @"FakturaProtokolID", SqlDbType.Int, isPrimaryKey: true),
                new ColumnMetadata("FakturaTecajnaListaID", @"FakturaTecajnaListaID", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("FakturaRezervacijeOd", @"FakturaRezervacijeOd", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("FakturaRezervacijeDo", @"FakturaRezervacijeDo", SqlDbType.DateTime2, isRequired: false),
                new ColumnMetadata("FakturaObveznik", @"FakturaObveznik", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("FakturaGost", @"FakturaGost", SqlDbType.Int, isRequired: false),
                new ColumnMetadata("FakturaFirma", @"FakturaFirma", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("FakturaBroj", @"FakturaBroj", SqlDbType.Int, isRequired: true),
                new ColumnMetadata("FakturaValutaOsnovna", @"FakturaValutaOsnovna", SqlDbType.Char, isRequired: true),
                new ColumnMetadata("FakturaValutaDevizna", @"FakturaValutaDevizna", SqlDbType.Char, isRequired: false),
                new ColumnMetadata("FakturaIznosBezPopusta", @"FakturaIznosBezPopusta", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaPopustPostotak", @"FakturaPopustPostotak", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaPopustIznos", @"FakturaPopustIznos", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaUkupniIznos", @"FakturaUkupniIznos", SqlDbType.Decimal, isRequired: true),
                new ColumnMetadata("FakturaUkupniIznosDevize", @"FakturaUkupniIznosDevize", SqlDbType.Decimal, isRequired: false),
                new ColumnMetadata("FakturaUradio", @"FakturaUradio", SqlDbType.NVarChar, isRequired: true),
                new ColumnMetadata("FakturaDatumIzmjene", @"FakturaDatumIzmjene", SqlDbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Faktura>.LoadRelationMetadata
			(
				new RelationMetadata("FK_Faktura_Firma", "FakturaFirma", "FirmaFirma"),
                new RelationMetadata("FK_Faktura_Gost", "FakturaGost", "GostGost"),
                new RelationMetadata("FK_Faktura_Obveznik", "FakturaObveznik", "ObveznikObveznik"),
                new RelationMetadata("FK_Faktura_Protokol", "FakturaProtokolID", "ProtokolID"),
                new RelationMetadata("FK_Faktura_TecajnaLista", "FakturaTecajnaListaID", "TecajnaListaID"),
                new RelationMetadata("FK_Faktura_ValutaDevizna", "FakturaValutaDevizna", "ValutaValuta"),
                new RelationMetadata("FK_Faktura_ValutaOsnovna", "FakturaValutaOsnovna", "ValutaValuta")
			);

			// Cache table metadata.
			EntityMeta<Faktura>.HasLanguageTable = false;
            EntityMeta<Faktura>.TableSchema = @"Turist";
            EntityMeta<Faktura>.TableName = @"Faktura";
            EntityMeta<Faktura>.LanguageTableSchema = null;
            EntityMeta<Faktura>.LanguageTableName = null;
        }
        #endregion

        #region Columns
        public int? FakturaProtokolID { get; set; }
        public int? FakturaTecajnaListaID { get; set; }
        public DateTime? FakturaRezervacijeOd { get; set; }
        public DateTime? FakturaRezervacijeDo { get; set; }
        public int? FakturaObveznik { get; set; }
        public int? FakturaGost { get; set; }
        public string FakturaFirma { get; set; }
        public int? FakturaBroj { get; set; }
        public string FakturaValutaOsnovna { get; set; }
        public string FakturaValutaDevizna { get; set; }
        public decimal? FakturaIznosBezPopusta { get; set; }
        public decimal? FakturaPopustPostotak { get; set; }
        public decimal? FakturaPopustIznos { get; set; }
        public decimal? FakturaUkupniIznos { get; set; }
        public decimal? FakturaUkupniIznosDevize { get; set; }
        public string FakturaUradio { get; set; }
        public DateTime? FakturaDatumIzmjene { get; set; }
        #endregion

        #region Entities
		public Base.Firma FK_Faktura_Firma
        {
            get { return EntityContext<Base.Firma>.Get(ref m_FK_Faktura_Firma, this, "FK_Faktura_Firma"); }
            set { EntityContext<Base.Firma>.Set(ref m_FK_Faktura_Firma, this, value, "FK_Faktura_Firma"); }
        }
        public Gost FK_Faktura_Gost
        {
            get { return EntityContext<Gost>.Get(ref m_FK_Faktura_Gost, this, "FK_Faktura_Gost"); }
            set { EntityContext<Gost>.Set(ref m_FK_Faktura_Gost, this, value, "FK_Faktura_Gost"); }
        }
        public Obveznik FK_Faktura_Obveznik
        {
            get { return EntityContext<Obveznik>.Get(ref m_FK_Faktura_Obveznik, this, "FK_Faktura_Obveznik"); }
            set { EntityContext<Obveznik>.Set(ref m_FK_Faktura_Obveznik, this, value, "FK_Faktura_Obveznik"); }
        }
        public Base.Protokol FK_Faktura_Protokol
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_FK_Faktura_Protokol, this, "FK_Faktura_Protokol"); }
            set { EntityContext<Base.Protokol>.Set(ref m_FK_Faktura_Protokol, this, value, "FK_Faktura_Protokol"); }
        }
        public Base.TecajnaLista FK_Faktura_TecajnaLista
        {
            get { return EntityContext<Base.TecajnaLista>.Get(ref m_FK_Faktura_TecajnaLista, this, "FK_Faktura_TecajnaLista"); }
            set { EntityContext<Base.TecajnaLista>.Set(ref m_FK_Faktura_TecajnaLista, this, value, "FK_Faktura_TecajnaLista"); }
        }
        public Base.Valuta FK_Faktura_ValutaDevizna
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_FK_Faktura_ValutaDevizna, this, "FK_Faktura_ValutaDevizna"); }
            set { EntityContext<Base.Valuta>.Set(ref m_FK_Faktura_ValutaDevizna, this, value, "FK_Faktura_ValutaDevizna"); }
        }
        public Base.Valuta FK_Faktura_ValutaOsnovna
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_FK_Faktura_ValutaOsnovna, this, "FK_Faktura_ValutaOsnovna"); }
            set { EntityContext<Base.Valuta>.Set(ref m_FK_Faktura_ValutaOsnovna, this, value, "FK_Faktura_ValutaOsnovna"); }
        }
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Faktura>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Faktura>(queryConditions);
        }
        public static async Task<IEnumerable<Faktura>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Faktura>(columnName, queryOp, value);
        }
		public static async Task<Faktura> GetByPrimaryKeyAsync(int FakturaProtokolID)
        {
            return await GetByPrimaryKeyAsync<Faktura>(FakturaProtokolID);
        }
		public static async Task<Faktura> TryGetByPrimaryKeyAsync(int FakturaProtokolID)
        {
            return await TryGetByPrimaryKeyAsync<Faktura>(FakturaProtokolID);
        }
		#endregion

        #region Public methods
		public static IEnumerable<Faktura> GetByAny(params QueryCondition[] queryConditions)
        {
            return GetByAny<Faktura>(queryConditions);
        }
        public static IEnumerable<Faktura> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            return GetByAny<Faktura>(columnName, queryOp, value);
        }
		public static Faktura GetByPrimaryKey(int FakturaProtokolID)
        {
            return GetByPrimaryKey<Faktura>(FakturaProtokolID);
        }
		public static Faktura TryGetByPrimaryKey(int FakturaProtokolID)
        {
            return TryGetByPrimaryKey<Faktura>(FakturaProtokolID);
        }
        public static Faktura GetByUnique1(int FakturaObveznik, int FakturaBroj)
        {
            return GetByCallingParameters<Faktura>(FakturaObveznik, FakturaBroj);
        }
		public static Faktura TryGetByUnique1(int FakturaObveznik, int FakturaBroj)
        {
            return TryGetByCallingParameters<Faktura>(FakturaObveznik, FakturaBroj);
        }
        #endregion
    }
}
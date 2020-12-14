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

namespace Orko.Turist
{
    /// <summary>
    /// Faktura entity.
    /// </summary>
    public sealed partial class Faktura : Entity
    {
		#region Members
		private Base.Firma m_Firma;
        private Gost m_Gost;
        private Obveznik m_Obveznik;
        private Base.Protokol m_Protokol;
        private Base.TecajnaLista m_TecajnaLista;
        private Base.Valuta m_ValutaDevizna;
        private Base.Valuta m_ValutaOsnovna;
        #endregion
        
		#region Constructors
        static Faktura()
        {
            // Cache field metadata.
            EntityMeta<Faktura>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(FakturaProtokolID), @"FakturaProtokolID", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(FakturaTecajnaListaID), @"FakturaTecajnaListaID", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(FakturaRezervacijeOd), @"FakturaRezervacijeOd", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(FakturaRezervacijeDo), @"FakturaRezervacijeDo", DbType.DateTime2, isRequired: false),
                new ColumnMetadata(nameof(FakturaObveznik), @"FakturaObveznik", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(FakturaGost), @"FakturaGost", DbType.Int32, isRequired: false),
                new ColumnMetadata(nameof(FakturaFirma), @"FakturaFirma", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(FakturaBroj), @"FakturaBroj", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(FakturaValutaOsnovna), @"FakturaValutaOsnovna", DbType.AnsiStringFixedLength, isRequired: true),
                new ColumnMetadata(nameof(FakturaValutaDevizna), @"FakturaValutaDevizna", DbType.AnsiStringFixedLength, isRequired: false),
                new ColumnMetadata(nameof(FakturaIznosBezPopusta), @"FakturaIznosBezPopusta", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaPopustPostotak), @"FakturaPopustPostotak", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaPopustIznos), @"FakturaPopustIznos", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaUkupniIznos), @"FakturaUkupniIznos", DbType.Decimal, isRequired: true),
                new ColumnMetadata(nameof(FakturaUkupniIznosDevize), @"FakturaUkupniIznosDevize", DbType.Decimal, isRequired: false),
                new ColumnMetadata(nameof(FakturaUradio), @"FakturaUradio", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(FakturaDatumIzmjene), @"FakturaDatumIzmjene", DbType.DateTime2, isRequired: true)
			);

            // Cache entites metadata.
            EntityMeta<Faktura>.LoadRelationMetadata
			(
				new RelationMetadata(nameof(Firma), nameof(FakturaFirma), nameof(Orko.Base.Firma.FirmaFirma)),
                new RelationMetadata(nameof(Gost), nameof(FakturaGost), nameof(Orko.Turist.Gost.GostGost)),
                new RelationMetadata(nameof(Obveznik), nameof(FakturaObveznik), nameof(Orko.Turist.Obveznik.ObveznikObveznik)),
                new RelationMetadata(nameof(Protokol), nameof(FakturaProtokolID), nameof(Orko.Base.Protokol.ProtokolID)),
                new RelationMetadata(nameof(TecajnaLista), nameof(FakturaTecajnaListaID), nameof(Orko.Base.TecajnaLista.TecajnaListaID)),
                new RelationMetadata(nameof(ValutaDevizna), nameof(FakturaValutaDevizna), nameof(Orko.Base.Valuta.ValutaValuta)),
                new RelationMetadata(nameof(ValutaOsnovna), nameof(FakturaValutaOsnovna), nameof(Orko.Base.Valuta.ValutaValuta))
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
		public Base.Firma Firma
        {
            get { return EntityContext<Base.Firma>.Get(ref m_Firma, this, nameof(Firma)); }
            set { EntityContext<Base.Firma>.Set(ref m_Firma, this, value, nameof(Firma)); }
        }
        public Gost Gost
        {
            get { return EntityContext<Gost>.Get(ref m_Gost, this, nameof(Gost)); }
            set { EntityContext<Gost>.Set(ref m_Gost, this, value, nameof(Gost)); }
        }
        public Obveznik Obveznik
        {
            get { return EntityContext<Obveznik>.Get(ref m_Obveznik, this, nameof(Obveznik)); }
            set { EntityContext<Obveznik>.Set(ref m_Obveznik, this, value, nameof(Obveznik)); }
        }
        public Base.Protokol Protokol
        {
            get { return EntityContext<Base.Protokol>.Get(ref m_Protokol, this, nameof(Protokol)); }
            set { EntityContext<Base.Protokol>.Set(ref m_Protokol, this, value, nameof(Protokol)); }
        }
        public Base.TecajnaLista TecajnaLista
        {
            get { return EntityContext<Base.TecajnaLista>.Get(ref m_TecajnaLista, this, nameof(TecajnaLista)); }
            set { EntityContext<Base.TecajnaLista>.Set(ref m_TecajnaLista, this, value, nameof(TecajnaLista)); }
        }
        public Base.Valuta ValutaDevizna
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_ValutaDevizna, this, nameof(ValutaDevizna)); }
            set { EntityContext<Base.Valuta>.Set(ref m_ValutaDevizna, this, value, nameof(ValutaDevizna)); }
        }
        public Base.Valuta ValutaOsnovna
        {
            get { return EntityContext<Base.Valuta>.Get(ref m_ValutaOsnovna, this, nameof(ValutaOsnovna)); }
            set { EntityContext<Base.Valuta>.Set(ref m_ValutaOsnovna, this, value, nameof(ValutaOsnovna)); }
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
    }
}
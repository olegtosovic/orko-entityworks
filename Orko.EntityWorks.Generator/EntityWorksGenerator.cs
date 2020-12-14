using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Orko.EntityWorks.Generator.AspNetCore")]
namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Orko entityworks code generator.
	/// Provides support to generate code files for entities, views and stored procedures.
	/// </summary>
	public class EntityWorksGenerator
    {
        #region Path constants
        private const string PATH_ENTITIES_DOMAIN = "Entities/Domain";
        private const string PATH_ENTITIES_LOGIC  = "Entities/Logic";
        private const string PATH_ENTITIES_STATIC = "Entities/Static";
        private const string PATH_PROCEDURES = "Procedures";
        private const string PATH_VIEWS = "Views";
        #endregion

        #region String constants
        private const string STR_TAB = "        ";
        private string STR_NEWLINE = Environment.NewLine;
        #endregion

        #region Members
        private Assembly m_execAssembly;
        private string m_execAssemblyName;
        #endregion

        #region Methods
        /// <summary>
        /// Sets assembly information.
        /// </summary>
        private void SetAssemblies()
		{
            // Assign members.
            m_execAssembly = Assembly.GetExecutingAssembly();
            m_execAssemblyName = m_execAssembly.GetName().Name;
        }
        /// <summary>
        /// Generates domain entity classes.
        /// </summary>
        private void GenerateDomainClasses(Database database)
        {
            // Get options.
            var options = database.Options;

            // If database not prepared.
            if (database.IsReady == false)
                database.Prepare();

            // Get tables.
            IEnumerable<Table> tables = database.Tables.Values;

            // If using language tables we do not generate language table class files.
            if (options.UseLanguageTables)
                tables = tables.Where(x => x.IsLanguageTable == false);

            // For each table create .cs entity class
            foreach (var table in tables)
            {
                // Open domain class template
                string domainTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "Domain.txt", true);

                // Get tags data.
                string nameSpace = GetNamespace(table);
                string className = table.NetName;
                string typeParameterList = GetTypeParameterList(table);
                string valueParameterList = GetValueParameterList(table);
                string fieldMetadata = GetFieldsMetadata(table);
                string relationMetadata = GetRelationsMetadata(table);
                string tableMetadata = GetTableMetadata(table);
                string fieldList = GetFieldList(table);
                string memberList = GetMemberList(table);
                string entityList = GetEntityList(table);
                string uniqueMethods = GetUniqueMethodList(table);
                string date = GetCurrentDate();
                string time = GetCurrentTime();

                // Replace tags with actual data.
                domainTemplate = domainTemplate.Replace("[NAMESPACE]", nameSpace);
                domainTemplate = domainTemplate.Replace("[DATE]", date);
                domainTemplate = domainTemplate.Replace("[TIME]", time);
                domainTemplate = domainTemplate.Replace("[CLASS_NAME]", className);
                domainTemplate = domainTemplate.Replace("[TYPE_PK_N]", typeParameterList);
                domainTemplate = domainTemplate.Replace("[VAR_PK_N]", valueParameterList);
                domainTemplate = domainTemplate.Replace("[FIELD_METADATA]", fieldMetadata);
                domainTemplate = domainTemplate.Replace("[RELATION_METADATA]", relationMetadata);
                domainTemplate = domainTemplate.Replace("[TABLE_METADATA]", tableMetadata);
                domainTemplate = domainTemplate.Replace("[FIELD_LIST]", fieldList);
                domainTemplate = domainTemplate.Replace("[MEMBER_LIST]", memberList);
                domainTemplate = domainTemplate.Replace("[ENTITY_LIST]", entityList);
                domainTemplate = domainTemplate.Replace("[UNIQUE_METHOD]", uniqueMethods);

                // Generate class document.
                WriteTextTemplate(table, domainTemplate, PATH_ENTITIES_DOMAIN);
            }
        }
        /// <summary>
        /// Generates logic entity classes.
        /// </summary>
        private void GenerateLogicClasses(Database database)
        {
            // Get options.
            var options = database.Options;

            // If database not prepared.
            if (database.IsReady == false)
                database.Prepare();

            // Get tables.
            IEnumerable<Table> tables = database.Tables.Values;

            // If using language tables we do not generate language table class files.
            if (options.UseLanguageTables)
                tables = tables.Where(x => x.IsLanguageTable == false);

            // For each table create .cs logic class
            foreach (Table table in tables)
            {
                // Open logic class template
                string logicTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_LOGIC), "Logic.txt", true);

                // Get tags data.
                string nameSpace = GetNamespace(table);

                string className = table.NetName;
                string typeParameterList = GetTypeParameterList(table);
                string valueParameterList = GetValueParameterList(table);
                string date = GetCurrentDate();
                string time = GetCurrentTime();

                // Replace tags with actual data.
                logicTemplate = logicTemplate.Replace("[NAMESPACE]", nameSpace);
                logicTemplate = logicTemplate.Replace("[DATE]", date);
                logicTemplate = logicTemplate.Replace("[TIME]", time);
                logicTemplate = logicTemplate.Replace("[CLASS_NAME]", className);
                logicTemplate = logicTemplate.Replace("[TYPE_PK_N]", typeParameterList);
                logicTemplate = logicTemplate.Replace("[VAR_PK_N]", valueParameterList);

                // Generate class document.
                WriteTextTemplate(table, logicTemplate, PATH_ENTITIES_LOGIC);
            }
        }
        /// <summary>
        /// Generates static entity classes.
        /// </summary>
        private void GenerateStaticClasses(Database database)
		{
            // Get options.
            var options = database.Options;

            // If database not prepared.
            if (database.IsReady == false)
                database.Prepare();

            // Get tables.
            IEnumerable<Table> tables = database.Tables.Values;

            // If using language tables we do not generate language table class files.
            if (options.UseLanguageTables)
                tables = tables.Where(x => x.IsLanguageTable == false);

            // For each table create .cs logic class
            foreach (var table in tables)
            {
                // Open logic class template
                string staticTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_STATIC), "Static.txt");

                // Get tags data.
                string staticList = GetStaticList(table);
                string nameSpace = GetNamespace(table);
                string tableSchema = table.Schema;
                string className = table.NetName;
                string date = GetCurrentDate();
                string time = GetCurrentTime();

                // Replace tags with actual data.
                staticTemplate = staticTemplate.Replace("[TS]", tableSchema);
                staticTemplate = staticTemplate.Replace("[NAMESPACE]", nameSpace);
                staticTemplate = staticTemplate.Replace("[STATIC_LIST]", staticList);
                staticTemplate = staticTemplate.Replace("[DATE]", date);
                staticTemplate = staticTemplate.Replace("[TIME]", time);
                staticTemplate = staticTemplate.Replace("[CLASS_NAME]", className);

                // Generate class document.
                WriteTextTemplate(table, staticTemplate, PATH_ENTITIES_STATIC);
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates instance of entity works generator.
        /// </summary>
        public EntityWorksGenerator()
        {
            // Create database collecion instance.
            this.Databases = new List<Database>();

            // Default directives.
            this.GenerateAsyncMethodsOnly = true;

            // Set assemblies.
            SetAssemblies();
        }
        /// <summary>
        /// Creates instance of entity works generator.
        /// </summary>
        /// <param name="database">Database object</param>
        public EntityWorksGenerator(Database database) : this()
        {
            // Add database.
            AddDatabase(database);
        }
        /// <summary>
        /// Creates instance of entity works generator.
        /// </summary>
        /// <param name="databases">Database collection</param>
        public EntityWorksGenerator(IEnumerable<Database> databases) : this()
        {
            // Add databases.
            foreach (var database in databases)
                AddDatabase(database);
        }
        /// <summary>
        /// Creates instance of entity works generator. 
        /// </summary>
        /// <param name="database">Database object</param>
        /// <param name="options">Entity works generator global options</param>
        public EntityWorksGenerator(Database database, EntityGeneratorOptions options) : this(database)
        {
            // Set target directory.
            SetEntityWorksGeneratorOptions(options);
        }
        /// <summary>
        /// Creates instance of entity works generator.
        /// </summary>
        /// <param name="databases">Database collection</param>
        /// <param name="options">Entity works generator global options</param>
        public EntityWorksGenerator(IEnumerable<Database> databases, EntityGeneratorOptions options) : this(databases)
        {
            // Set target directory.
            SetEntityWorksGeneratorOptions(options);
        }
        #endregion

        #region Properties
        /// <summary>
        /// If true, generator will generate only async CRUD methods.
        /// </summary>
        public bool GenerateAsyncMethodsOnly { get; set; }
        /// <summary>
        /// Collection of databases to generate entity classes.
        /// </summary>
        public List<Database> Databases { get; set; }
        /// <summary>
        /// Entity generator options.
        /// </summary>
        public EntityGeneratorOptions Options { get; private set; }
        #endregion

        #region Main method
        /// <summary>
        /// Generates domain and logic entity classes.
        /// </summary>
        public async Task GenerateAllAsync()
		{
            // Generate each database.
            foreach (var database in this.Databases)
            {
                // Generate all async.
                await Task.Run(() =>
                {
                    GenerateDomainClasses(database);
                    GenerateLogicClasses(database);
                    GenerateStaticClasses(database);
                });
            };
        }        
		#endregion

		#region Assignment methods
        /// <summary>
        /// Sets global entity works generator options.
        /// </summary>
        public void SetEntityWorksGeneratorOptions(EntityGeneratorOptions options)
		{
            // Validation options instance.
            if (options == null)
                throw new ArgumentNullException(nameof(options), "EntityWorksGeneratorOptions can not be null.");

            // Set options.
            this.Options = options;
		}
        /// <summary>
        /// Add database to generator queue.
        /// </summary>
        public void AddDatabase(Database database)
		{
            // Validate.
            if (database == null)
                throw new ArgumentNullException(nameof(database), "Database object can not be null.");

            // Validate duplicate database.
            if (this.Databases.Where(x => x.ConnectionString == database.ConnectionString).Any())
                throw new EntityWorksGeneratorException(string.Format("Unable to add database model. " +
                    "Database model with identical connection string already exists. Connection string: '{0}'. " +
                    "Please check your entity works generator configuration.", database.ConnectionString));

            // Set database.
            Databases.Add(database);
        }
        #endregion

        #region Template substitution methods

        #region Domain generation methods
        private string GetNamespace(Table table)
        {
            // Root namespace segment.
            var rootNamespace = table.Database.DatabaseName;

            // Full namespace.
            var fullNamespace = string.Join(".", rootNamespace, table.Schema.ToUpperCamelCase());

            // Return namepsace.
            return fullNamespace;
        }
        private string GetFieldsMetadata(Table table)
        {
            // Database generator options.
            var options = table.Database.Options;

            // Field metadata container.
            string fieldMetadataList = string.Empty;

            // Add each table column to list.
            foreach (Column column in table.Columns.Values.OrderBy(x => x.OrdinalPosition))
            {
                // Open field metadata section template.
                string fieldMetadataTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "FieldMetadataList.txt");

                // Get tags data.
                string memberName = column.NetName;
                string sqlFieldName = column.SqlName;
                string fieldMetadataArguments = GetFieldMetadataArguments(column);

                // Replace tags with actual data.
                fieldMetadataTemplate = fieldMetadataTemplate.Replace("[COLUMN_NAME]", memberName);
                fieldMetadataTemplate = fieldMetadataTemplate.Replace("[SQL_COLUMN_NAME]", sqlFieldName);
                fieldMetadataTemplate = fieldMetadataTemplate.Replace("[FIELD_METADATA_ARGS]", fieldMetadataArguments);

                // Add to field metadata list.
                fieldMetadataList += fieldMetadataTemplate + "," + STR_NEWLINE + STR_TAB + STR_TAB;
            }

            // Add each language table column to list.
            if (options.UseLanguageTables && table.HasLanguageTable)
            {
                foreach (Column column in table.LanguageTable.Columns.Values
                    .Where(x => x.IsLanguage || x.IsLanguageCode)
                    .OrderBy(x => x.OrdinalPosition))
                {
                    // Open field metadata section template.
                    string fieldMetadataTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "FieldMetadataList.txt");

                    // Get tags data.
                    string memberName = column.NetName;
                    string sqlFieldName = column.SqlName;
                    string fieldMetadataArguments = GetFieldMetadataArguments(column);

                    // Replace tags with actual data.
                    fieldMetadataTemplate = fieldMetadataTemplate.Replace("[COLUMN_NAME]", memberName);
                    fieldMetadataTemplate = fieldMetadataTemplate.Replace("[SQL_COLUMN_NAME]", sqlFieldName);
                    fieldMetadataTemplate = fieldMetadataTemplate.Replace("[FIELD_METADATA_ARGS]", fieldMetadataArguments);

                    // Add to field metadata list.
                    fieldMetadataList += fieldMetadataTemplate + "," + STR_NEWLINE + STR_TAB + STR_TAB;
                }
            }
            return fieldMetadataList.TrimEnd(STR_TAB.ToCharArray()).TrimEnd(STR_NEWLINE.ToCharArray()).TrimEnd(",".ToCharArray());
        }
        private string GetRelationsMetadata(Table table)
        {
            // Relation metadata container.
            string relationMetadataList = "null";
            if (table.ForeignKeys.Values.Any())
                relationMetadataList = string.Empty;

            foreach (ForeignKey foreignKey in table.ForeignKeys.Values.OrderBy(x => x.NetName))
            {
                foreach (Relation relation in foreignKey.Relations.OrderBy(x => x.ForeignKeyTableName))
                {
                    // Open field metadata section template.
                    string relationMetadataTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "RelationMetadataList.txt");

                    // Get tags data.
                    string fkTable = foreignKey.NetName;
                    string fkField = relation.ForeignKeyTableColumnName;
                    string pkField = 
                        foreignKey.Database.DatabaseName + "." + 
                        relation.PrimaryKeyTableFullName.ToUpperCamelCase() + "." + 
                        relation.PrimaryKeyTableColumnName;

                    // Replace tags with actual data.
                    relationMetadataTemplate = relationMetadataTemplate.Replace("[FK_TABLE]", fkTable);
                    relationMetadataTemplate = relationMetadataTemplate.Replace("[FK_FIELD]", fkField);
                    relationMetadataTemplate = relationMetadataTemplate.Replace("[PK_FIELD]", pkField);

                    // Add to field metadata list.
                    relationMetadataList += relationMetadataTemplate + "," + STR_NEWLINE + STR_TAB + STR_TAB;
                }
            }
            return relationMetadataList.TrimEnd(STR_TAB.ToCharArray()).TrimEnd(STR_NEWLINE.ToCharArray()).TrimEnd(",".ToCharArray());
        }
        private string GetTableMetadata(Table table)
        {
            // Table metadata container.
            string tableMetadataList = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "TableMetadata.txt");

            // Get tags data.
            string hasLanguageTable = table.LanguageTable != null ? "true" : "false";
            string tableSchema = table.Schema;
            string tableName = table.SqlName;
            string className = table.NetName;
            string languageTableSchema = table.LanguageTable != null ? "@\"" + table.LanguageTable.Schema + "\"" : "null";
            string languageTableName = table.LanguageTable != null ? "@\"" + table.LanguageTable.SqlName + "\"" : "null";

            // Replace tags with actual data.
            tableMetadataList = tableMetadataList.Replace("[HLT]", hasLanguageTable);
            tableMetadataList = tableMetadataList.Replace("[TS]", tableSchema);
            tableMetadataList = tableMetadataList.Replace("[TN]", tableName);
            tableMetadataList = tableMetadataList.Replace("[LTS]", languageTableSchema);
            tableMetadataList = tableMetadataList.Replace("[LTN]", languageTableName);
            tableMetadataList = tableMetadataList.Replace("[TABLE_NAME]", className);

            // Return table metadata.
            return tableMetadataList;
        }
        private string GetFieldList(Table table)
        {
            // Database generator options.
            var options = table.Database.Options;

            // Field list container.
            string fieldList = string.Empty;

            // For each table column generate entity field.
            foreach (Column column in table.Columns.Values.OrderBy(x => x.OrdinalPosition))
            {
                // Open field list section template
                string propertyTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "FieldList.txt");

                // Get tags data.
                string access = GetAccess(column);
                string clrType = GetClrType(column);
                string columnName = column.NetName;
                string set = GetSet(column);

                // Replate tags with actual data.
                propertyTemplate = propertyTemplate.Replace("[ACCESS]", access);
                propertyTemplate = propertyTemplate.Replace("[CLR_TYPE]", clrType);
                propertyTemplate = propertyTemplate.Replace("[COLUMN_NAME]", columnName);
                propertyTemplate = propertyTemplate.Replace("[SET]", set);

                // Add to property list
                fieldList += propertyTemplate + STR_NEWLINE + STR_TAB;
            }

            // If using language tables.
            if (options.UseLanguageTables && table.HasLanguageTable)
            {
                // For each language table column generate entity field.
                foreach (Column column in table.LanguageTable.Columns.Values
                    .Where(x => x.IsLanguage || x.IsLanguageCode)
                    .OrderBy(x => x.OrdinalPosition))
                {
                    // Open field list section template
                    string propertyTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "FieldList.txt");

                    // Get tags data.
                    string access = GetAccess(column);
                    string clrType = GetClrType(column);
                    string columnName = column.SqlName;
                    string set = GetSet(column);

                    // Replate tags with actual data.
                    propertyTemplate = propertyTemplate.Replace("[ACCESS]", access);
                    propertyTemplate = propertyTemplate.Replace("[CLR_TYPE]", clrType);
                    propertyTemplate = propertyTemplate.Replace("[COLUMN_NAME]", columnName);
                    propertyTemplate = propertyTemplate.Replace("[SET]", set);

                    // Add to property list
                    fieldList += propertyTemplate + STR_NEWLINE + STR_TAB;
                }
            }

            return fieldList.TrimEnd(STR_TAB.ToCharArray()).TrimEnd(STR_NEWLINE.ToCharArray());
        }
        private string GetMemberList(Table table)
        {
            // Member list container.
            string memberList = string.Empty;

            // For each foreign table key generate member property.
            foreach (ForeignKey foreignKey in table.ForeignKeys.Values.OrderBy(x => x.NetName))
            {
                // Open member list section template.
                string memberTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "MemberList.txt");

                // Get tags data.
                string fkClassName = GetForeignKeyClassName(foreignKey);
                string fkColumnName = GetForeignKeyMemberColumnName(foreignKey);

                // Replate tags with actual data.
                memberTemplate = memberTemplate.Replace("[FK_KEY_NAME]", fkColumnName);
                memberTemplate = memberTemplate.Replace("[FK_CLASS_NAME]", fkClassName);

                // Add to member list.
                memberList += memberTemplate + STR_NEWLINE + STR_TAB;
            }
            return memberList.TrimEnd(STR_TAB.ToCharArray()).TrimEnd(STR_NEWLINE.ToCharArray());
        }
        private string GetEntityList(Table table)
        {
            // Entity list container.
            string nodeList = string.Empty;

            // For each foreign table key generate entity property.
            foreach (ForeignKey foreignKey in table.ForeignKeys.Values.OrderBy(x => x.NetName))
            {
                // Open node entity section template.
                string nodeTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "EntityList.txt");

                // Get tags data.
                string fkClassName = GetForeignKeyClassName(foreignKey);
                string fkColumnName = GetForeignKeyColumnName(foreignKey);
                string fkGetAccessor = GetGetAccessor(foreignKey);
                string fkSetAccessor = GetSetAccessor(foreignKey);

                // Replate tags with actual data.
                nodeTemplate = nodeTemplate.Replace("[FK_KEY_NAME]", fkColumnName);
                nodeTemplate = nodeTemplate.Replace("[FK_CLASS_NAME]", fkClassName);
                nodeTemplate = nodeTemplate.Replace("[GET]", fkGetAccessor);
                nodeTemplate = nodeTemplate.Replace("[SET]", fkSetAccessor);

                // Add to lazy list.
                nodeList += nodeTemplate + STR_NEWLINE + STR_TAB;
            }
            return nodeList.TrimEnd(STR_TAB.ToCharArray()).TrimEnd(STR_NEWLINE.ToCharArray());
        }
        private string GetUniqueMethodList(Table table)
        {
            // Unique methods container.
            string uniqueList = string.Empty;

            // Counter.
            int counter = 0;

            // For each table unique key generate unique method.
            foreach (UniqueKey uniqueKey in table.UniqueKeys.Values)
            {
                // Increase counter.
                counter++;

                // Open field list section template
                string uniqueTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_DOMAIN), "UniqueMethodList.txt");

                // Get tags data.
                string className = table.NetName;
                string typeParameterList = GetTypeParameterList(uniqueKey);
                string valueParameterList = GetValueParameterList(uniqueKey);
                string index = counter.ToString();

                // Replate tags with actual data.
                uniqueTemplate = uniqueTemplate.Replace("[CLASS_NAME]", className);
                uniqueTemplate = uniqueTemplate.Replace("[UNIQUE_INDEX]", index);
                uniqueTemplate = uniqueTemplate.Replace("[TYPE_PK_N]", typeParameterList);
                uniqueTemplate = uniqueTemplate.Replace("[VAR_PK_N]", valueParameterList);

                // Add to unique list
                if (counter == 1)
                    uniqueList += STR_NEWLINE + STR_TAB + uniqueTemplate + STR_NEWLINE + STR_TAB;
                else uniqueList += uniqueTemplate + STR_NEWLINE + STR_TAB;
            }
            return uniqueList.TrimEnd(STR_TAB.ToCharArray()).TrimEnd(STR_NEWLINE.ToCharArray());
        }
        private string GetCurrentDate()
        {
            return DateTime.Now.Date.ToShortDateString();
        }
        private string GetCurrentTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
        #endregion

        #region Property generation methods
        private string GetFieldMetadataArguments(Column column)
        {
            List<string> fieldArgumentList = new List<string>();

            fieldArgumentList.Add("DbType." + column.DbType.ToString());

            if (column.IsIdentity)
                fieldArgumentList.Add("isIdentity: true");

            if (!column.IsNullable && !column.IsPartOfPrimaryKey)
                fieldArgumentList.Add("isRequired: true");
            else if (column.IsNullable && !column.IsPartOfPrimaryKey)
                fieldArgumentList.Add("isRequired: false");

            if (column.IsLanguageCode)
                fieldArgumentList.Add("isLanguageCode: true");

            if (column.IsLanguage && !column.IsLanguageCode)
                fieldArgumentList.Add("isLanguage: true");

            if (column.IsPartOfPrimaryKey)
                fieldArgumentList.Add("isPrimaryKey: true");

            string retVal = string.Empty;
            foreach (string fieldArgument in fieldArgumentList)
            {
                retVal += fieldArgument + ", ";
            }
            return retVal.TrimEnd(new char[] { ',', ' ' });
        }
        private string GetAccess(Column column)
        {
            return "public";
        }
        private string GetClrType(Column column)
        {
            return column.NetDataTypeName;
        }
        private string GetSet(Column column)
        {
            if (column.IsIdentity || column.IsLanguageCode)
            {
                return "private set;";
            }
            else return "set;";
        }
        #endregion

        #region Member generation methods
        private string GetForeignKeyColumnName(ForeignKey foreignKey)
        {
            return foreignKey.NetName;
        }
        private string GetForeignKeyClassName(ForeignKey foreignKey, bool enforceShema = false)
        {
            if (enforceShema == false)
            {
                if (foreignKey.Relations[0].PrimaryKeyTableSchema != foreignKey.Relations[0].ForeignKeyTableSchema)
                    return foreignKey.Relations[0].PrimaryKeyTableFullName.ToUpperCamelCase();
                else return foreignKey.Relations[0].PrimaryKeyTableName;
            }
            else
			{
                if (foreignKey.Relations[0].PrimaryKeyTableSchema != foreignKey.Relations[0].ForeignKeyTableSchema)
                    return foreignKey.Relations[0].PrimaryKeyTableFullName.ToUpperCamelCase();
                else return foreignKey.Relations[0].PrimaryKeyTableName;
            }
        }
        #endregion

        #region Entity generation methods        
        private string GetForeignKeyDeclaringClassName(ForeignKey foreignKey)
        {
            return foreignKey.Table.NetFullName;
        }
        private string GetForeignKeyMemberColumnName(ForeignKey foreignKey)
        {
            return "m_" + foreignKey.NetName;
        }
        private string GetGetAccessor(ForeignKey foreignKey)
        {
            string fkClassName = GetForeignKeyClassName(foreignKey);
            string fkColumnName = GetForeignKeyColumnName(foreignKey);
            string fkMemberColumnName = GetForeignKeyMemberColumnName(foreignKey);
            string fkDeclaringClassName = GetForeignKeyDeclaringClassName(foreignKey);

            string getTemplate = "get { return EntityContext<" + fkClassName + ">.Get(ref " + fkMemberColumnName + ", this, nameof(" + fkColumnName + ")); }";
            return getTemplate;
        }
        private string GetSetAccessor(ForeignKey foreignKey)
        {
            string fkClassName = GetForeignKeyClassName(foreignKey);
            string fkColumnName = GetForeignKeyColumnName(foreignKey);
            string fkMemberColumnName = GetForeignKeyMemberColumnName(foreignKey);
            string fkDeclaringClassName = GetForeignKeyDeclaringClassName(foreignKey);

            string setTemplate = "set { EntityContext<" + fkClassName + ">.Set(ref " + fkMemberColumnName + ", this, value, nameof(" + fkColumnName + ")); }";
            return setTemplate;
        }
		#endregion

		#region Relations generation methods
		#endregion

		#region Logic generation methods
		private string GetTypeParameterList(Table table)
        {
            string typeList = string.Empty;
            foreach (Column column in table.PrimaryKey.Columns.Values.OrderBy(x => x.OrdinalPosition))
            {
                typeList += column.NetDataArgumentTypeName + " " + column.NetName + ", ";
            }
            typeList = typeList.TrimEnd(new char[] { ',', ' ' });
            return typeList;
        }
        private string GetValueParameterList(Table table)
        {
            string valueList = string.Empty;
            foreach (Column column in table.PrimaryKey.Columns.Values.OrderBy(x => x.OrdinalPosition))
            {
                valueList += column.NetName + ", ";
            }
            valueList = valueList.TrimEnd(new char[] { ',', ' ' });
            return valueList;
        }
		#endregion

		#region Static generation methods
        private string GetStaticList(Table table)
		{
            // Database specific options if null than global options.
            var options = table.Database.Options;

            // Field metadata container.
            string staticColumnsList = string.Empty;

            // Add each table column to list.
            foreach (Column column in table.Columns.Values.OrderBy(x => x.OrdinalPosition))
            {
                // Open field metadata section template.
                string staticColumnsTemplate = ReadTextTemplate(ConvertFileToNamespacePath(PATH_ENTITIES_STATIC), "StaticList.txt");

                // Get tags data.
                string columnName = column.NetName;
                string sqlFieldName = column.SqlName;
                string hasLanguageTable = table.LanguageTable != null ? "true" : "false";
                string tableSchema = table.Schema;
                string tableName = table.SqlName;
                string languageTableSchema = table.LanguageTable != null ? "\"" + table.LanguageTable.Schema + "\"" : "null";
                string languageTableName = table.LanguageTable != null ? "\"" + table.LanguageTable.SqlName + "\"" : "null";

                // Replace tags with actual data.
                staticColumnsTemplate = staticColumnsTemplate.Replace("[TS]", tableSchema);
                staticColumnsTemplate = staticColumnsTemplate.Replace("[TN]", tableName);
                staticColumnsTemplate = staticColumnsTemplate.Replace("[LTS]", languageTableSchema);
                staticColumnsTemplate = staticColumnsTemplate.Replace("[LTN]", languageTableName);
                staticColumnsTemplate = staticColumnsTemplate.Replace("[TABLE_NAME]", tableName);
                staticColumnsTemplate = staticColumnsTemplate.Replace("[COLUMN_NAME]", columnName);
                staticColumnsTemplate = staticColumnsTemplate.Replace("[SQL_COLUMN_NAME]", sqlFieldName);


                // Add to field metadata list.
                staticColumnsList += staticColumnsTemplate + STR_NEWLINE + STR_TAB;
            }

            // Return static columns list.
            return staticColumnsList.TrimEnd(STR_TAB.ToCharArray()).TrimEnd(STR_NEWLINE.ToCharArray()).TrimEnd(",".ToCharArray());
        }
		#endregion

		#region Unique method methods
		private string GetTypeParameterList(UniqueKey uniqueKey)
        {
            string typeList = string.Empty;
            foreach (Column column in uniqueKey.Columns.Values)
            {
                typeList += column.NetDataArgumentTypeName + " " + column.SqlName + ", ";
            }
            typeList = typeList.TrimEnd(new char[] { ',', ' ' });
            return typeList;
        }
        private string GetValueParameterList(UniqueKey uniqueKey)
        {
            string valueList = string.Empty;
            foreach (Column column in uniqueKey.Columns.Values)
            {
                valueList += column.SqlName + ", ";
            }
            valueList = valueList.TrimEnd(new char[] { ',', ' ' });
            return valueList;
        }
        #endregion

        #endregion

        #region Template I/O methods
        /// <summary>
        /// Reads template from embeded resource.
        /// </summary>
        private string ReadTextTemplate(string documentGroup, string documentName, bool asyncTemplate = false)
        {
            // Replace file path with resource path.
            var namespaceDocumentGroup = documentGroup.Replace("/", ".");

            // Get resource name.
            string resourceName = m_execAssemblyName + ".Templates." + namespaceDocumentGroup + "." + documentName;

            // If generate async only option true, add "Async" to template name but 
            // only if async indicator is true, noting that such template should exist and make sanse.
            if (this.Options.GenerateOnlyAsyncTemplates && asyncTemplate)
                resourceName = resourceName.Replace(".txt", "Async.txt");

            // Get stream and read embeded resource template.
            using (Stream stream = m_execAssembly.GetManifestResourceStream(resourceName))
            {
                // Create new stream reader.
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    // Read and return template.
                    return streamReader.ReadToEnd();
                }
            }
        }
        /// <summary>
        /// Writes substituted template to disk.
        /// </summary>
        private void WriteTextTemplate(Table table, string template, string folder)
        {
            // Validate target directory.
            if (this.Options.OutputDirectory == null)
                throw new EntityWorksGeneratorException("Target directory can not be null. Please set target directory in entity works options.");

            // Directory path.
            var directoryPath = Path.Combine(this.Options.OutputDirectory.FullName, table.Database.DatabaseName, table.Schema, folder);
			
			// Class full name.
			string classFullName = Path.Combine(directoryPath, table.NetName + ".cs");

			// Create class directory if does not exists.
			if (Directory.Exists(directoryPath) == false)
            {
                Directory.CreateDirectory(directoryPath);
            }

			// Write class to disk.
            File.WriteAllText(classFullName, template);
        }
        /// <summary>
        /// Converts file path to namespace path.
        /// </summary>
        private string ConvertFileToNamespacePath(string filePathSegment)
		{
            return filePathSegment.Replace("/", ".");
		}
        #endregion
    }
}

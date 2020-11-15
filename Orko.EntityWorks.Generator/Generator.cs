using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Orko.EntityWorks.Generator
{
    /// <summary>
    /// Provides support for entity class generation.
    /// </summary>
    public class Generator
    {
        #region Constructors
        /// <summary>
        /// Creates instance of entity class generator.
        /// </summary>
        /// <param name="database">Database object</param>
        /// <param name="targetDirectory">Generator output directory</param>
        public Generator(Database database, DirectoryInfo targetDirectory)
        {
            // Validate.
            if (database == null)
                throw new EntityGeneratorException("Database object can not be null.");
            if (targetDirectory == null)
                throw new EntityGeneratorException("Target directory can not be null or does not exists.");

            // Assign properties.
            Database = database;
            TargetDirectory = targetDirectory.FullName;
            Namespace = Database.DatabaseName;
            UseLanguageTables = database.Settings.UseLanguageTables;
            LanguageTableSuffix = database.Settings.LanguageTableSuffix;
        }
        #endregion

        #region Properties
        private Database Database { get; set; }
        private string TargetDirectory { get; set; }
        private bool UseLanguageTables { get; set; }
        private string LanguageTableSuffix { get; set; }
        private string Namespace { get; set; }
        private string Tab { get { return "        "; }}
        private string NLine { get { return Environment.NewLine; }}
        #endregion

        #region Main methods
        public void GenerateDomainClasses()
        {
            // Get tables.
            IEnumerable<Table> tables = Database.Tables.Values;

            // If using language tables we do not generate language table class files.
            if (UseLanguageTables)
                tables = tables.Where(x => x.IsLanguageTable == false);

            // For each table create .cs entity class
            foreach (Table table in tables)
            {
                // Open domain class template
                string domainTemplate = ReadTextTemplateResource("Domain.txt");

                // Get tags data.
                string nameSpace = GetNamespace(table);
                string className = GetClassName(table);
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
                WriteClassToDisk(table, domainTemplate, "Domain", true);
            }
        }
        public void GenerateLogicClasses()
        {
            // Get tables.
            IEnumerable<Table> tables = Database.Tables.Values;

            // If using language tables we do not generate language table class files.
            if (UseLanguageTables)
                tables = tables.Where(x => x.IsLanguageTable == false);

            // For each table create .cs logic class
            foreach (Table table in tables)
            {
                // Open logic class template
                string logicTemplate = ReadTextTemplateResource("Logic.txt");

                // Get tags data.
                string nameSpace = GetNamespace(table);

                string className = GetClassName(table);
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
                logicTemplate = logicTemplate.Replace("[VAR_PK_N]",valueParameterList);

                // Generate class document.
                WriteClassToDisk(table, logicTemplate, "Logic", true);
            }
        }
        #endregion

        #region Domain generation methods
        private string GetNamespace(Table table)
        {
            if (string.IsNullOrEmpty(Namespace))
            {
                return Namespace + "." + char.ToUpper(table.Schema[0]) + table.Schema.Substring(1);
            }
            else return Namespace + "." + char.ToUpper(table.Schema[0]) + table.Schema.Substring(1);
        }
        private string GetFieldsMetadata(Table table)
        {
            // Field metadata container.
            string fieldMetadataList = string.Empty;

            // Add each table column to list.
            foreach (Column column in table.Columns.Values.OrderBy(x => x.OrdinalPosition))
            {
                // Open field metadata section template.
                string fieldMetadataTemplate = ReadTextTemplateResource("FieldMetadataList.txt");

                // Get tags data.
                string memberName = GetColumnName(column);
                string fieldMetadataArguments = GetFieldMetadataArguments(column);

                // Replace tags with actual data.
                fieldMetadataTemplate = fieldMetadataTemplate.Replace("[COLUMN_NAME]", memberName);
                fieldMetadataTemplate = fieldMetadataTemplate.Replace("[FIELD_METADATA_ARGS]", fieldMetadataArguments);

                // Add to field metadata list.
                fieldMetadataList += fieldMetadataTemplate + "," + NLine + Tab + Tab;
            }

            // Add each language table column to list.
            if (UseLanguageTables && table.HasLanguageTable)
            {
                foreach (Column column in table.LanguageTable.Columns.Values
                    .Where(x => x.IsLanguage || x.IsLanguageCode)
                    .OrderBy(x => x.OrdinalPosition))
                {
                    // Open field metadata section template.
                    string fieldMetadataTemplate = ReadTextTemplateResource("FieldMetadataList.txt");

                    // Get tags data.
                    string memberName = GetColumnName(column);
                    string fieldMetadataArguments = GetFieldMetadataArguments(column);

                    // Replace tags with actual data.
                    fieldMetadataTemplate = fieldMetadataTemplate.Replace("[COLUMN_NAME]", memberName);
                    fieldMetadataTemplate = fieldMetadataTemplate.Replace("[FIELD_METADATA_ARGS]", fieldMetadataArguments);

                    // Add to field metadata list.
                    fieldMetadataList += fieldMetadataTemplate + "," + NLine + Tab + Tab;
                }
            }
            return fieldMetadataList.TrimEnd(Tab.ToCharArray()).TrimEnd(NLine.ToCharArray()).TrimEnd(",".ToCharArray());
        }
        private string GetRelationsMetadata(Table table)
        {
            // Relation metadata container.
            string relationMetadataList = "null";
            if (table.ForeignKeys.Values.Any())
                relationMetadataList = string.Empty;

            foreach (ForeignKey foreignKey in table.ForeignKeys.Values.OrderBy(x => x.ForeignKeyColumnName))
            {
                foreach (Relation relation in foreignKey.Relations.OrderBy(x => x.ForeignKeyTableName))
                {
                    // Open field metadata section template.
                    string relationMetadataTemplate = ReadTextTemplateResource("RelationMetadataList.txt");

                    // Get tags data.
                    string fkTable = foreignKey.ForeignKeyColumnName;
                    string pkField = relation.PrimaryKeyTableColumnName;
                    string fkField = relation.ForeignKeyTableColumnName;

                    // Replace tags with actual data.
                    relationMetadataTemplate = relationMetadataTemplate.Replace("[FK_TABLE]", fkTable);
                    relationMetadataTemplate = relationMetadataTemplate.Replace("[PK_FIELD]", pkField);
                    relationMetadataTemplate = relationMetadataTemplate.Replace("[FK_FIELD]", fkField);

                    // Add to field metadata list.
                    relationMetadataList += relationMetadataTemplate + "," + NLine + Tab + Tab;
                }
            }
            return relationMetadataList.TrimEnd(Tab.ToCharArray()).TrimEnd(NLine.ToCharArray()).TrimEnd(",".ToCharArray());
        }
        private string GetTableMetadata(Table table)
        {
            // Table metadata container.
            string tableMetadataList = ReadTextTemplateResource("TableMetadata.txt");

            // Get tags data.
            string hasLanguageTable = table.LanguageTable != null ? "true" : "false";
            string tableSchema = table.Schema;
            string tableName = table.Name;
            string languageTableSchema = table.LanguageTable != null ? "\"" + table.LanguageTable.Schema + "\"" : "null";
            string languageTableName = table.LanguageTable != null ? "\"" + table.LanguageTable.Name + "\"" : "null";

            // Replace tags with actual data.
            tableMetadataList = tableMetadataList.Replace("[HLT]", hasLanguageTable);
            tableMetadataList = tableMetadataList.Replace("[TS]", tableSchema);
            tableMetadataList = tableMetadataList.Replace("[TN]", tableName);
            tableMetadataList = tableMetadataList.Replace("[LTS]", languageTableSchema);
            tableMetadataList = tableMetadataList.Replace("[LTN]", languageTableName);
            tableMetadataList = tableMetadataList.Replace("[TABLE_NAME]", tableName);

            // Return table metadata.
            return tableMetadataList;
        }
        private string GetClassName(Table table)
        {
            return table.Name;
        }
        private string GetFieldList(Table table)
        {
            // Field list container.
            string fieldList = string.Empty;

            // For each table column generate entity field.
            foreach (Column column in table.Columns.Values.OrderBy(x => x.OrdinalPosition))
            {
                // Open field list section template
                string propertyTemplate = ReadTextTemplateResource("FieldList.txt");

                // Get tags data.
                string access = GetAccess(column);
                string clrType = GetClrType(column);
                string columnName = GetColumnName(column);
                string set = GetSet(column);

                // Replate tags with actual data.
                propertyTemplate = propertyTemplate.Replace("[ACCESS]", access);
                propertyTemplate = propertyTemplate.Replace("[CLR_TYPE]", clrType);
                propertyTemplate = propertyTemplate.Replace("[COLUMN_NAME]", columnName);
                propertyTemplate = propertyTemplate.Replace("[SET]", set);

                // Add to property list
                fieldList += propertyTemplate + NLine + Tab;
            }

            // If using language tables.
            if (UseLanguageTables && table.HasLanguageTable)
            {
                // For each language table column generate entity field.
                foreach (Column column in table.LanguageTable.Columns.Values
                    .Where(x => x.IsLanguage || x.IsLanguageCode)
                    .OrderBy(x => x.OrdinalPosition))
                {
                    // Open field list section template
                    string propertyTemplate = ReadTextTemplateResource("FieldList.txt");

                    // Get tags data.
                    string access = GetAccess(column);
                    string clrType = GetClrType(column);
                    string columnName = GetColumnName(column);
                    string set = GetSet(column);

                    // Replate tags with actual data.
                    propertyTemplate = propertyTemplate.Replace("[ACCESS]", access);
                    propertyTemplate = propertyTemplate.Replace("[CLR_TYPE]", clrType);
                    propertyTemplate = propertyTemplate.Replace("[COLUMN_NAME]", columnName);
                    propertyTemplate = propertyTemplate.Replace("[SET]", set);

                    // Add to property list
                    fieldList += propertyTemplate + NLine + Tab;
                }
            }

            return fieldList.TrimEnd(Tab.ToCharArray()).TrimEnd(NLine.ToCharArray());
        }
        private string GetMemberList(Table table)
        {
            // Member list container.
            string memberList = string.Empty;

            // For each foreign table key generate member property.
            foreach (ForeignKey foreignKey in table.ForeignKeys.Values.OrderBy(x => x.ForeignKeyColumnName))
            {
                // Open member list section template.
                string memberTemplate = ReadTextTemplateResource("MemberList.txt");

                // Get tags data.
                string fkClassName = GetForeignKeyClassName(foreignKey);
                string fkColumnName = GetForeignKeyMemberColumnName(foreignKey);

                // Replate tags with actual data.
                memberTemplate = memberTemplate.Replace("[FK_KEY_NAME]", fkColumnName);
                memberTemplate = memberTemplate.Replace("[FK_CLASS_NAME]", fkClassName);

                // Add to member list.
                memberList += memberTemplate + NLine + Tab;
            }
            return memberList.TrimEnd(Tab.ToCharArray()).TrimEnd(NLine.ToCharArray());
        }
        private string GetEntityList(Table table)
        {
            // Entity list container.
            string nodeList = string.Empty;

            // For each foreign table key generate entity property.
            foreach (ForeignKey foreignKey in table.ForeignKeys.Values.OrderBy(x => x.ForeignKeyColumnName))
            {
                // Open node entity section template.
                string nodeTemplate = ReadTextTemplateResource("EntityList.txt");

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
                nodeList += nodeTemplate + NLine + Tab;
            }
            return nodeList.TrimEnd(Tab.ToCharArray()).TrimEnd(NLine.ToCharArray());
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
                string uniqueTemplate = ReadTextTemplateResource("UniqueMethodList.txt");

                // Get tags data.
                string className = GetClassName(table);
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
                    uniqueList += NLine + Tab + uniqueTemplate + NLine + Tab;
                else uniqueList += uniqueTemplate + NLine + Tab;
            }
            //if (counter == 0)
            //{
            //    return uniqueList.TrimEnd(Tab.ToCharArray()).TrimEnd(NLine.ToCharArray()).TrimEnd(Tab.ToCharArray()).TrimEnd(NLine.ToCharArray());
            //}
            return uniqueList.TrimEnd(Tab.ToCharArray()).TrimEnd(NLine.ToCharArray());
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

            fieldArgumentList.Add("SqlDbType." + column.SqlDbType.ToString());

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
            return retVal.TrimEnd(new char[] {',',' '});
        }
        private string GetAccess(Column column)
        {
            return "public";
        }
        private string GetClrType(Column column)
        {
            return column.NetDataTypeName;
        }
        private string GetColumnName(Column column)
        {
            return column.Name;
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
            return foreignKey.ForeignKeyColumnName;
        }
        private string GetForeignKeyClassName(ForeignKey foreignKey)
        {
            if (foreignKey.Relations[0].PrimaryKeyTableSchema != foreignKey.Relations[0].ForeignKeyTableSchema)
                return foreignKey.Relations[0].PrimaryKeyTableFullName.ToUpperCamelCase();
            else return foreignKey.Relations[0].PrimaryKeyTableName;
        }
        #endregion

        #region Entity generation methods
        private string GetForeignKeyDeclaringClassName(ForeignKey foreignKey)
        {
            return foreignKey.Table.Name;
        }
        private string GetForeignKeyMemberColumnName(ForeignKey foreignKey)
        {
            return "m_" + foreignKey.ForeignKeyColumnName;
        }
        private string GetGetAccessor(ForeignKey foreignKey)
        {
            string fkClassName = GetForeignKeyClassName(foreignKey);
            string fkColumnName = GetForeignKeyColumnName(foreignKey);
            string fkMemberColumnName = GetForeignKeyMemberColumnName(foreignKey);
            string fkDeclaringClassName = GetForeignKeyDeclaringClassName(foreignKey);

            string getTemplate = "get { return EntityContext<" + fkClassName + ">.Get(ref " + fkMemberColumnName + ", this, \"" + fkColumnName + "\"); }";
            return getTemplate;
        }
        private string GetSetAccessor(ForeignKey foreignKey)
        {
            string fkClassName = GetForeignKeyClassName(foreignKey);
            string fkColumnName = GetForeignKeyColumnName(foreignKey);
            string fkMemberColumnName = GetForeignKeyMemberColumnName(foreignKey);
            string fkDeclaringClassName = GetForeignKeyDeclaringClassName(foreignKey);

            string setTemplate = "set { EntityContext<" + fkClassName + ">.Set(ref " + fkMemberColumnName + ", this, value, \"" + fkColumnName + "\"); }";
            return setTemplate;
        }
        #endregion

        #region Logic generation methods
        private string GetTypeParameterList(Table table)
        {
            string typeList = string.Empty;
            foreach (Column column in table.PrimaryKey.Columns.Values.OrderBy(x => x.OrdinalPosition))
            {
                typeList += column.NetDataArgumentTypeName + " " + column.Name + ", ";
            }
            typeList = typeList.TrimEnd(new char[] { ',',' ' });
            return typeList;
        }
        private string GetValueParameterList(Table table)
        {
            string valueList = string.Empty;
            foreach (Column column in table.PrimaryKey.Columns.Values.OrderBy(x => x.OrdinalPosition))
            {
                valueList += column.Name + ", ";
            }
            valueList = valueList.TrimEnd(new char[] { ',',' ' });
            return valueList;
        }
        #endregion

        #region Unique method methods
        private string GetTypeParameterList(UniqueKey uniqueKey)
        {
            string typeList = string.Empty;
            foreach (Column column in uniqueKey.Columns.Values)
            {
                typeList += column.NetDataArgumentTypeName + " " + column.Name + ", ";
            }
            typeList = typeList.TrimEnd(new char[] { ',', ' ' });
            return typeList;
        }
        private string GetValueParameterList(UniqueKey uniqueKey)
        {
            string valueList = string.Empty;
            foreach (Column column in uniqueKey.Columns.Values)
            {
                valueList += column.Name + ", ";
            }
            valueList = valueList.TrimEnd(new char[] { ',', ' ' });
            return valueList;
        }
        #endregion

        #region Helper methods
        private string ReadTextTemplateResource(string documentName)
        {
            // Get assembly that contains txt file template document1
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "EntityWorks.Generator.Templates." + documentName;
            string template = null;

            // Get stream and read embeded resource template.
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    template = streamReader.ReadToEnd();
                }
            }
            return template;
        }
        private void WriteClassToDisk(Table table, string template, string folder, bool groupBySchemas = false)
        {
			// Directory path.
			string directoryPath = string.Empty;
			if (groupBySchemas)
				directoryPath = Path.Combine(TargetDirectory, table.Schema, folder);
			else directoryPath = Path.Combine(TargetDirectory, folder);
			
			// Class full name.
			string classFullName = Path.Combine(directoryPath, table.Name + ".cs");

			// Create class directory if does not exists.
			if (Directory.Exists(directoryPath) == false)
            {
                Directory.CreateDirectory(directoryPath);
            }

			// Write class to disk.
            File.WriteAllText(classFullName, template);
        }
        #endregion
    }
}

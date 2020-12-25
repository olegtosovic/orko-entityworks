// Generated on 12/25/2020 11:27 AM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace AdventureWorks.Production
{
    /// <summary>
    /// Document entity.
    /// </summary>
    public partial class Document
    {
		#region Self
		public static string _Self { get { return "Production.Document"; } }
		#endregion

        #region Columns
        public static string _DocumentNode { get { return @"Production.Document.DocumentNode"; } }
        public static string _DocumentLevel { get { return @"Production.Document.DocumentLevel"; } }
        public static string _Title { get { return @"Production.Document.Title"; } }
        public static string _Owner { get { return @"Production.Document.Owner"; } }
        public static string _FolderFlag { get { return @"Production.Document.FolderFlag"; } }
        public static string _FileName { get { return @"Production.Document.FileName"; } }
        public static string _FileExtension { get { return @"Production.Document.FileExtension"; } }
        public static string _Revision { get { return @"Production.Document.Revision"; } }
        public static string _ChangeNumber { get { return @"Production.Document.ChangeNumber"; } }
        public static string _Status { get { return @"Production.Document.Status"; } }
        public static string _DocumentSummary { get { return @"Production.Document.DocumentSummary"; } }
        public static string _c_Document { get { return @"Production.Document.Document"; } }
        public static string _rowguid { get { return @"Production.Document.rowguid"; } }
        public static string _ModifiedDate { get { return @"Production.Document.ModifiedDate"; } }
        #endregion
    }
}
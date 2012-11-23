/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Text;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class GridViewTemplates : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public GridViewTemplates() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public GridViewTemplates(Control owner) : base(owner) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public GridView View
        {
            get
            {
                return this.Owner as GridView;
            }
        }

        private XTemplate header;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("header", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public XTemplate Header
        {
            get
            {
                if (this.View.ParentGrid is PropertyGrid)
                {
                    return null;
                }

                this.EnsureHeader();                

                return this.header;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void EnsureHeader()
        {
            if (this.View.ParentGrid is PropertyGrid)
            {
                return;
            }

            if (this.header == null)
            {
                this.header = new XTemplate();
                this.header.PreRender += new System.EventHandler(header_PreRender);
            }     
        }

        void header_PreRender(object sender, System.EventArgs e)
        {
            this.BuildHeaderTemplate();
        }

        internal void BuildHeaderTemplate()
        {
            if (this.View.HeaderRows.Count > 0)
            {
                StringBuilder sb = new StringBuilder(128);
                sb.Append("<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"{tstyle}\">");

                if (this.View.StandardHeaderRow)
                {
                    sb.Append("<thead><tr class=\"x-grid3-hd-row x-grid3-sadd-row\">{cells}</tr></thead>");
                }

                sb.Append("<tbody>");
                int rowIndex = 0;

                foreach (HeaderRow headerRow in this.View.HeaderRows)
                {
                    sb.AppendFormat("<tr class=\"x-grid3-hd-row x-grid3-add-row x-grid3-hd-row-r{1} {0}\">", headerRow.Cls, rowIndex++);

                    int colIndex = 0;

                    foreach (HeaderColumn headerColumn in headerRow.Columns)
                    {
                        sb.AppendFormat("<td class=\"x-grid3-hd x-grid3-cell x-grid3-td-c{0}\"><div class=\"x-grid3-hd-inner x-grid3-add {1}\"></div></td>", colIndex++, headerColumn.Cls);
                    }

                    sb.Append("</tr>");
                }

                sb.Append("</tbody>");
                sb.Append("</table>");

                this.Header.Html = sb.ToString();
            }
        }
    }
}
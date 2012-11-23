/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class ColumnTree : TreePanel
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ColumnTree() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static string ColumnNodeUI
        {
            get
            {
                return "Ext.tree.ColumnNodeUI";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "columntree";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.tree.ColumnTree";
            }
        }

        private ColumnTreeColumnCollection columns;

        /// <summary>
        /// An array of column configuration objects
        /// </summary>
        [Meta]
        [ConfigOption("columns", JsonMode.AlwaysArray)]
        [Category("8. ColumnTree")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An array of column configuration objects")]
        public virtual ColumnTreeColumnCollection Columns
        {
            get
            {
                if (this.columns == null)
                {
                    this.columns = new ColumnTreeColumnCollection();
                }

                return this.columns;
            }
        }

        /// <summary>
        /// True to hide the grid's header (defaults to false).
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [Description("True to hide the grid's header (defaults to false).")]
        public virtual bool HideHeaders
        {
            get
            {
                object obj = this.ViewState["HideHeaders"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["HideHeaders"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 2;

                baseList.Add(new ClientStyleItem(typeof(MultiSelect), "Ext.Net.Build.Ext.Net.ux.extensions.columntree.resources.css.columnnodeui-embedded.css", "/ux/extensions/columntree/resources/css/columnnodeui.css"));
                baseList.Add(new ClientScriptItem(typeof(MultiSelect), "Ext.Net.Build.Ext.Net.ux.extensions.columntree.columnnodeui.js", "/ux/extensions/columntree/columnnodeui.js"));

                return baseList;
            }
        }
    }
}
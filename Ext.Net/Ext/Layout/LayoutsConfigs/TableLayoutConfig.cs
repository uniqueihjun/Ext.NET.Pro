/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class TableLayoutConfig : LayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TableLayoutConfig(int columns, DomObject tableAttrs, bool renderHidden, string extraCls)
            : base(renderHidden, extraCls)
        {
            this.Columns = columns;
            this.tableAttrs = tableAttrs;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TableLayoutConfig() { }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.Raw)]
        [DefaultValue(0)]
		[Description("")]
        public int Columns
        {
            get
            {
                object obj = this.ViewState["Columns"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["Columns"] = value;
            }
        }

        private DomObject tableAttrs;

        /// <summary>
        /// An object containing properties which are added to the DomHelper specification used to create the layout's <table> element.
        /// </summary>
        [ConfigOption(JsonMode.Object)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An object containing properties which are added to the DomHelper specification used to create the layout's <table> element.")]
        public virtual DomObject TableAttrs
        {
            get
            {
                if (this.tableAttrs == null)
                {
                    this.tableAttrs = new DomObject();
                }

                return this.tableAttrs;
            }
        }
    }
}
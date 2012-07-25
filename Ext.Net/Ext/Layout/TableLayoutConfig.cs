/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// This layout allows you to easily render content into an HTML table. The total number of columns can be specified, and rowspan and colspan can be used to create complex layouts within the table. This class is intended to be extended or created via the layout: {type: 'table'} Ext.container.Container-layout config, and should generally not need to be created directly via the new keyword.
    /// 
    /// Note that when creating a layout via config, the layout-specific config properties must be passed in via the Ext.container.Container-layout object which will then be applied internally to the layout. In the case of TableLayout, the only valid layout config properties are columns and tableAttrs. However, the items added to a TableLayout can supply the following table-specific config properties:
    /// 
    /// rowspan Applied to the table cell containing the item.
    /// colspan Applied to the table cell containing the item.
    /// cellId An id applied to the table cell containing the item.
    /// cellCls A CSS class name added to the table cell containing the item.
    /// The basic concept of building up a TableLayout is conceptually very similar to building up a standard HTML table. You simply add each panel (or "cell") that you want to include along with any span attributes specified as the special config properties of rowspan and colspan which work exactly like their HTML counterparts. Rather than explicitly creating and nesting rows and columns as you would in HTML, you simply specify the total column count in the layoutConfig and start adding panels in their natural order from left to right, top to bottom. The layout will automatically figure out, based on the column count, rowspans and colspans, how to position each panel within the table. Just like with HTML tables, your rowspans and colspans must add up correctly in your overall layout or you'll end up with missing and/or extra cells! 
	/// </summary>
	[Description("")]
    public partial class TableLayoutConfig : LayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TableLayoutConfig() { }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("type")]
        [DefaultValue("")]
        protected override string LayoutType
        {
            get
            {
                return "table";
            }
        }

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
                return this.State.Get<int>("Columns", 0);
            }
            set
            {
                this.State.Set("Columns", value);
            }
        }

        private DomObject tableAttrs;

        /// <summary>
        /// An object containing properties which are added to the DomHelper specification used to create the layout's &lt;table&gt; element.
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

        private DomObject tdAttrs;

        /// <summary>
        /// An object containing properties which are added to the DomHelper specification used to create the layout's td elements.
        /// </summary>
        [ConfigOption("tdAttrs",JsonMode.Object)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An object containing properties which are added to the DomHelper specification used to create the layout's <td> elements.")]
        public virtual DomObject TDAttrs
        {
            get
            {
                if (this.tdAttrs == null)
                {
                    this.tdAttrs = new DomObject();
                }

                return this.tdAttrs;
            }
        }

        private DomObject trAttrs;

        /// <summary>
        /// An object containing properties which are added to the DomHelper specification used to create the layout's tr elements.
        /// </summary>
        [ConfigOption("trAttrs", JsonMode.Object)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An object containing properties which are added to the DomHelper specification used to create the layout's <tr> elements.")]
        public virtual DomObject TRAttrs
        {
            get
            {
                if (this.trAttrs == null)
                {
                    this.trAttrs = new DomObject();
                }

                return this.trAttrs;
            }
        }
    }
}
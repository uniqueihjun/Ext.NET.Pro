/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web.UI;
using System.ComponentModel;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class RowNumbererColumn : ColumnBase, ICustomConfigSerialization
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public RowNumbererColumn() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ToScript(Control owner)
        {
            return string.Concat("new Ext.grid.RowNumberer(", new ClientConfig().Serialize(this, true), ")");
        }

        /// <summary>
        /// (optional) The initial width in pixels of the column. Using this instead of Ext.grid.GridPanel.autoSizeColumns is more efficient.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. ColumnBase")]
        [DefaultValue(typeof(Unit), "-1")]
        [Description("(optional) The initial width in pixels of the column. Using this instead of Ext.grid.Grid.autoSizeColumns is more efficient.")]
        public override Unit Width
        {
            get
            {
                object obj = this.ViewState["Width"];
                return (obj == null) ? Unit.Pixel(-1) : (Unit)obj;
            }
            set
            {
                this.ViewState["Width"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("rowspan")]
        [DefaultValue(1)]
        [Category("2. ColumnBase")]
        [Description("")]
        public int RowSpan
        {
            get
            {
                object obj = this.ViewState["RowSpan"];
                return obj != null ? (int)obj : 1;
            }
            set
            {
                this.ViewState["RowSpan"] = value;
            }
        }

    }
}

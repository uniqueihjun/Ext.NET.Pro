/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class LayoutRow : LayoutItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public LayoutRow() { }

        /// <summary>
        /// The ColumnWidth property is always evaluated as a percentage, and must be a decimal value greater than 0 and less than or equal to 1.0.
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [Category("6. RowLayout")]
        [DefaultValue(0)]
        [Description("The ColumnWidth property is always evaluated as a percentage, and must be a decimal value greater than 0 and less than or equal to 1.0.")]
        public virtual decimal RowHeight
        {
            get
            {
                object obj = this.ViewState["RowHeight"];
                return (obj == null) ? 0 : (decimal)obj;
            }
            set
            {
                if (value > 1 || value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", value, "The value must be greater than 0 and less than or equal to 1.0.");
                }

                this.ViewState["RowHeight"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("rowHeight", JsonMode.Raw)]
        [DefaultValue("0")]
        [Browsable(false)]
        [Description("")]
        protected string RowHeightProxy
        {
            get
            {
                NumberFormatInfo nf = new NumberFormatInfo();
                nf.CurrencyDecimalSeparator = ".";

                return RowHeight.ToString(nf);
            }
        }
    }
}
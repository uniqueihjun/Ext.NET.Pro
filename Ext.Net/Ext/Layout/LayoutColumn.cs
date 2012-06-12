/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class LayoutColumn : LayoutItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public LayoutColumn() { }

        /// <summary>
        /// The ColumnWidth property is always evaluated as a percentage, and must be a decimal value greater than 0 and less than 1.
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [Category("3. LayoutColumn")]
        [DefaultValue(0)]
        [Description("The ColumnWidth property is always evaluated as a percentage, and must be a decimal value greater than 0 and less than or equal to 1.0.")]
        public virtual decimal ColumnWidth
        {
            get
            {
                object obj = this.ViewState["ColumnWidth"];
                return (obj == null) ? 0 : (decimal)obj;
            }
            set
            {
                if (value > 1 || value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", value, "The value must be greater than 0 and less than or equal to 1.0.");
                }

                this.ViewState["ColumnWidth"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("columnWidth", JsonMode.Raw)]
        [DefaultValue("0")]
        [Browsable(false)]
        [Description("")]
        protected string ColumnWidthProxy
        {
            get
            {
                NumberFormatInfo nf = new NumberFormatInfo();
                nf.CurrencyDecimalSeparator = ".";

                return ColumnWidth.ToString(nf);
            }
        }
    }
}
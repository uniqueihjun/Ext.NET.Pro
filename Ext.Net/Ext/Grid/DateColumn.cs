/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class DateColumn : Column
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DateColumn() { }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("xtype")]
        [DefaultValue("")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "datecolumn";
            }
        }

        /// <summary>
        /// A formatting string as used by Date.format to format a Date for this Column.
        /// </summary>
        [Meta]
        [Category("3. DateColumn")]
        [DefaultValue("")]
        [Description("A formatting string as used by Date.format to format a Date for this Column.")]
        public virtual string Format
        {
            get
            {
                return (string)this.ViewState["Format"] ?? "";
            }
            set
            {
                this.ViewState["Format"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("format")]
        [DefaultValue("")]
		[Description("")]
        protected virtual string FormatProxy
        {
            get
            {
                return this.Format.IsEmpty() ? "" : DateTimeUtils.ConvertNetToPHP(this.Format);
            }
        }
    }
}
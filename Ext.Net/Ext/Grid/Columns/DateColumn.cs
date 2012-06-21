/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A Column definition class which renders a passed date according to the default locale, or a configured format.
    /// </summary>
    [Meta]
    [Description("")]
    public partial class DateColumn : CellCommandColumn
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DateColumn() { }

		/// <summary>
		/// 
		/// </summary>
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
        /// A formatting string as used by Date.format to format a Date for this Column. This defaults to the default date from Ext.Date.defaultFormat which itself my be overridden in a locale file.
        /// </summary>
        [Meta]
        [Category("3. DateColumn")]
        [DefaultValue("")]
        [Description("A formatting string as used by Date.format to format a Date for this Column. This defaults to the default date from Ext.Date.defaultFormat which itself my be overridden in a locale file.")]
        public virtual string Format
        {
            get
            {
                return this.State.Get<string>("Format", "");
            }
            set
            {
                this.State.Set("Format", value);
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
                return this.Format.IsEmpty() ? "" : DateTimeUtils.ConvertNetToPHP(this.Format, this.ResourceManager != null ? this.ResourceManager.CurrentLocale : null);
            }
        }
    }
}
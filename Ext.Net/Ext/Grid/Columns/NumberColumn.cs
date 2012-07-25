/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A Column definition class which renders a numeric data field according to a format string.
    /// </summary>
    [Meta]
    [Description("")]
    public partial class NumberColumn : CellCommandColumn
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public NumberColumn() { }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "numbercolumn";
            }
        }

        /// <summary>
        /// A formatting string as used by Ext.util.Format.number to format a numeric value for this Column (defaults to '0,000.00').
        /// Formats the number according to the format string.
        /// examples (123456.789):
        /// 0 - (123456) show only digits, no precision
        /// 0.00 - (123456.78) show only digits, 2 precision
        /// 0.0000 - (123456.7890) show only digits, 4 precision
        /// 0,000 - (123,456) show comma and digits, no precision
        /// 0,000.00 - (123,456.78) show comma and digits, 2 precision
        /// 0,0.00 - (123,456.78) shortcut method, show comma and digits, 2 precision
        /// To reverse the grouping (,) and decimal (.) for international numbers, add /i to the end. For example: 0.000,00/i
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. NumberColumn")]
        [DefaultValue("0,000.00")]
        [Description("A formatting string as used by Ext.util.Format.number to format a numeric value for this Column (defaults to '0,000.00').")]
        public virtual string Format
        {
            get
            {
                return this.State.Get<string>("Format", "0,000.00");
            }
            set
            {
                this.State.Set("Format", value);
            }
        }
    }
}
/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;

namespace Ext.Net.MVC
{
    public partial class NumberColumnAttribute : ColumnBaseAttribute
    {
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
        [DefaultValue(null)]
        public virtual string Format
        {
            get;
            set;
        }
        
        protected override ColumnBase CreateColumn()
        {
            return new NumberColumn();
        }
    }
}
/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;

namespace Ext.Net.MVC
{
    public partial class DateColumnAttribute : ColumnBaseAttribute
    {
        /// <summary>
        /// A formatting string as used by Date.format to format a Date for this Column. This defaults to the default date from Ext.Date.defaultFormat which itself my be overridden in a locale file.
        /// </summary>
        [DefaultValue(null)]
        public virtual string Format
        {
            get;
            set;
        }
        
        protected override ColumnBase CreateColumn()
        {
            return new DateColumn();
        }
    }
}
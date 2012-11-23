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
    public partial class BooleanColumnAttribute : ColumnBaseAttribute
    {
        /// <summary>
        /// The string returned by the renderer when the column value is falsey (but not undefined) (defaults to 'false').
        /// </summary>
        [DefaultValue(null)]
        public virtual string FalseText
        {
            get;
            set;
        }

        /// <summary>
        /// The string returned by the renderer when the column value is not falsey (defaults to 'true').
        /// </summary>
        [DefaultValue(null)]
        public virtual string TrueText
        {
            get;
            set;
        }

        /// <summary>
        /// The string returned by the renderer when the column value is undefined (defaults to ' ').
        /// </summary>
        [DefaultValue(null)]
        public virtual string UndefinedText
        {
            get;
            set;
        }
        
        protected override ColumnBase CreateColumn()
        {
            return new BooleanColumn();
        }
    }
}
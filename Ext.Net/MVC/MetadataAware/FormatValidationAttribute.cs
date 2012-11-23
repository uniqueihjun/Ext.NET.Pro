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
    public partial class FormatValidationAttribute : AbstractValidationAttribute
    {
        /// <summary>
        /// A JavaScript RegExp object to be tested against the value
        /// </summary>
        [DefaultValue(null)]
        public virtual string Matcher
        {
            get;
            set;
        }

        protected override AbstractValidation CreateValidation()
        {
            return new FormatValidation { Matcher = this.Matcher };
        }
    }
}
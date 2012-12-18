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
    public partial class InclusionValidationAttribute : AbstractValidationAttribute
    {

        public InclusionValidationAttribute(params string[] values)
        {
            this.List = values;
        }
        
        /// <summary>
        /// The list of options
        /// </summary>        
        [DefaultValue(null)]
        public virtual string[] List
        {
            get;
            set;
        }

        protected override AbstractValidation CreateValidation()
        {
            return new InclusionValidation { List = this.List };
        }
    }
}
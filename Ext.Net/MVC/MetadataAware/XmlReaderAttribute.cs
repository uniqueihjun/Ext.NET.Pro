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
    public partial class XmlReaderAttribute : AbstractReaderAttribute
    {
        /// <summary>
        /// The DomQuery path to the repeated element which contains record information.
        /// </summary>
        [DefaultValue(null)]
        public virtual string Record
        {
            get;
            set;
        }
        
        protected override AbstractReader CreateReader()
        {
            return new XmlReader();
        }
    }
}
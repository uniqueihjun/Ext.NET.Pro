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
    public partial class XmlWriterAttribute : AbstractWriterAttribute
    {
        /// <summary>
        /// The root to be used if documentRoot is empty and a root is required to form a valid XML document.
        /// </summary>
        [DefaultValue(null)]
        public virtual string DefaultDocumentRoot
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the root element of the document. Defaults to 'xmlData'. If there is more than 1 record and the root is not specified, the default document root will still be used to ensure a valid XML document is created.
        /// </summary>
        [DefaultValue(null)]
        public virtual string DocumentRoot
        {
            get;
            set;
        }

        /// <summary>
        /// A header to use in the XML document (such as setting the encoding or version). Defaults to ''.
        /// </summary>
        [DefaultValue(null)]
        public virtual string Header
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the node to use for each record. Defaults to 'record'.
        /// </summary>
        [DefaultValue(null)]
        public virtual string Record
        {
            get;
            set;
        }

        protected override AbstractWriter CreateWriter()
        {
            return new XmlWriter();
        }
    }
}
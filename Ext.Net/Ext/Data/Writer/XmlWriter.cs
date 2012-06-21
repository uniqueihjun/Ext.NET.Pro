/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Writer that outputs model data in XML format
    /// </summary>
    [Meta]
    public partial class XmlWriter : AbstractWriter
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlWriter()
        {
        }
        
        /// <summary>
        /// Alias
        /// </summary>
        [ConfigOption]
        [DefaultValue(null)]
        protected override string Type
        {
            get
            {
                return "xml";
            }
        }

        /// <summary>
        /// The root to be used if documentRoot is empty and a root is required to form a valid XML document.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The root to be used if documentRoot is empty and a root is required to form a valid XML document.")]
        public virtual string DefaultDocumentRoot
        {
            get
            {
                return this.State.Get<string>("DefaultDocumentRoot", "");
            }
            set
            {
                this.State.Set("DefaultDocumentRoot", value);
            }
        }

        /// <summary>
        /// The name of the root element of the document. Defaults to 'xmlData'. If there is more than 1 record and the root is not specified, the default document root will still be used to ensure a valid XML document is created.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The name of the root element of the document. Defaults to 'xmlData'. If there is more than 1 record and the root is not specified, the default document root will still be used to ensure a valid XML document is created.")]
        public virtual string DocumentRoot
        {
            get
            {
                return this.State.Get<string>("DocumentRoot", "");
            }
            set
            {
                this.State.Set("DocumentRoot", value);
            }
        }

        /// <summary>
        /// A header to use in the XML document (such as setting the encoding or version). Defaults to ''.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("A header to use in the XML document (such as setting the encoding or version). Defaults to ''.")]
        public virtual string Header
        {
            get
            {
                return this.State.Get<string>("Header", "");
            }
            set
            {
                this.State.Set("Header", value);
            }
        }

        /// <summary>
        /// The name of the node to use for each record. Defaults to 'record'.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The name of the node to use for each record. Defaults to 'record'.")]
        public virtual string Record
        {
            get
            {
                return this.State.Get<string>("Record", "");
            }
            set
            {
                this.State.Set("Record", value);
            }
        }
    }
}

/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class XmlWriter
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public XmlWriter(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit XmlWriter.Config Conversion to XmlWriter
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator XmlWriter(XmlWriter.Config config)
        {
            return new XmlWriter(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractWriter.Config 
        { 
			/*  Implicit XmlWriter.Config Conversion to XmlWriter.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator XmlWriter.Builder(XmlWriter.Config config)
			{
				return new XmlWriter.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string defaultDocumentRoot = "";

			/// <summary>
			/// The root to be used if documentRoot is empty and a root is required to form a valid XML document.
			/// </summary>
			[DefaultValue("")]
			public virtual string DefaultDocumentRoot 
			{ 
				get
				{
					return this.defaultDocumentRoot;
				}
				set
				{
					this.defaultDocumentRoot = value;
				}
			}

			private string documentRoot = "";

			/// <summary>
			/// The name of the root element of the document. Defaults to 'xmlData'. If there is more than 1 record and the root is not specified, the default document root will still be used to ensure a valid XML document is created.
			/// </summary>
			[DefaultValue("")]
			public virtual string DocumentRoot 
			{ 
				get
				{
					return this.documentRoot;
				}
				set
				{
					this.documentRoot = value;
				}
			}

			private string header = "";

			/// <summary>
			/// A header to use in the XML document (such as setting the encoding or version). Defaults to ''.
			/// </summary>
			[DefaultValue("")]
			public virtual string Header 
			{ 
				get
				{
					return this.header;
				}
				set
				{
					this.header = value;
				}
			}

			private string record = "";

			/// <summary>
			/// The name of the node to use for each record. Defaults to 'record'.
			/// </summary>
			[DefaultValue("")]
			public virtual string Record 
			{ 
				get
				{
					return this.record;
				}
				set
				{
					this.record = value;
				}
			}

        }
    }
}
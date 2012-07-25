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
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractWriter.Builder<XmlWriter, XmlWriter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new XmlWriter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XmlWriter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XmlWriter.Config config) : base(new XmlWriter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(XmlWriter component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The root to be used if documentRoot is empty and a root is required to form a valid XML document.
			/// </summary>
            public virtual XmlWriter.Builder DefaultDocumentRoot(string defaultDocumentRoot)
            {
                this.ToComponent().DefaultDocumentRoot = defaultDocumentRoot;
                return this as XmlWriter.Builder;
            }
             
 			/// <summary>
			/// The name of the root element of the document. Defaults to 'xmlData'. If there is more than 1 record and the root is not specified, the default document root will still be used to ensure a valid XML document is created.
			/// </summary>
            public virtual XmlWriter.Builder DocumentRoot(string documentRoot)
            {
                this.ToComponent().DocumentRoot = documentRoot;
                return this as XmlWriter.Builder;
            }
             
 			/// <summary>
			/// A header to use in the XML document (such as setting the encoding or version). Defaults to ''.
			/// </summary>
            public virtual XmlWriter.Builder Header(string header)
            {
                this.ToComponent().Header = header;
                return this as XmlWriter.Builder;
            }
             
 			/// <summary>
			/// The name of the node to use for each record. Defaults to 'record'.
			/// </summary>
            public virtual XmlWriter.Builder Record(string record)
            {
                this.ToComponent().Record = record;
                return this as XmlWriter.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public XmlWriter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.XmlWriter(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlWriter.Builder XmlWriter()
        {
            return this.XmlWriter(new XmlWriter());
        }

        /// <summary>
        /// 
        /// </summary>
        public XmlWriter.Builder XmlWriter(XmlWriter component)
        {
            return new XmlWriter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public XmlWriter.Builder XmlWriter(XmlWriter.Config config)
        {
            return new XmlWriter.Builder(new XmlWriter(config));
        }
    }
}
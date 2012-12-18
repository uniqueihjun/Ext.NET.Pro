/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class XmlReader
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TXmlReader, TBuilder> : AbstractReader.Builder<TXmlReader, TBuilder>
            where TXmlReader : XmlReader
            where TBuilder : Builder<TXmlReader, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TXmlReader component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The DomQuery path to the repeated element which contains record information.
			/// </summary>
            public virtual TBuilder Record(string record)
            {
                this.ToComponent().Record = record;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : XmlReader.Builder<XmlReader, XmlReader.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new XmlReader()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XmlReader component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XmlReader.Config config) : base(new XmlReader(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(XmlReader component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public XmlReader.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.XmlReader(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public XmlReader.Builder XmlReader()
        {
#if MVC
			return this.XmlReader(new XmlReader { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.XmlReader(new XmlReader());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public XmlReader.Builder XmlReader(XmlReader component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new XmlReader.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public XmlReader.Builder XmlReader(XmlReader.Config config)
        {
#if MVC
			return new XmlReader.Builder(new XmlReader(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new XmlReader.Builder(new XmlReader(config));
#endif			
        }
    }
}
/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
        public partial class Builder : AbstractReader.Builder<XmlReader, XmlReader.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The DomQuery path to the repeated element which contains record information.
			/// </summary>
            public virtual XmlReader.Builder Record(string record)
            {
                this.ToComponent().Record = record;
                return this as XmlReader.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public XmlReader.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.XmlReader(this);
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
            return this.XmlReader(new XmlReader());
        }

        /// <summary>
        /// 
        /// </summary>
        public XmlReader.Builder XmlReader(XmlReader component)
        {
            return new XmlReader.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public XmlReader.Builder XmlReader(XmlReader.Config config)
        {
            return new XmlReader.Builder(new XmlReader(config));
        }
    }
}
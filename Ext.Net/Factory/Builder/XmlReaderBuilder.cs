/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class XmlReader
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DataReader.Builder<XmlReader, XmlReader.Builder>
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
			/// The DomQuery path relative from the record element to the element that contains a record identifier value.
			/// </summary>
            public virtual XmlReader.Builder IDPath(string iDPath)
            {
                this.ToComponent().IDPath = iDPath;
                return this as XmlReader.Builder;
            }
             
 			/// <summary>
			/// The DomQuery path to the repeated element which contains record information.
			/// </summary>
            public virtual XmlReader.Builder Record(string record)
            {
                this.ToComponent().Record = record;
                return this as XmlReader.Builder;
            }
             
 			/// <summary>
			/// The DomQuery path to the success attribute used by forms.
			/// </summary>
            public virtual XmlReader.Builder Success(string success)
            {
                this.ToComponent().Success = success;
                return this as XmlReader.Builder;
            }
             
 			/// <summary>
			/// The DomQuery path from which to retrieve the total number of records in the dataset. This is only needed if the whole dataset is not passed in one go, but is being paged from the remote server.
			/// </summary>
            public virtual XmlReader.Builder TotalProperty(string totalProperty)
            {
                this.ToComponent().TotalProperty = totalProperty;
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
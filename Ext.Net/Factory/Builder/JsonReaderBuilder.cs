/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class JsonReader
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DataReader.Builder<JsonReader, JsonReader.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new JsonReader()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(JsonReader component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(JsonReader.Config config) : base(new JsonReader(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(JsonReader component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// [id] Name of the property within a row object that contains a record identifier value. Defaults to id
			/// </summary>
            public virtual JsonReader.Builder IDProperty(string iDProperty)
            {
                this.ToComponent().IDProperty = iDProperty;
                return this as JsonReader.Builder;
            }
             
 			/// <summary>
			/// Name of the property which contains the Array of row objects.
			/// </summary>
            public virtual JsonReader.Builder Root(string root)
            {
                this.ToComponent().Root = root;
                return this as JsonReader.Builder;
            }
             
 			/// <summary>
			/// Name of the property from which to retrieve the success attribute used by forms.
			/// </summary>
            public virtual JsonReader.Builder SuccessProperty(string successProperty)
            {
                this.ToComponent().SuccessProperty = successProperty;
                return this as JsonReader.Builder;
            }
             
 			/// <summary>
			/// The DomQuery path from which to retrieve the total number of records in the dataset. This is only needed if the whole dataset is not passed in one go, but is being paged from the remote server.
			/// </summary>
            public virtual JsonReader.Builder TotalProperty(string totalProperty)
            {
                this.ToComponent().TotalProperty = totalProperty;
                return this as JsonReader.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonReader.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.JsonReader(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public JsonReader.Builder JsonReader()
        {
            return this.JsonReader(new JsonReader());
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonReader.Builder JsonReader(JsonReader component)
        {
            return new JsonReader.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonReader.Builder JsonReader(JsonReader.Config config)
        {
            return new JsonReader.Builder(new JsonReader(config));
        }
    }
}
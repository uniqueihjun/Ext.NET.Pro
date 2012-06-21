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
    public partial class JsonReader
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractReader.Builder<JsonReader, JsonReader.Builder>
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
			/// The optional location within the JSON response that the record data itself can be found at. See the JsonReader intro docs for more details. This is not often needed and defaults to undefined.
			/// </summary>
            public virtual JsonReader.Builder Record(string record)
            {
                this.ToComponent().Record = record;
                return this as JsonReader.Builder;
            }
             
 			/// <summary>
			/// True to ensure that field names/mappings are treated as literals when reading values. Defalts to false. For example, by default, using the mapping \"foo.bar.baz\" will try and read a property foo from the root, then a property bar from foo, then a property baz from bar. Setting the simple accessors to true will read the property with the name \"foo.bar.baz\" direct from the root object.
			/// </summary>
            public virtual JsonReader.Builder UseSimpleAccessors(bool useSimpleAccessors)
            {
                this.ToComponent().UseSimpleAccessors = useSimpleAccessors;
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
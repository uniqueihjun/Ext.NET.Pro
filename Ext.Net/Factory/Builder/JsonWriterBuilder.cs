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
    public partial class JsonWriter
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractWriter.Builder<JsonWriter, JsonWriter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new JsonWriter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(JsonWriter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(JsonWriter.Config config) : base(new JsonWriter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(JsonWriter component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The key under which the records in this Writer will be placed. Defaults to undefined.
			/// </summary>
            public virtual JsonWriter.Builder Root(string root)
            {
                this.ToComponent().Root = root;
                return this as JsonWriter.Builder;
            }
             
 			/// <summary>
			/// True to use Ext.encode() on the data before sending. Defaults to false.
			/// </summary>
            public virtual JsonWriter.Builder Encode(bool encode)
            {
                this.ToComponent().Encode = encode;
                return this as JsonWriter.Builder;
            }
             
 			/// <summary>
			/// False to ensure that records are always wrapped in an array, even if there is only one record being sent. When there is more than one record, they will always be encoded into an array.
			/// </summary>
            public virtual JsonWriter.Builder AllowSingle(bool allowSingle)
            {
                this.ToComponent().AllowSingle = allowSingle;
                return this as JsonWriter.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonWriter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.JsonWriter(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public JsonWriter.Builder JsonWriter()
        {
            return this.JsonWriter(new JsonWriter());
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonWriter.Builder JsonWriter(JsonWriter component)
        {
            return new JsonWriter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonWriter.Builder JsonWriter(JsonWriter.Config config)
        {
            return new JsonWriter.Builder(new JsonWriter(config));
        }
    }
}
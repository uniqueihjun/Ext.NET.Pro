/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class ArrayReader
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : JsonReader.Builder<ArrayReader, ArrayReader.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ArrayReader()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ArrayReader component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ArrayReader.Config config) : base(new ArrayReader(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ArrayReader component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ArrayReader.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ArrayReader(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ArrayReader.Builder ArrayReader()
        {
            return this.ArrayReader(new ArrayReader());
        }

        /// <summary>
        /// 
        /// </summary>
        public ArrayReader.Builder ArrayReader(ArrayReader component)
        {
            return new ArrayReader.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ArrayReader.Builder ArrayReader(ArrayReader.Config config)
        {
            return new ArrayReader.Builder(new ArrayReader(config));
        }
    }
}
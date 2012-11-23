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
    public partial class GenericComponent<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Component.Builder<GenericComponent<T>, GenericComponent<T>.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GenericComponent<T>()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GenericComponent<T> component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GenericComponent<T>.Config config) : base(new GenericComponent<T>(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GenericComponent<T> component)
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
        public GenericComponent<T>.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GenericComponent<T>(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GenericComponent<T>.Builder GenericComponent<T>()
        {
            return this.GenericComponent<T>(new GenericComponent<T>());
        }

        /// <summary>
        /// 
        /// </summary>
        public GenericComponent<T>.Builder GenericComponent<T>(GenericComponent<T> component)
        {
            return new GenericComponent<T>.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GenericComponent<T>.Builder GenericComponent<T>(GenericComponent<T>.Config config)
        {
            return new GenericComponent<T>.Builder(new GenericComponent<T>(config));
        }
    }
}
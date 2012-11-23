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
    public partial class HBoxLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BoxLayout.Builder<HBoxLayout, HBoxLayout.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HBoxLayout()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HBoxLayout component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HBoxLayout.Config config) : base(new HBoxLayout(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HBoxLayout component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Controls how the child items of the container are aligned.
			/// </summary>
            public virtual HBoxLayout.Builder Align(HBoxAlign align)
            {
                this.ToComponent().Align = align;
                return this as HBoxLayout.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public HBoxLayout.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HBoxLayout(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public HBoxLayout.Builder HBoxLayout()
        {
            return this.HBoxLayout(new HBoxLayout());
        }

        /// <summary>
        /// 
        /// </summary>
        public HBoxLayout.Builder HBoxLayout(HBoxLayout component)
        {
            return new HBoxLayout.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HBoxLayout.Builder HBoxLayout(HBoxLayout.Config config)
        {
            return new HBoxLayout.Builder(new HBoxLayout(config));
        }
    }
}
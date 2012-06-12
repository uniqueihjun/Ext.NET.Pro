/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class VBoxLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BoxLayout.Builder<VBoxLayout, VBoxLayout.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new VBoxLayout()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(VBoxLayout component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(VBoxLayout.Config config) : base(new VBoxLayout(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(VBoxLayout component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Controls how the child items of the container are aligned.
			/// </summary>
            public virtual VBoxLayout.Builder Align(VBoxAlign align)
            {
                this.ToComponent().Align = align;
                return this as VBoxLayout.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public VBoxLayout.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.VBoxLayout(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public VBoxLayout.Builder VBoxLayout()
        {
            return this.VBoxLayout(new VBoxLayout());
        }

        /// <summary>
        /// 
        /// </summary>
        public VBoxLayout.Builder VBoxLayout(VBoxLayout component)
        {
            return new VBoxLayout.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public VBoxLayout.Builder VBoxLayout(VBoxLayout.Config config)
        {
            return new VBoxLayout.Builder(new VBoxLayout(config));
        }
    }
}
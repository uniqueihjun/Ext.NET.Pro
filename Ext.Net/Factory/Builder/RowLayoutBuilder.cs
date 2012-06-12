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
    public partial class RowLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ContainerLayout.Builder<RowLayout, RowLayout.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RowLayout()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowLayout component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowLayout.Config config) : base(new RowLayout(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RowLayout component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to fill background by predefined color. Defaults to false.
			/// </summary>
            public virtual RowLayout.Builder Background(bool background)
            {
                this.ToComponent().Background = background;
                return this as RowLayout.Builder;
            }
             
 			/// <summary>
			/// True to allow resizing of the columns using a SplitBar. Defaults to false.
			/// </summary>
            public virtual RowLayout.Builder Split(bool split)
            {
                this.ToComponent().Split = split;
                return this as RowLayout.Builder;
            }
             
 			/// <summary>
			/// Width of margin between columns in pixels. Overrides any style settings. Defaults to 0.
			/// </summary>
            public virtual RowLayout.Builder Margin(int margin)
            {
                this.ToComponent().Margin = margin;
                return this as RowLayout.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RowLayout.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RowLayout(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RowLayout.Builder RowLayout()
        {
            return this.RowLayout(new RowLayout());
        }

        /// <summary>
        /// 
        /// </summary>
        public RowLayout.Builder RowLayout(RowLayout component)
        {
            return new RowLayout.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RowLayout.Builder RowLayout(RowLayout.Config config)
        {
            return new RowLayout.Builder(new RowLayout(config));
        }
    }
}
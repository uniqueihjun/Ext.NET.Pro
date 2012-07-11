/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class DrawBackground
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<DrawBackground, DrawBackground.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DrawBackground()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DrawBackground component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DrawBackground.Config config) : base(new DrawBackground(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DrawBackground component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The fill color
			/// </summary>
            public virtual DrawBackground.Builder Fill(string fill)
            {
                this.ToComponent().Fill = fill;
                return this as DrawBackground.Builder;
            }
             
 			/// <summary>
			/// The background image
			/// </summary>
            public virtual DrawBackground.Builder Image(string image)
            {
                this.ToComponent().Image = image;
                return this as DrawBackground.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DrawBackground.Builder Gradient(Gradient gradient)
            {
                this.ToComponent().Gradient = gradient;
                return this as DrawBackground.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawBackground.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DrawBackground(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DrawBackground.Builder DrawBackground()
        {
            return this.DrawBackground(new DrawBackground());
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawBackground.Builder DrawBackground(DrawBackground component)
        {
            return new DrawBackground.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawBackground.Builder DrawBackground(DrawBackground.Config config)
        {
            return new DrawBackground.Builder(new DrawBackground(config));
        }
    }
}
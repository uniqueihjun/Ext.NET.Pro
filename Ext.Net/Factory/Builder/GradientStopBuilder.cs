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
    public partial class GradientStop
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<GradientStop, GradientStop.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GradientStop()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GradientStop component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GradientStop.Config config) : base(new GradientStop(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GradientStop component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// (from 0 to 100)
			/// </summary>
            public virtual GradientStop.Builder Offset(int offset)
            {
                this.ToComponent().Offset = offset;
                return this as GradientStop.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual GradientStop.Builder Color(string color)
            {
                this.ToComponent().Color = color;
                return this as GradientStop.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual GradientStop.Builder Opacity(double opacity)
            {
                this.ToComponent().Opacity = opacity;
                return this as GradientStop.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GradientStop.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GradientStop(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GradientStop.Builder GradientStop()
        {
            return this.GradientStop(new GradientStop());
        }

        /// <summary>
        /// 
        /// </summary>
        public GradientStop.Builder GradientStop(GradientStop component)
        {
            return new GradientStop.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GradientStop.Builder GradientStop(GradientStop.Config config)
        {
            return new GradientStop.Builder(new GradientStop(config));
        }
    }
}
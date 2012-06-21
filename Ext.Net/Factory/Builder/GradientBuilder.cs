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
    public partial class Gradient
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<Gradient, Gradient.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Gradient()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Gradient component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Gradient.Config config) : base(new Gradient(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Gradient component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The unique name of the gradient.
			/// </summary>
            public virtual Gradient.Builder GradientID(string gradientID)
            {
                this.ToComponent().GradientID = gradientID;
                return this as Gradient.Builder;
            }
             
 			/// <summary>
			/// The angle of the gradient in degrees.
			/// </summary>
            public virtual Gradient.Builder Angle(int angle)
            {
                this.ToComponent().Angle = angle;
                return this as Gradient.Builder;
            }
             
 			/// <summary>
			/// An object with numbers as keys (from 0 to 100) and style objects as values
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Gradient.Builder</returns>
            public virtual Gradient.Builder Stops(Action<GradientStops> action)
            {
                action(this.ToComponent().Stops);
                return this as Gradient.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Gradient.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Gradient(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Gradient.Builder Gradient()
        {
            return this.Gradient(new Gradient());
        }

        /// <summary>
        /// 
        /// </summary>
        public Gradient.Builder Gradient(Gradient component)
        {
            return new Gradient.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Gradient.Builder Gradient(Gradient.Config config)
        {
            return new Gradient.Builder(new Gradient(config));
        }
    }
}
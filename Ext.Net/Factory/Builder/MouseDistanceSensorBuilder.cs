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
    public partial class MouseDistanceSensor
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<MouseDistanceSensor, MouseDistanceSensor.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MouseDistanceSensor()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MouseDistanceSensor component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MouseDistanceSensor.Config config) : base(new MouseDistanceSensor(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MouseDistanceSensor component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual MouseDistanceSensor.Builder Threshold(int threshold)
            {
                this.ToComponent().Threshold = threshold;
                return this as MouseDistanceSensor.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual MouseDistanceSensor.Builder Opacity(bool opacity)
            {
                this.ToComponent().Opacity = opacity;
                return this as MouseDistanceSensor.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual MouseDistanceSensor.Builder MinOpacity(decimal minOpacity)
            {
                this.ToComponent().MinOpacity = minOpacity;
                return this as MouseDistanceSensor.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual MouseDistanceSensor.Builder MaxOpacity(decimal maxOpacity)
            {
                this.ToComponent().MaxOpacity = maxOpacity;
                return this as MouseDistanceSensor.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual MouseDistanceSensor.Builder SensorElement(string sensorElement)
            {
                this.ToComponent().SensorElement = sensorElement;
                return this as MouseDistanceSensor.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual MouseDistanceSensor.Builder ConstrainElement(string constrainElement)
            {
                this.ToComponent().ConstrainElement = constrainElement;
                return this as MouseDistanceSensor.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public MouseDistanceSensor.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MouseDistanceSensor(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public MouseDistanceSensor.Builder MouseDistanceSensor()
        {
            return this.MouseDistanceSensor(new MouseDistanceSensor());
        }

        /// <summary>
        /// 
        /// </summary>
        public MouseDistanceSensor.Builder MouseDistanceSensor(MouseDistanceSensor component)
        {
            return new MouseDistanceSensor.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MouseDistanceSensor.Builder MouseDistanceSensor(MouseDistanceSensor.Config config)
        {
            return new MouseDistanceSensor.Builder(new MouseDistanceSensor(config));
        }
    }
}
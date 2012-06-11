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
    public partial class RadialAxis
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractAxis.Builder<RadialAxis, RadialAxis.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RadialAxis()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadialAxis component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadialAxis.Config config) : base(new RadialAxis(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RadialAxis component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual RadialAxis.Builder Steps(int steps)
            {
                this.ToComponent().Steps = steps;
                return this as RadialAxis.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RadialAxis.Builder Maximum(int maximum)
            {
                this.ToComponent().Maximum = maximum;
                return this as RadialAxis.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RadialAxis(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder RadialAxis()
        {
            return this.RadialAxis(new RadialAxis());
        }

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder RadialAxis(RadialAxis component)
        {
            return new RadialAxis.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder RadialAxis(RadialAxis.Config config)
        {
            return new RadialAxis.Builder(new RadialAxis(config));
        }
    }
}
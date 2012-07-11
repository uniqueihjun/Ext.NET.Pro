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
    public partial class ScatterSeries
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CartesianSeries.Builder<ScatterSeries, ScatterSeries.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ScatterSeries()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ScatterSeries component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ScatterSeries.Config config) : base(new ScatterSeries(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ScatterSeries component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual ScatterSeries.Builder MarkerConfig(SpriteAttributes markerConfig)
            {
                this.ToComponent().MarkerConfig = markerConfig;
                return this as ScatterSeries.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ScatterSeries.Builder Style(SpriteAttributes style)
            {
                this.ToComponent().Style = style;
                return this as ScatterSeries.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ScatterSeries.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ScatterSeries(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ScatterSeries.Builder ScatterSeries()
        {
            return this.ScatterSeries(new ScatterSeries());
        }

        /// <summary>
        /// 
        /// </summary>
        public ScatterSeries.Builder ScatterSeries(ScatterSeries component)
        {
            return new ScatterSeries.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ScatterSeries.Builder ScatterSeries(ScatterSeries.Config config)
        {
            return new ScatterSeries.Builder(new ScatterSeries(config));
        }
    }
}
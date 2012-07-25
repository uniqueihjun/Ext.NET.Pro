/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class AreaSeries
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CartesianSeries.Builder<AreaSeries, AreaSeries.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new AreaSeries()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AreaSeries component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AreaSeries.Config config) : base(new AreaSeries(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(AreaSeries component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual AreaSeries.Builder Style(SpriteAttributes style)
            {
                this.ToComponent().Style = style;
                return this as AreaSeries.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public AreaSeries.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.AreaSeries(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public AreaSeries.Builder AreaSeries()
        {
            return this.AreaSeries(new AreaSeries());
        }

        /// <summary>
        /// 
        /// </summary>
        public AreaSeries.Builder AreaSeries(AreaSeries component)
        {
            return new AreaSeries.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public AreaSeries.Builder AreaSeries(AreaSeries.Config config)
        {
            return new AreaSeries.Builder(new AreaSeries(config));
        }
    }
}
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
    public partial class AxisLabel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : SpriteAttributes.Builder<AxisLabel, AxisLabel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new AxisLabel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AxisLabel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AxisLabel.Config config) : base(new AxisLabel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(AxisLabel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of AxisLabel.Builder</returns>
            public virtual AxisLabel.Builder Renderer(Action<JFunction> action)
            {
                action(this.ToComponent().Renderer);
                return this as AxisLabel.Builder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual AxisLabel.Builder Padding(int? padding)
            {
                this.ToComponent().Padding = padding;
                return this as AxisLabel.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public AxisLabel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.AxisLabel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public AxisLabel.Builder AxisLabel()
        {
            return this.AxisLabel(new AxisLabel());
        }

        /// <summary>
        /// 
        /// </summary>
        public AxisLabel.Builder AxisLabel(AxisLabel component)
        {
            return new AxisLabel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public AxisLabel.Builder AxisLabel(AxisLabel.Config config)
        {
            return new AxisLabel.Builder(new AxisLabel(config));
        }
    }
}
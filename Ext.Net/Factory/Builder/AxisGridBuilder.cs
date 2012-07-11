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
    public partial class AxisGrid
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<AxisGrid, AxisGrid.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new AxisGrid()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AxisGrid component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AxisGrid.Config config) : base(new AxisGrid(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(AxisGrid component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual AxisGrid.Builder Odd(SpriteAttributes odd)
            {
                this.ToComponent().Odd = odd;
                return this as AxisGrid.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual AxisGrid.Builder Even(SpriteAttributes even)
            {
                this.ToComponent().Even = even;
                return this as AxisGrid.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public AxisGrid.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.AxisGrid(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public AxisGrid.Builder AxisGrid()
        {
            return this.AxisGrid(new AxisGrid());
        }

        /// <summary>
        /// 
        /// </summary>
        public AxisGrid.Builder AxisGrid(AxisGrid component)
        {
            return new AxisGrid.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public AxisGrid.Builder AxisGrid(AxisGrid.Config config)
        {
            return new AxisGrid.Builder(new AxisGrid(config));
        }
    }
}
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
    public partial class PropertyGrid
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridPanelBase.Builder<PropertyGrid, PropertyGrid.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new PropertyGrid()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PropertyGrid component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PropertyGrid.Config config) : base(new PropertyGrid(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(PropertyGrid component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A data object to use as the data source of the grid.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of PropertyGrid.Builder</returns>
            public virtual PropertyGrid.Builder Source(Action<PropertyGridParameterCollection> action)
            {
                action(this.ToComponent().Source);
                return this as PropertyGrid.Builder;
            }
			 
 			/// <summary>
			/// If false then all cells will be read only
			/// </summary>
            public virtual PropertyGrid.Builder Editable(bool editable)
            {
                this.ToComponent().Editable = editable;
                return this as PropertyGrid.Builder;
            }
             
 			/// <summary>
			/// Optional. Specify the width for the name column. The value column will take any remaining space. Defaults to 115.
			/// </summary>
            public virtual PropertyGrid.Builder NameColumnWidth(int nameColumnWidth)
            {
                this.ToComponent().NameColumnWidth = nameColumnWidth;
                return this as PropertyGrid.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of PropertyGrid.Builder</returns>
            public virtual PropertyGrid.Builder Listeners(Action<PropertyGridListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as PropertyGrid.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of PropertyGrid.Builder</returns>
            public virtual PropertyGrid.Builder DirectEvents(Action<PropertyGridDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as PropertyGrid.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public PropertyGrid.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.PropertyGrid(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public PropertyGrid.Builder PropertyGrid()
        {
            return this.PropertyGrid(new PropertyGrid());
        }

        /// <summary>
        /// 
        /// </summary>
        public PropertyGrid.Builder PropertyGrid(PropertyGrid component)
        {
            return new PropertyGrid.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public PropertyGrid.Builder PropertyGrid(PropertyGrid.Config config)
        {
            return new PropertyGrid.Builder(new PropertyGrid(config));
        }
    }
}
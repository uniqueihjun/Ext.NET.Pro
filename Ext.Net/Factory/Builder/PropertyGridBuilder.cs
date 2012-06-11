/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
			 
 			// /// <summary>
			// /// A data object to use as the data source of the grid.
			// /// </summary>
            // public virtual TBuilder Source(PropertyGridParameterCollection source)
            // {
            //    this.ToComponent().Source = source;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// If false then all cells will be read only
			/// </summary>
            public virtual PropertyGrid.Builder Editable(bool editable)
            {
                this.ToComponent().Editable = editable;
                return this as PropertyGrid.Builder;
            }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(PropertyGridListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(PropertyGridDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

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
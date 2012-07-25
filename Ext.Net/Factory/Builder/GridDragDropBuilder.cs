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
    public partial class GridDragDrop
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<GridDragDrop, GridDragDrop.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GridDragDrop()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridDragDrop component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridDragDrop.Config config) : base(new GridDragDrop(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GridDragDrop component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A named drag drop group to which this object belongs. If a group is specified, then both the DragZones and DropZone used by this plugin will only interact with other drag drop objects in the same group (defaults to 'GridDD').
			/// </summary>
            public virtual GridDragDrop.Builder DDGroup(string dDGroup)
            {
                this.ToComponent().DDGroup = dDGroup;
                return this as GridDragDrop.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual GridDragDrop.Builder DragText(string dragText)
            {
                this.ToComponent().DragText = dragText;
                return this as GridDragDrop.Builder;
            }
             
 			/// <summary>
			/// The ddGroup to which the DragZone will belong. This defines which other DropZones the DragZone will interact with. Drag/DropZones only interact with other Drag/DropZones which are members of the same ddGroup.
			/// </summary>
            public virtual GridDragDrop.Builder DragGroup(string dragGroup)
            {
                this.ToComponent().DragGroup = dragGroup;
                return this as GridDragDrop.Builder;
            }
             
 			/// <summary>
			/// The ddGroup to which the DropZone will belong. This defines which other DragZones the DropZone will interact with. Drag/DropZones only interact with other Drag/DropZones which are members of the same ddGroup.
			/// </summary>
            public virtual GridDragDrop.Builder DropGroup(string dropGroup)
            {
                this.ToComponent().DropGroup = dropGroup;
                return this as GridDragDrop.Builder;
            }
             
 			/// <summary>
			/// Defaults to true. Set to false to disallow dragging items from the View
			/// </summary>
            public virtual GridDragDrop.Builder EnableDrag(bool enableDrag)
            {
                this.ToComponent().EnableDrag = enableDrag;
                return this as GridDragDrop.Builder;
            }
             
 			/// <summary>
			/// Defaults to true. Set to false to disallow the View from accepting drop gestures
			/// </summary>
            public virtual GridDragDrop.Builder EnableDrop(bool enableDrop)
            {
                this.ToComponent().EnableDrop = enableDrop;
                return this as GridDragDrop.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GridDragDrop.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GridDragDrop(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GridDragDrop.Builder GridDragDrop()
        {
            return this.GridDragDrop(new GridDragDrop());
        }

        /// <summary>
        /// 
        /// </summary>
        public GridDragDrop.Builder GridDragDrop(GridDragDrop component)
        {
            return new GridDragDrop.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GridDragDrop.Builder GridDragDrop(GridDragDrop.Config config)
        {
            return new GridDragDrop.Builder(new GridDragDrop(config));
        }
    }
}
/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
        new public abstract partial class Builder<TGridDragDrop, TBuilder> : Plugin.Builder<TGridDragDrop, TBuilder>
            where TGridDragDrop : GridDragDrop
            where TBuilder : Builder<TGridDragDrop, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TGridDragDrop component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A named drag drop group to which this object belongs. If a group is specified, then both the DragZones and DropZone used by this plugin will only interact with other drag drop objects in the same group (defaults to 'GridDD').
			/// </summary>
            public virtual TBuilder DDGroup(string dDGroup)
            {
                this.ToComponent().DDGroup = dDGroup;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DragText(string dragText)
            {
                this.ToComponent().DragText = dragText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The ddGroup to which the DragZone will belong. This defines which other DropZones the DragZone will interact with. Drag/DropZones only interact with other Drag/DropZones which are members of the same ddGroup.
			/// </summary>
            public virtual TBuilder DragGroup(string dragGroup)
            {
                this.ToComponent().DragGroup = dragGroup;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The ddGroup to which the DropZone will belong. This defines which other DragZones the DropZone will interact with. Drag/DropZones only interact with other Drag/DropZones which are members of the same ddGroup.
			/// </summary>
            public virtual TBuilder DropGroup(string dropGroup)
            {
                this.ToComponent().DropGroup = dropGroup;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Defaults to true. Set to false to disallow dragging items from the View
			/// </summary>
            public virtual TBuilder EnableDrag(bool enableDrag)
            {
                this.ToComponent().EnableDrag = enableDrag;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to register this container with the Scrollmanager for auto scrolling during drag operations.
			/// </summary>
            public virtual TBuilder ContainerScroll(bool containerScroll)
            {
                this.ToComponent().ContainerScroll = containerScroll;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Defaults to true. Set to false to disallow the View from accepting drop gestures
			/// </summary>
            public virtual TBuilder EnableDrop(bool enableDrop)
            {
                this.ToComponent().EnableDrop = enableDrop;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridDragDrop.Builder<GridDragDrop, GridDragDrop.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public GridDragDrop.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GridDragDrop(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.GridDragDrop(new GridDragDrop { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.GridDragDrop(new GridDragDrop());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public GridDragDrop.Builder GridDragDrop(GridDragDrop component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new GridDragDrop.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GridDragDrop.Builder GridDragDrop(GridDragDrop.Config config)
        {
#if MVC
			return new GridDragDrop.Builder(new GridDragDrop(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new GridDragDrop.Builder(new GridDragDrop(config));
#endif			
        }
    }
}
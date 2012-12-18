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
    public partial class TreeViewDragDrop
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTreeViewDragDrop, TBuilder> : Plugin.Builder<TTreeViewDragDrop, TBuilder>
            where TTreeViewDragDrop : TreeViewDragDrop
            where TBuilder : Builder<TTreeViewDragDrop, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTreeViewDragDrop component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DragText(string dragText)
            {
                this.ToComponent().DragText = dragText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Allow inserting a dragged node between an expanded parent node and its first child that will become a sibling of the parent when dropped.
			/// </summary>
            public virtual TBuilder AllowParentInserts(bool allowParentInserts)
            {
                this.ToComponent().AllowParentInserts = allowParentInserts;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True if drops on the tree container (outside of a specific tree node) are allowed.
			/// </summary>
            public virtual TBuilder AllowContainerDrops(bool allowContainerDrops)
            {
                this.ToComponent().AllowContainerDrops = allowContainerDrops;
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
			/// A named drag drop group to which this object belongs. If a group is specified, then both the DragZones and DropZone used by this plugin will only interact with other drag drop objects in the same group. Defaults to: \"TreeDD\"
			/// </summary>
            public virtual TBuilder DDGroup(string dDGroup)
            {
                this.ToComponent().DDGroup = dDGroup;
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
			/// Set to false to disallow dragging items from the View. Defaults to: true
			/// </summary>
            public virtual TBuilder EnableDrag(bool enableDrag)
            {
                this.ToComponent().EnableDrag = enableDrag;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Set to false to disallow the View from accepting drop gestures. Defaults to: true
			/// </summary>
            public virtual TBuilder EnableDrop(bool enableDrop)
            {
                this.ToComponent().EnableDrop = enableDrop;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True if the tree should only allow append drops (use for trees which are sorted). Defaults to: false
			/// </summary>
            public virtual TBuilder AppendOnly(bool appendOnly)
            {
                this.ToComponent().AppendOnly = appendOnly;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The delay in milliseconds to wait before expanding a target tree node while dragging a droppable node over the target. Defaults to: 1000
			/// </summary>
            public virtual TBuilder ExpandDelay(int expandDelay)
            {
                this.ToComponent().ExpandDelay = expandDelay;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The color to use when visually highlighting the dragged or dropped node (default value is light blue). The color must be a 6 digit hex value, without a preceding '#'. See also nodeHighlightOnDrop and nodeHighlightOnRepair. Defaults to: \"c3daf9\"
			/// </summary>
            public virtual TBuilder NodeHighlightColor(string nodeHighlightColor)
            {
                this.ToComponent().NodeHighlightColor = nodeHighlightColor;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Whether or not to highlight any nodes after they are successfully dropped on their target. Defaults to the value of Ext.enableFx. See also nodeHighlightColor and nodeHighlightOnRepair.
			/// </summary>
            public virtual TBuilder NodeHighlightOnDrop(bool nodeHighlightOnDrop)
            {
                this.ToComponent().NodeHighlightOnDrop = nodeHighlightOnDrop;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Whether or not to highlight any nodes after they are repaired from an unsuccessful drag/drop. Defaults to the value of Ext.enableFx. See also nodeHighlightColor and nodeHighlightOnDrop.
			/// </summary>
            public virtual TBuilder NodeHighlightOnRepair(bool nodeHighlightOnRepair)
            {
                this.ToComponent().NodeHighlightOnRepair = nodeHighlightOnRepair;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// true to allow append to the leaf node
			/// </summary>
            public virtual TBuilder AllowLeafDrop(bool allowLeafDrop)
            {
                this.ToComponent().AllowLeafDrop = allowLeafDrop;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : TreeViewDragDrop.Builder<TreeViewDragDrop, TreeViewDragDrop.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TreeViewDragDrop()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeViewDragDrop component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeViewDragDrop.Config config) : base(new TreeViewDragDrop(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TreeViewDragDrop component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeViewDragDrop.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreeViewDragDrop(this);
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
        public TreeViewDragDrop.Builder TreeViewDragDrop()
        {
#if MVC
			return this.TreeViewDragDrop(new TreeViewDragDrop { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.TreeViewDragDrop(new TreeViewDragDrop());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeViewDragDrop.Builder TreeViewDragDrop(TreeViewDragDrop component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new TreeViewDragDrop.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeViewDragDrop.Builder TreeViewDragDrop(TreeViewDragDrop.Config config)
        {
#if MVC
			return new TreeViewDragDrop.Builder(new TreeViewDragDrop(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new TreeViewDragDrop.Builder(new TreeViewDragDrop(config));
#endif			
        }
    }
}
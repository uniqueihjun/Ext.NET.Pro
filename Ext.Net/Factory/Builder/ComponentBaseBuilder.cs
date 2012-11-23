/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public abstract partial class ComponentBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TComponentBase, TBuilder> : AbstractComponent.Builder<TComponentBase, TBuilder>
            where TComponentBase : ComponentBase
            where TBuilder : Builder<TComponentBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TComponentBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// true to use overflow:'auto' on the components layout element and show scroll bars automatically when necessary, false to clip any overflowing content (defaults to false).
			/// </summary>
            public virtual TBuilder AutoScroll(bool autoScroll)
            {
                this.ToComponent().AutoScroll = autoScroll;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Allows the component to be dragged via the touch event.
			/// </summary>
            public virtual TBuilder Draggable(bool draggable)
            {
                this.ToComponent().Draggable = draggable;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Specify as true to make a floating AbstractComponent draggable using the AbstractComponent's encapsulating element as the drag handle.
			/// </summary>
            public virtual TBuilder DraggableConfig(ComponentDragger draggableConfig)
            {
                this.ToComponent().DraggableConfig = draggableConfig;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Specifies that if an immediate sibling Splitter is moved, the AbstractComponent on the other side is resized, and this AbstractComponent maintains its configured flex value.
			/// </summary>
            public virtual TBuilder MaintainFlex(bool maintainFlex)
            {
                this.ToComponent().MaintainFlex = maintainFlex;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Possible values are: * 'auto' to enable automatic horizontal scrollbar (overflow-x: 'auto'). * 'scroll' to always enable horizontal scrollbar (overflow-x: 'scroll'). The default is overflow-x: 'hidden'. This should not be combined with autoScroll.
			/// </summary>
            public virtual TBuilder OverflowX(Overflow overflowX)
            {
                this.ToComponent().OverflowX = overflowX;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Possible values are: * 'auto' to enable automatic vertical scrollbar (overflow-y: 'auto'). * 'scroll' to always enable vertical scrollbar (overflow-y: 'scroll'). The default is overflow-y: 'hidden'. This should not be combined with autoScroll.
			/// </summary>
            public virtual TBuilder OverflowY(Overflow overflowY)
            {
                this.ToComponent().OverflowY = overflowY;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Specify as true to apply a Resizer to this AbstractComponent after rendering.
			/// </summary>
            public virtual TBuilder Resizable(bool resizable)
            {
                this.ToComponent().Resizable = resizable;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Specify as a config object to apply a Resizer to this AbstractComponent after rendering.
			/// </summary>
            public virtual TBuilder ResizableConfig(Resizer resizableConfig)
            {
                this.ToComponent().ResizableConfig = resizableConfig;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A valid Ext.resizer.Resizer handles config string (defaults to 'all'). Only applies when resizable = true.
			/// </summary>
            public virtual TBuilder ResizeHandles(ResizeHandle resizeHandles)
            {
                this.ToComponent().ResizeHandles = resizeHandles;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to automatically call toFront when the show method is called on an already visible, floating component (default is true).
			/// </summary>
            public virtual TBuilder ToFrontOnShow(bool toFrontOnShow)
            {
                this.ToComponent().ToFrontOnShow = toFrontOnShow;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Bubble(string function)
            {
                this.ToComponent().Bubble(function);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Bubble(string function, string scope)
            {
                this.ToComponent().Bubble(function, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Bubbles up the component/container heirarchy, calling the specified function with each component. The scope (this) of function call will be the scope provided or the current component. The arguments to the function will be the args provided or the current component. If the function returns false at any point, the bubble is stopped.
			/// </summary>
            public virtual TBuilder Bubble(string function, string scope, object[] args)
            {
                this.ToComponent().Bubble(function, scope, args);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Focus()
            {
                this.ToComponent().Focus();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Focus(bool selectText)
            {
                this.ToComponent().Focus(selectText);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Focus(bool selectText, int delay)
            {
                this.ToComponent().Focus(selectText, delay);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Hide()
            {
                this.ToComponent().Hide();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Hide(string animateTarget)
            {
                this.ToComponent().Hide(animateTarget);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Hide(ComponentBase animateTarget)
            {
                this.ToComponent().Hide(animateTarget);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Hide(ComponentBase animateTarget, string callback)
            {
                this.ToComponent().Hide(animateTarget, callback);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Hide(ComponentBase animateTarget, JFunction callback)
            {
                this.ToComponent().Hide(animateTarget, callback);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetAutoScroll(bool scroll)
            {
                this.ToComponent().SetAutoScroll(scroll);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetPagePosition(int x, int y)
            {
                this.ToComponent().SetPagePosition(x, y);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetPagePosition(int x, int y, AnimConfig animate)
            {
                this.ToComponent().SetPagePosition(x, y, animate);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetPagePosition(int x, int y, int animate)
            {
                this.ToComponent().SetPagePosition(x, y, animate);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetPosition(int x, int y)
            {
                this.ToComponent().SetPosition(x, y);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetPosition(int x, int y, AnimConfig animate)
            {
                this.ToComponent().SetPosition(x, y, animate);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetPosition(int x, int y, bool animate)
            {
                this.ToComponent().SetPosition(x, y, animate);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Show()
            {
                this.ToComponent().Show();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Show(string animTarget)
            {
                this.ToComponent().Show(animTarget);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Show(string animTarget, string callback)
            {
                this.ToComponent().Show(animTarget, callback);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Show(string animTarget, JFunction callback)
            {
                this.ToComponent().Show(animTarget, callback);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Show(string animTarget, string callback, string scope)
            {
                this.ToComponent().Show(animTarget, callback, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder UpdateBox(Unit x, Unit y, Unit width, Unit height)
            {
                this.ToComponent().UpdateBox(x, y, width, height);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder UpdateBox(int x, int y, int width, int height)
            {
                this.ToComponent().UpdateBox(x, y, width, height);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetLoading(LoadMask load, bool targetEl)
            {
                this.ToComponent().SetLoading(load, targetEl);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetLoading(LoadMask load)
            {
                this.ToComponent().SetLoading(load);
                return this as TBuilder;
            }
            
        }        
    }
}
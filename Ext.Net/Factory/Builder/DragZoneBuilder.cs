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
    public partial class DragZone
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDragZone, TBuilder> : DragSource.Builder<TDragZone, TBuilder>
            where TDragZone : DragZone
            where TBuilder : Builder<TDragZone, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDragZone component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to register this container with the Scrollmanager for auto scrolling during drag operations.
			/// </summary>
            public virtual TBuilder ContainerScroll(bool containerScroll)
            {
                this.ToComponent().ContainerScroll = containerScroll;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Called after a repair of an invalid drop. By default, highlights this.dragData.ddel
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder AfterRepair(Action<JFunction> action)
            {
                action(this.ToComponent().AfterRepair);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Called before a repair of an invalid drop to get the XY to animate to. By default returns the XY of this.dragData.ddel
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GetRepairXY(Action<JFunction> action)
            {
                action(this.ToComponent().GetRepairXY);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Called once drag threshold has been reached to initialize the proxy element. By default, it clones the this.dragData.ddel
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder OnInitDrag(Action<JFunction> action)
            {
                action(this.ToComponent().OnInitDrag);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DragZone.Builder<DragZone, DragZone.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DragZone()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DragZone component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DragZone.Config config) : base(new DragZone(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DragZone component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DragZone.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DragZone(this);
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
        public DragZone.Builder DragZone()
        {
#if MVC
			return this.DragZone(new DragZone { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DragZone(new DragZone());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DragZone.Builder DragZone(DragZone component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DragZone.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DragZone.Builder DragZone(DragZone.Config config)
        {
#if MVC
			return new DragZone.Builder(new DragZone(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DragZone.Builder(new DragZone(config));
#endif			
        }
    }
}
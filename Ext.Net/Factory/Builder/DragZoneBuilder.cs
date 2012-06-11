/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
        public partial class Builder : DragSource.Builder<DragZone, DragZone.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to register this container with the Scrollmanager for auto scrolling during drag operations.
			/// </summary>
            public virtual DragZone.Builder ContainerScroll(bool containerScroll)
            {
                this.ToComponent().ContainerScroll = containerScroll;
                return this as DragZone.Builder;
            }
             
 			/// <summary>
			/// Called after a repair of an invalid drop. By default, highlights this.dragData.ddel
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DragZone.Builder</returns>
            public virtual DragZone.Builder AfterRepair(Action<JFunction> action)
            {
                action(this.ToComponent().AfterRepair);
                return this as DragZone.Builder;
            }
			 
 			/// <summary>
			/// Called before a repair of an invalid drop to get the XY to animate to. By default returns the XY of this.dragData.ddel
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DragZone.Builder</returns>
            public virtual DragZone.Builder GetRepairXY(Action<JFunction> action)
            {
                action(this.ToComponent().GetRepairXY);
                return this as DragZone.Builder;
            }
			 
 			/// <summary>
			/// Called once drag threshold has been reached to initialize the proxy element. By default, it clones the this.dragData.ddel
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DragZone.Builder</returns>
            public virtual DragZone.Builder OnInitDrag(Action<JFunction> action)
            {
                action(this.ToComponent().OnInitDrag);
                return this as DragZone.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DragZone.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DragZone(this);
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
            return this.DragZone(new DragZone());
        }

        /// <summary>
        /// 
        /// </summary>
        public DragZone.Builder DragZone(DragZone component)
        {
            return new DragZone.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DragZone.Builder DragZone(DragZone.Config config)
        {
            return new DragZone.Builder(new DragZone(config));
        }
    }
}
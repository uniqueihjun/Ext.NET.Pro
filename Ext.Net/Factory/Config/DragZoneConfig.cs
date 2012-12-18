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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DragZone(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DragZone.Config Conversion to DragZone
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DragZone(DragZone.Config config)
        {
            return new DragZone(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DragSource.Config 
        { 
			/*  Implicit DragZone.Config Conversion to DragZone.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DragZone.Builder(DragZone.Config config)
			{
				return new DragZone.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool containerScroll = false;

			/// <summary>
			/// True to register this container with the Scrollmanager for auto scrolling during drag operations.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ContainerScroll 
			{ 
				get
				{
					return this.containerScroll;
				}
				set
				{
					this.containerScroll = value;
				}
			}
        
			private JFunction afterRepair = null;

			/// <summary>
			/// Called after a repair of an invalid drop. By default, highlights this.dragData.ddel
			/// </summary>
			public JFunction AfterRepair
			{
				get
				{
					if (this.afterRepair == null)
					{
						this.afterRepair = new JFunction();
					}
			
					return this.afterRepair;
				}
			}
			        
			private JFunction getRepairXY = null;

			/// <summary>
			/// Called before a repair of an invalid drop to get the XY to animate to. By default returns the XY of this.dragData.ddel
			/// </summary>
			public JFunction GetRepairXY
			{
				get
				{
					if (this.getRepairXY == null)
					{
						this.getRepairXY = new JFunction();
					}
			
					return this.getRepairXY;
				}
			}
			        
			private JFunction onInitDrag = null;

			/// <summary>
			/// Called once drag threshold has been reached to initialize the proxy element. By default, it clones the this.dragData.ddel
			/// </summary>
			public JFunction OnInitDrag
			{
				get
				{
					if (this.onInitDrag == null)
					{
						this.onInitDrag = new JFunction();
					}
			
					return this.onInitDrag;
				}
			}
			
        }
    }
}
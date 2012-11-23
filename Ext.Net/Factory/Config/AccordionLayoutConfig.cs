/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class AccordionLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public AccordionLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit AccordionLayout.Config Conversion to AccordionLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AccordionLayout(AccordionLayout.Config config)
        {
            return new AccordionLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ContainerLayout.Config 
        { 
			/*  Implicit AccordionLayout.Config Conversion to AccordionLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator AccordionLayout.Builder(AccordionLayout.Config config)
			{
				return new AccordionLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool activeOnTop = false;

			/// <summary>
			/// True to swap the position of each panel as it is expanded so that it becomes the first items in the content Container, false to keep the panels in the rendered order. This is NOT compatible with 'animate:true' (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ActiveOnTop 
			{ 
				get
				{
					return this.activeOnTop;
				}
				set
				{
					this.activeOnTop = value;
				}
			}

			private bool originalHeader = false;

			/// <summary>
			/// If true then original header UI is used
			/// </summary>
			[DefaultValue(false)]
			public virtual bool OriginalHeader 
			{ 
				get
				{
					return this.originalHeader;
				}
				set
				{
					this.originalHeader = value;
				}
			}

			private bool animate = false;

			/// <summary>
			/// True to slide the contained panels open and closed during expand/collapse using animation, false to open and close directly with no animation (defaults to false). Note: to defer to the specific config setting of each contained panel for this property, set this to undefined at the layout level.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Animate 
			{ 
				get
				{
					return this.animate;
				}
				set
				{
					this.animate = value;
				}
			}

			private bool autoWidth = true;

			/// <summary>
			/// True to set each contained items's width to 'auto', false to use the items's current width (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool AutoWidth 
			{ 
				get
				{
					return this.autoWidth;
				}
				set
				{
					this.autoWidth = value;
				}
			}

			private bool collapseFirst = false;

			/// <summary>
			/// True to make sure the collapse/expand toggle button always renders first (to the left of) any other tools in the contained panels' title bars, false to render it last (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool CollapseFirst 
			{ 
				get
				{
					return this.collapseFirst;
				}
				set
				{
					this.collapseFirst = value;
				}
			}

			private bool fill = true;

			/// <summary>
			/// True to adjust the active items's height to fill the available space in the content Container, false to use the items's current height, or auto height if not explicitly set (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool Fill 
			{ 
				get
				{
					return this.fill;
				}
				set
				{
					this.fill = value;
				}
			}

			private bool hideCollapseTool = false;

			/// <summary>
			/// True to hide the contained panels' collapse/expand toggle buttons, false to display them (defaults to false). When set to true, titleCollapse should be true also.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideCollapseTool 
			{ 
				get
				{
					return this.hideCollapseTool;
				}
				set
				{
					this.hideCollapseTool = value;
				}
			}

			private bool sequence = false;

			/// <summary>
			/// Experimental. If animate is set to true, this will result in each animation running in sequence.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Sequence 
			{ 
				get
				{
					return this.sequence;
				}
				set
				{
					this.sequence = value;
				}
			}

			private bool titleCollapse = true;

			/// <summary>
			/// True to allow expand/collapse of each contained panel by clicking anywhere on the title bar, false to allow expand/collapse only when the toggle tool button is clicked (defaults to true). When set to false, hideCollapseTool should be false also.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool TitleCollapse 
			{ 
				get
				{
					return this.titleCollapse;
				}
				set
				{
					this.titleCollapse = value;
				}
			}

        }
    }
}
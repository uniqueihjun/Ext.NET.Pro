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
    public partial class BoxSplitter
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public BoxSplitter(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit BoxSplitter.Config Conversion to BoxSplitter
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BoxSplitter(BoxSplitter.Config config)
        {
            return new BoxSplitter(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractComponent.Config 
        { 
			/*  Implicit BoxSplitter.Config Conversion to BoxSplitter.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator BoxSplitter.Builder(BoxSplitter.Config config)
			{
				return new BoxSplitter.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool collapseOnDblClick = true;

			/// <summary>
			/// True to enable dblclick to toggle expand and collapse on the collapseTarget Panel. Defaults to: true
			/// </summary>
			[DefaultValue(true)]
			public virtual bool CollapseOnDblClick 
			{ 
				get
				{
					return this.collapseOnDblClick;
				}
				set
				{
					this.collapseOnDblClick = value;
				}
			}

			private CollapseTarget collapseTarget = CollapseTarget.Default;

			/// <summary>
			/// A string describing the relative position of the immediate sibling Panel to collapse.
			/// </summary>
			[DefaultValue(CollapseTarget.Default)]
			public virtual CollapseTarget CollapseTarget 
			{ 
				get
				{
					return this.collapseTarget;
				}
				set
				{
					this.collapseTarget = value;
				}
			}

			private string collapseTargetPanel = "";

			/// <summary>
			/// A string describing the relative position of the immediate sibling Panel to collapse.
			/// </summary>
			[DefaultValue("")]
			public virtual string CollapseTargetPanel 
			{ 
				get
				{
					return this.collapseTargetPanel;
				}
				set
				{
					this.collapseTargetPanel = value;
				}
			}

			private string collapsedCls = "";

			/// <summary>
			/// A class to add to the splitter when it is collapsed. See collapsible.
			/// </summary>
			[DefaultValue("")]
			public virtual string CollapsedCls 
			{ 
				get
				{
					return this.collapsedCls;
				}
				set
				{
					this.collapsedCls = value;
				}
			}

			private bool collapsible = false;

			/// <summary>
			/// True to show a mini-collapse tool in the Splitter to toggle expand and collapse on the collapseTarget Panel. Defaults to the collapsible setting of the Panel. Defaults to: false
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Collapsible 
			{ 
				get
				{
					return this.collapsible;
				}
				set
				{
					this.collapsible = value;
				}
			}

			private int defaultSplitMax = 1000;

			/// <summary>
			/// Provides a default maximum width or height for the two components that the splitter is between. Defaults to: 1000
			/// </summary>
			[DefaultValue(1000)]
			public virtual int DefaultSplitMax 
			{ 
				get
				{
					return this.defaultSplitMax;
				}
				set
				{
					this.defaultSplitMax = value;
				}
			}

			private int defaultSplitMin = 40;

			/// <summary>
			/// Provides a default minimum width or height for the two components that the splitter is between. Defaults to: 40
			/// </summary>
			[DefaultValue(40)]
			public virtual int DefaultSplitMin 
			{ 
				get
				{
					return this.defaultSplitMin;
				}
				set
				{
					this.defaultSplitMin = value;
				}
			}

			private bool performCollapse = true;

			/// <summary>
			/// Set to false to prevent this Splitter's mini-collapse tool from managing the collapse state of the collapseTarget.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool PerformCollapse 
			{ 
				get
				{
					return this.performCollapse;
				}
				set
				{
					this.performCollapse = value;
				}
			}

        }
    }
}
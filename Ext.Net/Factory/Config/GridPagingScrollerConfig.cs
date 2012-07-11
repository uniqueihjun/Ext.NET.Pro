/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class GridPagingScroller
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GridPagingScroller(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GridPagingScroller.Config Conversion to GridPagingScroller
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GridPagingScroller(GridPagingScroller.Config config)
        {
            return new GridPagingScroller(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridScroller.Config 
        { 
			/*  Implicit GridPagingScroller.Config Conversion to GridPagingScroller.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GridPagingScroller.Builder(GridPagingScroller.Config config)
			{
				return new GridPagingScroller.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int scrollToLoadBuffer = 200;

			/// <summary>
			/// This is the time in milliseconds to buffer load requests when scrolling the PagingScrollbar. Defaults to: 200
			/// </summary>
			[DefaultValue(200)]
			public virtual int ScrollToLoadBuffer 
			{ 
				get
				{
					return this.scrollToLoadBuffer;
				}
				set
				{
					this.scrollToLoadBuffer = value;
				}
			}

			private int numberFromEdge = 2;

			/// <summary>
			/// The zone which causes a refresh of the rendered viewport. As soon as the edge of the rendered grid is this number of rows from the edge of the viewport, the view is moved.
			/// </summary>
			[DefaultValue(2)]
			public virtual int NumberFromEdge 
			{ 
				get
				{
					return this.numberFromEdge;
				}
				set
				{
					this.numberFromEdge = value;
				}
			}

			private int trailingBufferZone = 5;

			/// <summary>
			/// The number of extra rows to render on the trailing side of scrolling outside the NumberFromEdge buffer as scrolling proceeds.
			/// </summary>
			[DefaultValue(5)]
			public virtual int TrailingBufferZone 
			{ 
				get
				{
					return this.trailingBufferZone;
				}
				set
				{
					this.trailingBufferZone = value;
				}
			}

			private int leadingBufferZone = 15;

			/// <summary>
			/// The number of extra rows to render on the leading side of scrolling outside the NumberFromEdge buffer as scrolling proceeds.
			/// </summary>
			[DefaultValue(15)]
			public virtual int LeadingBufferZone 
			{ 
				get
				{
					return this.leadingBufferZone;
				}
				set
				{
					this.leadingBufferZone = value;
				}
			}

			private bool variableRowHeight = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool VariableRowHeight 
			{ 
				get
				{
					return this.variableRowHeight;
				}
				set
				{
					this.variableRowHeight = value;
				}
			}

        }
    }
}
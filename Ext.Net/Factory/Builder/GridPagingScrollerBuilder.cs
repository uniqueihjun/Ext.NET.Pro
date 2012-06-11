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
    public partial class GridPagingScroller
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridScroller.Builder<GridPagingScroller, GridPagingScroller.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GridPagingScroller()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridPagingScroller component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridPagingScroller.Config config) : base(new GridPagingScroller(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GridPagingScroller component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// This is the time in milliseconds to buffer load requests when scrolling the PagingScrollbar. Defaults to: 200
			/// </summary>
            public virtual GridPagingScroller.Builder ScrollToLoadBuffer(int scrollToLoadBuffer)
            {
                this.ToComponent().ScrollToLoadBuffer = scrollToLoadBuffer;
                return this as GridPagingScroller.Builder;
            }
             
 			/// <summary>
			/// The zone which causes a refresh of the rendered viewport. As soon as the edge of the rendered grid is this number of rows from the edge of the viewport, the view is moved.
			/// </summary>
            public virtual GridPagingScroller.Builder NumberFromEdge(int numberFromEdge)
            {
                this.ToComponent().NumberFromEdge = numberFromEdge;
                return this as GridPagingScroller.Builder;
            }
             
 			/// <summary>
			/// The number of extra rows to render on the trailing side of scrolling outside the NumberFromEdge buffer as scrolling proceeds.
			/// </summary>
            public virtual GridPagingScroller.Builder TrailingBufferZone(int trailingBufferZone)
            {
                this.ToComponent().TrailingBufferZone = trailingBufferZone;
                return this as GridPagingScroller.Builder;
            }
             
 			/// <summary>
			/// The number of extra rows to render on the leading side of scrolling outside the NumberFromEdge buffer as scrolling proceeds.
			/// </summary>
            public virtual GridPagingScroller.Builder LeadingBufferZone(int leadingBufferZone)
            {
                this.ToComponent().LeadingBufferZone = leadingBufferZone;
                return this as GridPagingScroller.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual GridPagingScroller.Builder VariableRowHeight(bool variableRowHeight)
            {
                this.ToComponent().VariableRowHeight = variableRowHeight;
                return this as GridPagingScroller.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GridPagingScroller.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GridPagingScroller(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GridPagingScroller.Builder GridPagingScroller()
        {
            return this.GridPagingScroller(new GridPagingScroller());
        }

        /// <summary>
        /// 
        /// </summary>
        public GridPagingScroller.Builder GridPagingScroller(GridPagingScroller component)
        {
            return new GridPagingScroller.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GridPagingScroller.Builder GridPagingScroller(GridPagingScroller.Config config)
        {
            return new GridPagingScroller.Builder(new GridPagingScroller(config));
        }
    }
}
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
    public partial class BufferView
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridView.Builder<BufferView, BufferView.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new BufferView()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BufferView component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BufferView.Config config) : base(new BufferView(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(BufferView component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The height of a row in the grid.
			/// </summary>
            public virtual BufferView.Builder RowHeight(int rowHeight)
            {
                this.ToComponent().RowHeight = rowHeight;
                return this as BufferView.Builder;
            }
             
 			/// <summary>
			/// The combined height of border-top and border-bottom of a row.
			/// </summary>
            public virtual BufferView.Builder BorderHeight(int borderHeight)
            {
                this.ToComponent().BorderHeight = borderHeight;
                return this as BufferView.Builder;
            }
             
 			/// <summary>
			/// The number of milliseconds before rendering rows out of the visible viewing area. Defaults to 100. Rows will render immediately with a config of false.
			/// </summary>
            public virtual BufferView.Builder ScrollDelay(int scrollDelay)
            {
                this.ToComponent().ScrollDelay = scrollDelay;
                return this as BufferView.Builder;
            }
             
 			/// <summary>
			/// The number of rows to look forward and backwards from the currently viewable area.  The cache applies only to rows that have been rendered already.
			/// </summary>
            public virtual BufferView.Builder CacheSize(int cacheSize)
            {
                this.ToComponent().CacheSize = cacheSize;
                return this as BufferView.Builder;
            }
             
 			/// <summary>
			/// The number of milliseconds to buffer cleaning of extra rows not in the cache.
			/// </summary>
            public virtual BufferView.Builder CleanDelay(int cleanDelay)
            {
                this.ToComponent().CleanDelay = cleanDelay;
                return this as BufferView.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public BufferView.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.BufferView(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public BufferView.Builder BufferView()
        {
            return this.BufferView(new BufferView());
        }

        /// <summary>
        /// 
        /// </summary>
        public BufferView.Builder BufferView(BufferView component)
        {
            return new BufferView.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public BufferView.Builder BufferView(BufferView.Config config)
        {
            return new BufferView.Builder(new BufferView(config));
        }
    }
}
/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public BufferView(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit BufferView.Config Conversion to BufferView
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BufferView(BufferView.Config config)
        {
            return new BufferView(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridView.Config 
        { 
			/*  Implicit BufferView.Config Conversion to BufferView.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator BufferView.Builder(BufferView.Config config)
			{
				return new BufferView.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int rowHeight = 19;

			/// <summary>
			/// The height of a row in the grid.
			/// </summary>
			[DefaultValue(19)]
			public virtual int RowHeight 
			{ 
				get
				{
					return this.rowHeight;
				}
				set
				{
					this.rowHeight = value;
				}
			}

			private int borderHeight = 2;

			/// <summary>
			/// The combined height of border-top and border-bottom of a row.
			/// </summary>
			[DefaultValue(2)]
			public virtual int BorderHeight 
			{ 
				get
				{
					return this.borderHeight;
				}
				set
				{
					this.borderHeight = value;
				}
			}

			private int scrollDelay = 100;

			/// <summary>
			/// The number of milliseconds before rendering rows out of the visible viewing area. Defaults to 100. Rows will render immediately with a config of false.
			/// </summary>
			[DefaultValue(100)]
			public virtual int ScrollDelay 
			{ 
				get
				{
					return this.scrollDelay;
				}
				set
				{
					this.scrollDelay = value;
				}
			}

			private int cacheSize = 20;

			/// <summary>
			/// The number of rows to look forward and backwards from the currently viewable area.  The cache applies only to rows that have been rendered already.
			/// </summary>
			[DefaultValue(20)]
			public virtual int CacheSize 
			{ 
				get
				{
					return this.cacheSize;
				}
				set
				{
					this.cacheSize = value;
				}
			}

			private int cleanDelay = 500;

			/// <summary>
			/// The number of milliseconds to buffer cleaning of extra rows not in the cache.
			/// </summary>
			[DefaultValue(500)]
			public virtual int CleanDelay 
			{ 
				get
				{
					return this.cleanDelay;
				}
				set
				{
					this.cleanDelay = value;
				}
			}

        }
    }
}
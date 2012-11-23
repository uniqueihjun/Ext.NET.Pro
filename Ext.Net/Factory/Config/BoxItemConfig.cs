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
    public partial class BoxItem
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public BoxItem(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit BoxItem.Config Conversion to BoxItem
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BoxItem(BoxItem.Config config)
        {
            return new BoxItem(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : LayoutItem.Config 
        { 
			/*  Implicit BoxItem.Config Conversion to BoxItem.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator BoxItem.Builder(BoxItem.Config config)
			{
				return new BoxItem.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int flex = 0;

			/// <summary>
			/// This configuation option is to be applied to child items of the container managed by this layout. Each child item with a flex property will be flexed horizontally according to each item's relative flex value compared to the sum of all items with a flex value specified. Any child items that have either a flex = 0 or flex = undefined will not be 'flexed' (the initial size will not be changed).
			/// </summary>
			[DefaultValue(0)]
			public virtual int Flex 
			{ 
				get
				{
					return this.flex;
				}
				set
				{
					this.flex = value;
				}
			}

			private string margins = "";

			/// <summary>
			/// The margins from this property will be applied to the item.
			/// </summary>
			[DefaultValue("")]
			public virtual string Margins 
			{ 
				get
				{
					return this.margins;
				}
				set
				{
					this.margins = value;
				}
			}

        }
    }
}
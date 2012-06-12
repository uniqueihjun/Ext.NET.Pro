/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : LayoutItem.Builder<BoxItem, BoxItem.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new BoxItem()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BoxItem component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BoxItem.Config config) : base(new BoxItem(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(BoxItem component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// This configuation option is to be applied to child items of the container managed by this layout. Each child item with a flex property will be flexed horizontally according to each item's relative flex value compared to the sum of all items with a flex value specified. Any child items that have either a flex = 0 or flex = undefined will not be 'flexed' (the initial size will not be changed).
			/// </summary>
            public virtual BoxItem.Builder Flex(int flex)
            {
                this.ToComponent().Flex = flex;
                return this as BoxItem.Builder;
            }
             
 			/// <summary>
			/// The margins from this property will be applied to the item.
			/// </summary>
            public virtual BoxItem.Builder Margins(string margins)
            {
                this.ToComponent().Margins = margins;
                return this as BoxItem.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public BoxItem.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.BoxItem(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public BoxItem.Builder BoxItem()
        {
            return this.BoxItem(new BoxItem());
        }

        /// <summary>
        /// 
        /// </summary>
        public BoxItem.Builder BoxItem(BoxItem component)
        {
            return new BoxItem.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public BoxItem.Builder BoxItem(BoxItem.Config config)
        {
            return new BoxItem.Builder(new BoxItem(config));
        }
    }
}
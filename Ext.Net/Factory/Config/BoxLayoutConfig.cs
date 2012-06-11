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
    public abstract partial class BoxLayout
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : ContainerLayout.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string defaultMargins = "";

			/// <summary>
			/// The default margins from this property will be applied to each item.
			/// </summary>
			[DefaultValue("")]
			public virtual string DefaultMargins 
			{ 
				get
				{
					return this.defaultMargins;
				}
				set
				{
					this.defaultMargins = value;
				}
			}

			private string padding = "0";

			/// <summary>
			/// Defaults to '0'. Sets the padding to be applied to all child items managed by this container's layout.
			/// </summary>
			[DefaultValue("0")]
			public virtual string Padding 
			{ 
				get
				{
					return this.padding;
				}
				set
				{
					this.padding = value;
				}
			}

			private BoxPack pack = BoxPack.Start;

			/// <summary>
			/// Controls how the child items of the container are packed together.
			/// </summary>
			[DefaultValue(BoxPack.Start)]
			public virtual BoxPack Pack 
			{ 
				get
				{
					return this.pack;
				}
				set
				{
					this.pack = value;
				}
			}

			private int scrollOffset = 0;

			/// <summary>
			/// The amount of space to reserve for the scrollbar
			/// </summary>
			[DefaultValue(0)]
			public virtual int ScrollOffset 
			{ 
				get
				{
					return this.scrollOffset;
				}
				set
				{
					this.scrollOffset = value;
				}
			}
        
			private BoxItemCollection boxItems = null;

			/// <summary>
			/// Box items collection
			/// </summary>
			public BoxItemCollection BoxItems
			{
				get
				{
					if (this.boxItems == null)
					{
						this.boxItems = new BoxItemCollection();
					}
			
					return this.boxItems;
				}
			}
			
        }
    }
}
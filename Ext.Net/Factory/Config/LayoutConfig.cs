/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public abstract partial class Layout
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : Component.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string extraCls = "";

			/// <summary>
			/// An optional extra CSS class that will be added to the content Container (defaults to ''). This can be useful for adding customized styles to the content Container or any of its children using standard CSS rules.
			/// </summary>
			[DefaultValue("")]
			public virtual string ExtraCls 
			{ 
				get
				{
					return this.extraCls;
				}
				set
				{
					this.extraCls = value;
				}
			}

			private bool renderHidden = false;

			/// <summary>
			/// True to hide each contained items on render (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool RenderHidden 
			{ 
				get
				{
					return this.renderHidden;
				}
				set
				{
					this.renderHidden = value;
				}
			}
        
			private ItemsCollection<Component> items = null;

			/// <summary>
			/// Items collection
			/// </summary>
			public ItemsCollection<Component> Items
			{
				get
				{
					if (this.items == null)
					{
						this.items = new ItemsCollection<Component>();
					}
			
					return this.items;
				}
			}
			
        }
    }
}
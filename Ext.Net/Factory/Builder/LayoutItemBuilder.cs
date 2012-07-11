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
    public abstract partial class LayoutItem
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TLayoutItem, TBuilder> : StateManagedItem.Builder<TLayoutItem, TBuilder>
            where TLayoutItem : LayoutItem
            where TBuilder : Builder<TLayoutItem, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TLayoutItem component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Items
			// /// </summary>
            // public virtual TBuilder Items(ItemsCollection<Component> items)
            // {
            //    this.ToComponent().Items = items;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}
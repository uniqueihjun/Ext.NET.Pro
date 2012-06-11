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
    public abstract partial class Layout
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TLayout, TBuilder> : Component.Builder<TLayout, TBuilder>
            where TLayout : Layout
            where TBuilder : Builder<TLayout, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TLayout component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// An optional extra CSS class that will be added to the content Container (defaults to ''). This can be useful for adding customized styles to the content Container or any of its children using standard CSS rules.
			/// </summary>
            public virtual TBuilder ExtraCls(string extraCls)
            {
                this.ToComponent().ExtraCls = extraCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to hide each contained items on render (defaults to false).
			/// </summary>
            public virtual TBuilder RenderHidden(bool renderHidden)
            {
                this.ToComponent().RenderHidden = renderHidden;
                return this as TBuilder;
            }
             
 			// /// <summary>
			// /// Items collection
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
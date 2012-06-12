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
    public abstract partial class ToolbarItem
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TToolbarItem, TBuilder> : BoxComponentBase.Builder<TToolbarItem, TBuilder>
            where TToolbarItem : ToolbarItem
            where TBuilder : Builder<TToolbarItem, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TToolbarItem component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// Disable this component.
			/// </summary>
            public virtual TBuilder Disable()
            {
                this.ToComponent().Disable();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Enable this component.
			/// </summary>
            public virtual TBuilder Enable()
            {
                this.ToComponent().Enable();
                return this as TBuilder;
            }
            
        }        
    }
}
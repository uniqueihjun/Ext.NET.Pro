/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class ToolbarBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TToolbarBase, TBuilder> : AbstractContainer.Builder<TToolbarBase, TBuilder>
            where TToolbarBase : ToolbarBase
            where TBuilder : Builder<TToolbarBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TToolbarBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to use flat style.
			/// </summary>
            public virtual TBuilder Flat(bool flat)
            {
                this.ToComponent().Flat = flat;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to use classic (none-flat) style.
			/// </summary>
            public virtual TBuilder ClassicButtonStyle(bool classicButtonStyle)
            {
                this.ToComponent().ClassicButtonStyle = classicButtonStyle;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Configure true to make the toolbar provide a button which activates a dropdown Menu to show items which overflow the Toolbar's width.
			/// </summary>
            public virtual TBuilder EnableOverflow(bool enableOverflow)
            {
                this.ToComponent().EnableOverflow = enableOverflow;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Configure the icon class of the overflow button. Defaults to: \"x-toolbar-more-icon\"
			/// </summary>
            public virtual TBuilder MenuTriggerCls(string menuTriggerCls)
            {
                this.ToComponent().MenuTriggerCls = menuTriggerCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Set to true to make the toolbar vertical. The layout will become a vbox. Defaults to: false
			/// </summary>
            public virtual TBuilder Vertical(bool vertical)
            {
                this.ToComponent().Vertical = vertical;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}
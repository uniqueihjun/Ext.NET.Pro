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
    public abstract partial class SplitButtonBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TSplitButtonBase, TBuilder> : ButtonBase.Builder<TSplitButtonBase, TBuilder>
            where TSplitButtonBase : SplitButtonBase
            where TBuilder : Builder<TSplitButtonBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TSplitButtonBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A function called when the arrow button is clicked (can be used instead of click event).
			/// </summary>
            public virtual TBuilder ArrowHandler(string arrowHandler)
            {
                this.ToComponent().ArrowHandler = arrowHandler;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The title attribute of the arrow.
			/// </summary>
            public virtual TBuilder ArrowTooltip(string arrowTooltip)
            {
                this.ToComponent().ArrowTooltip = arrowTooltip;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}
/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public abstract partial class GridEditing
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TGridEditing, TBuilder> : Plugin.Builder<TGridEditing, TBuilder>
            where TGridEditing : GridEditing
            where TBuilder : Builder<TGridEditing, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TGridEditing component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The number of clicks on a grid required to display the editor (defaults to 2).
			/// </summary>
            public virtual TBuilder ClicksToEdit(int clicksToEdit)
            {
                this.ToComponent().ClicksToEdit = clicksToEdit;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The event which triggers editing. Supercedes the clicksToEdit configuration.
			/// </summary>
            public virtual TBuilder TriggerEvent(string triggerEvent)
            {
                this.ToComponent().TriggerEvent = triggerEvent;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}
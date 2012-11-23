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
    public partial class DateMenu
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : MenuBase.Builder<DateMenu, DateMenu.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DateMenu()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateMenu component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateMenu.Config config) : base(new DateMenu(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DateMenu component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// False to continue showing the menu after a date is selected, defaults to true.
			/// </summary>
            public virtual DateMenu.Builder HideOnClick(bool hideOnClick)
            {
                this.ToComponent().HideOnClick = hideOnClick;
                return this as DateMenu.Builder;
            }
             
 			// /// <summary>
			// /// The Ext.DatePicker object
			// /// </summary>
            // public virtual TBuilder Picker(DatePicker picker)
            // {
            //    this.ToComponent().Picker = picker;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(DateMenuListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side DirectEventHandlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(DateMenuDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DateMenu.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DateMenu(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DateMenu.Builder DateMenu()
        {
            return this.DateMenu(new DateMenu());
        }

        /// <summary>
        /// 
        /// </summary>
        public DateMenu.Builder DateMenu(DateMenu component)
        {
            return new DateMenu.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DateMenu.Builder DateMenu(DateMenu.Config config)
        {
            return new DateMenu.Builder(new DateMenu(config));
        }
    }
}
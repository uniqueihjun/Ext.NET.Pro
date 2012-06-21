/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class MonthView
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : MonthViewBase.Builder<MonthView, MonthView.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MonthView()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MonthView component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MonthView.Config config) : base(new MonthView(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MonthView component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of MonthView.Builder</returns>
            public virtual MonthView.Builder Listeners(Action<MonthViewListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as MonthView.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of MonthView.Builder</returns>
            public virtual MonthView.Builder DirectEvents(Action<MonthViewDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as MonthView.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public MonthView.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MonthView(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public MonthView.Builder MonthView()
        {
            return this.MonthView(new MonthView());
        }

        /// <summary>
        /// 
        /// </summary>
        public MonthView.Builder MonthView(MonthView component)
        {
            return new MonthView.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MonthView.Builder MonthView(MonthView.Config config)
        {
            return new MonthView.Builder(new MonthView(config));
        }
    }
}
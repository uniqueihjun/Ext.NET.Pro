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
    public partial class GridView
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TableView.Builder<GridView, GridView.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GridView()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridView component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GridView.Config config) : base(new GridView(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GridView component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to stripe the rows. Default is true.
			/// </summary>
            public virtual GridView.Builder StripeRows(bool stripeRows)
            {
                this.ToComponent().StripeRows = stripeRows;
                return this as GridView.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of GridView.Builder</returns>
            public virtual GridView.Builder Listeners(Action<GridViewListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as GridView.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of GridView.Builder</returns>
            public virtual GridView.Builder DirectEvents(Action<GridViewDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as GridView.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GridView.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GridView(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GridView.Builder GridView()
        {
            return this.GridView(new GridView());
        }

        /// <summary>
        /// 
        /// </summary>
        public GridView.Builder GridView(GridView component)
        {
            return new GridView.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GridView.Builder GridView(GridView.Config config)
        {
            return new GridView.Builder(new GridView(config));
        }
    }
}
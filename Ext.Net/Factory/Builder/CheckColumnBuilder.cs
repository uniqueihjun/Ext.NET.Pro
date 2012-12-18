/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class CheckColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCheckColumn, TBuilder> : ColumnBase.Builder<TCheckColumn, TBuilder>
            where TCheckColumn : CheckColumn
            where TBuilder : Builder<TCheckColumn, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCheckColumn component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Editable(bool editable)
            {
                this.ToComponent().Editable = editable;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SingleSelect(bool singleSelect)
            {
                this.ToComponent().SingleSelect = singleSelect;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder StopSelection(bool stopSelection)
            {
                this.ToComponent().StopSelection = stopSelection;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<CheckColumnListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<CheckColumnDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : CheckColumn.Builder<CheckColumn, CheckColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CheckColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckColumn.Config config) : base(new CheckColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CheckColumn component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CheckColumn(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CheckColumn.Builder CheckColumn()
        {
#if MVC
			return this.CheckColumn(new CheckColumn { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CheckColumn(new CheckColumn());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckColumn.Builder CheckColumn(CheckColumn component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CheckColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckColumn.Builder CheckColumn(CheckColumn.Config config)
        {
#if MVC
			return new CheckColumn.Builder(new CheckColumn(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CheckColumn.Builder(new CheckColumn(config));
#endif			
        }
    }
}
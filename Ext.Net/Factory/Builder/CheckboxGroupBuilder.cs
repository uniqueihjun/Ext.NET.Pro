/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class CheckboxGroup
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCheckboxGroup, TBuilder> : CheckboxGroupBase.Builder<TCheckboxGroup, TBuilder>
            where TCheckboxGroup : CheckboxGroup
            where TBuilder : Builder<TCheckboxGroup, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCheckboxGroup component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<CheckboxGroupListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<CheckboxGroupDirectEvents> action)
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
        public partial class Builder : CheckboxGroup.Builder<CheckboxGroup, CheckboxGroup.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CheckboxGroup()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckboxGroup component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckboxGroup.Config config) : base(new CheckboxGroup(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CheckboxGroup component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CheckboxGroup(this);
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
        public CheckboxGroup.Builder CheckboxGroup()
        {
#if MVC
			return this.CheckboxGroup(new CheckboxGroup { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CheckboxGroup(new CheckboxGroup());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder CheckboxGroup(CheckboxGroup component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CheckboxGroup.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder CheckboxGroup(CheckboxGroup.Config config)
        {
#if MVC
			return new CheckboxGroup.Builder(new CheckboxGroup(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CheckboxGroup.Builder(new CheckboxGroup(config));
#endif			
        }
    }
}
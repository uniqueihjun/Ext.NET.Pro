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
    public partial class MultiCombo
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TMultiCombo, TBuilder> : ComboBoxBase.Builder<TMultiCombo, TBuilder>
            where TMultiCombo : MultiCombo
            where TBuilder : Builder<TMultiCombo, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TMultiCombo component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to sort selected items by DisplayField. Defaults to false.
			/// </summary>
            public virtual TBuilder SortByDisplayField(bool sortByDisplayField)
            {
                this.ToComponent().SortByDisplayField = sortByDisplayField;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to wrap by square brackets.
			/// </summary>
            public virtual TBuilder WrapBySquareBrackets(bool wrapBySquareBrackets)
            {
                this.ToComponent().WrapBySquareBrackets = wrapBySquareBrackets;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Selection UI mode
			/// </summary>
            public virtual TBuilder SelectionMode(MultiSelectMode selectionMode)
            {
                this.ToComponent().SelectionMode = selectionMode;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<ComboBoxListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<ComboBoxDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// Select all items
			/// </summary>
            public virtual TBuilder SelectAll()
            {
                this.ToComponent().SelectAll();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Deselect item by index
			/// </summary>
            public virtual TBuilder DeselectItem(int index)
            {
                this.ToComponent().DeselectItem(index);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Deselect item by value
			/// </summary>
            public virtual TBuilder DeselectItem(string value)
            {
                this.ToComponent().DeselectItem(value);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Select item by index
			/// </summary>
            public virtual TBuilder SelectItem(int index)
            {
                this.ToComponent().SelectItem(index);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Select item by value
			/// </summary>
            public virtual TBuilder SelectItem(string value)
            {
                this.ToComponent().SelectItem(value);
                return this as TBuilder;
            }
            
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : MultiCombo.Builder<MultiCombo, MultiCombo.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MultiCombo()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MultiCombo component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MultiCombo.Config config) : base(new MultiCombo(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MultiCombo component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiCombo.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MultiCombo(this);
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
        public MultiCombo.Builder MultiCombo()
        {
#if MVC
			return this.MultiCombo(new MultiCombo { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.MultiCombo(new MultiCombo());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiCombo.Builder MultiCombo(MultiCombo component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new MultiCombo.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MultiCombo.Builder MultiCombo(MultiCombo.Config config)
        {
#if MVC
			return new MultiCombo.Builder(new MultiCombo(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new MultiCombo.Builder(new MultiCombo(config));
#endif			
        }
    }
}
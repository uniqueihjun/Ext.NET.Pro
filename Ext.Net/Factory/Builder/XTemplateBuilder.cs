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
    public partial class XTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TXTemplate, TBuilder> : LazyObservable.Builder<TXTemplate, TBuilder>
            where TXTemplate : XTemplate
            where TBuilder : Builder<TXTemplate, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TXTemplate component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Inline functions
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Functions(Action<List<JFunction>> action)
            {
                action(this.ToComponent().Functions);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Template text
			/// </summary>
            public virtual TBuilder Html(string html)
            {
                this.ToComponent().Html = html;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// Applies the supplied values to the template and appends the new node(s) to el.
			/// </summary>
            public virtual TBuilder Append(string target, object data)
            {
                this.ToComponent().Append(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and appends the new node(s) to el.
			/// </summary>
            public virtual TBuilder Append(AbstractComponent target, object data)
            {
                this.ToComponent().Append(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and appends the new node(s) to el.
			/// </summary>
            public virtual TBuilder Append(Element target, object data)
            {
                this.ToComponent().Append(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and inserts the new node(s) after el.
			/// </summary>
            public virtual TBuilder InsertAfter(string target, object data)
            {
                this.ToComponent().InsertAfter(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and inserts the new node(s) after el.
			/// </summary>
            public virtual TBuilder InsertAfter(AbstractComponent target, object data)
            {
                this.ToComponent().InsertAfter(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and inserts the new node(s) after el.
			/// </summary>
            public virtual TBuilder InsertAfter(Element target, object data)
            {
                this.ToComponent().InsertAfter(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and inserts the new node(s) before el.
			/// </summary>
            public virtual TBuilder InsertBefore(string target, object data)
            {
                this.ToComponent().InsertBefore(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and inserts the new node(s) before el.
			/// </summary>
            public virtual TBuilder InsertBefore(AbstractComponent target, object data)
            {
                this.ToComponent().InsertBefore(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and inserts the new node(s) before el.
			/// </summary>
            public virtual TBuilder InsertBefore(Element target, object data)
            {
                this.ToComponent().InsertBefore(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and inserts the new node(s) as the first child of el.
			/// </summary>
            public virtual TBuilder InsertFirst(string target, object data)
            {
                this.ToComponent().InsertFirst(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and inserts the new node(s) as the first child of el.
			/// </summary>
            public virtual TBuilder InsertFirst(AbstractComponent target, object data)
            {
                this.ToComponent().InsertFirst(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and inserts the new node(s) as the first child of el.
			/// </summary>
            public virtual TBuilder InsertFirst(Element target, object data)
            {
                this.ToComponent().InsertFirst(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and overwrites the content of el with the new node(s).
			/// </summary>
            public virtual TBuilder Overwrite(string target, object data)
            {
                this.ToComponent().Overwrite(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and overwrites the content of el with the new node(s).
			/// </summary>
            public virtual TBuilder Overwrite(Element target, object data)
            {
                this.ToComponent().Overwrite(target, data);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Applies the supplied values to the template and overwrites the content of el with the new node(s).
			/// </summary>
            public virtual TBuilder Overwrite(AbstractComponent target, object data)
            {
                this.ToComponent().Overwrite(target, data);
                return this as TBuilder;
            }
            
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : XTemplate.Builder<XTemplate, XTemplate.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new XTemplate()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XTemplate component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XTemplate.Config config) : base(new XTemplate(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(XTemplate component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public XTemplate.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.XTemplate(this);
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
        public XTemplate.Builder XTemplate()
        {
#if MVC
			return this.XTemplate(new XTemplate { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.XTemplate(new XTemplate());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public XTemplate.Builder XTemplate(XTemplate component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new XTemplate.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public XTemplate.Builder XTemplate(XTemplate.Config config)
        {
#if MVC
			return new XTemplate.Builder(new XTemplate(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new XTemplate.Builder(new XTemplate(config));
#endif			
        }
    }
}
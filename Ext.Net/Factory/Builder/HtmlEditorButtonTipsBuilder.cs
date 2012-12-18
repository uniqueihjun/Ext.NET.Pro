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
    public partial class HtmlEditorButtonTips
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<THtmlEditorButtonTips, TBuilder> : BaseItem.Builder<THtmlEditorButtonTips, TBuilder>
            where THtmlEditorButtonTips : HtmlEditorButtonTips
            where TBuilder : Builder<THtmlEditorButtonTips, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(THtmlEditorButtonTips component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Bold(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().Bold);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Italic(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().Italic);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Underline(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().Underline);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder IncreaseFontSize(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().IncreaseFontSize);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DecreaseFontSize(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().DecreaseFontSize);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder BackColor(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().BackColor);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder ForeColor(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().ForeColor);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder JustifyLeft(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().JustifyLeft);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder JustifyCenter(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().JustifyCenter);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder JustifyRight(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().JustifyRight);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder InsertUnorderedList(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().InsertUnorderedList);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder InsertOrderedList(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().InsertOrderedList);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder CreateLink(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().CreateLink);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder SourceEdit(Action<HtmlEditorButtonTip> action)
            {
                action(this.ToComponent().SourceEdit);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : HtmlEditorButtonTips.Builder<HtmlEditorButtonTips, HtmlEditorButtonTips.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HtmlEditorButtonTips()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditorButtonTips component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditorButtonTips.Config config) : base(new HtmlEditorButtonTips(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HtmlEditorButtonTips component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTips.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HtmlEditorButtonTips(this);
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
        public HtmlEditorButtonTips.Builder HtmlEditorButtonTips()
        {
#if MVC
			return this.HtmlEditorButtonTips(new HtmlEditorButtonTips { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.HtmlEditorButtonTips(new HtmlEditorButtonTips());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTips.Builder HtmlEditorButtonTips(HtmlEditorButtonTips component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new HtmlEditorButtonTips.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTips.Builder HtmlEditorButtonTips(HtmlEditorButtonTips.Config config)
        {
#if MVC
			return new HtmlEditorButtonTips.Builder(new HtmlEditorButtonTips(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new HtmlEditorButtonTips.Builder(new HtmlEditorButtonTips(config));
#endif			
        }
    }
}
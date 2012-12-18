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
    public partial class HtmlEditorButtonTip
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<THtmlEditorButtonTip, TBuilder> : BaseItem.Builder<THtmlEditorButtonTip, TBuilder>
            where THtmlEditorButtonTip : HtmlEditorButtonTip
            where TBuilder : Builder<THtmlEditorButtonTip, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(THtmlEditorButtonTip component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Title(string title)
            {
                this.ToComponent().Title = title;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Cls(string cls)
            {
                this.ToComponent().Cls = cls;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : HtmlEditorButtonTip.Builder<HtmlEditorButtonTip, HtmlEditorButtonTip.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HtmlEditorButtonTip()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditorButtonTip component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditorButtonTip.Config config) : base(new HtmlEditorButtonTip(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HtmlEditorButtonTip component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HtmlEditorButtonTip(this);
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
        public HtmlEditorButtonTip.Builder HtmlEditorButtonTip()
        {
#if MVC
			return this.HtmlEditorButtonTip(new HtmlEditorButtonTip { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.HtmlEditorButtonTip(new HtmlEditorButtonTip());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder HtmlEditorButtonTip(HtmlEditorButtonTip component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new HtmlEditorButtonTip.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder HtmlEditorButtonTip(HtmlEditorButtonTip.Config config)
        {
#if MVC
			return new HtmlEditorButtonTip.Builder(new HtmlEditorButtonTip(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new HtmlEditorButtonTip.Builder(new HtmlEditorButtonTip(config));
#endif			
        }
    }
}
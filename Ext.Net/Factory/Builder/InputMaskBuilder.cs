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
    public partial class InputMask
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TInputMask, TBuilder> : Plugin.Builder<TInputMask, TBuilder>
            where TInputMask : InputMask
            where TBuilder : Builder<TInputMask, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TInputMask component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AlwaysShow(bool alwaysShow)
            {
                this.ToComponent().AlwaysShow = alwaysShow;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ClearWhenInvalid(bool clearWhenInvalid)
            {
                this.ToComponent().ClearWhenInvalid = clearWhenInvalid;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AllowInvalid(bool allowInvalid)
            {
                this.ToComponent().AllowInvalid = allowInvalid;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder InvalidMaskText(string invalidMaskText)
            {
                this.ToComponent().InvalidMaskText = invalidMaskText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mask(string mask)
            {
                this.ToComponent().Mask = mask;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder MaskSymbols(Action<MaskSymbolCollection> action)
            {
                action(this.ToComponent().MaskSymbols);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Placeholder(char placeholder)
            {
                this.ToComponent().Placeholder = placeholder;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder UnmaskOnBlur(bool unmaskOnBlur)
            {
                this.ToComponent().UnmaskOnBlur = unmaskOnBlur;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : InputMask.Builder<InputMask, InputMask.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new InputMask()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(InputMask component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(InputMask.Config config) : base(new InputMask(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(InputMask component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public InputMask.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.InputMask(this);
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
        public InputMask.Builder InputMask()
        {
#if MVC
			return this.InputMask(new InputMask { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.InputMask(new InputMask());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public InputMask.Builder InputMask(InputMask component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new InputMask.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public InputMask.Builder InputMask(InputMask.Config config)
        {
#if MVC
			return new InputMask.Builder(new InputMask(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new InputMask.Builder(new InputMask(config));
#endif			
        }
    }
}
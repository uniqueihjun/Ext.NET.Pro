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
    public partial class CapsLockDetector
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCapsLockDetector, TBuilder> : Plugin.Builder<TCapsLockDetector, TBuilder>
            where TCapsLockDetector : CapsLockDetector
            where TBuilder : Builder<TCapsLockDetector, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCapsLockDetector component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder PreventCapsLockChar(bool preventCapsLockChar)
            {
                this.ToComponent().PreventCapsLockChar = preventCapsLockChar;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The error icon
			/// </summary>
            public virtual TBuilder CapsLockIndicatorIcon(Icon capsLockIndicatorIcon)
            {
                this.ToComponent().CapsLockIndicatorIcon = capsLockIndicatorIcon;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder CapsLockIndicatorIconCls(string capsLockIndicatorIconCls)
            {
                this.ToComponent().CapsLockIndicatorIconCls = capsLockIndicatorIconCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder CapsLockIndicatorText(string capsLockIndicatorText)
            {
                this.ToComponent().CapsLockIndicatorText = capsLockIndicatorText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder CapsLockIndicatorTip(string capsLockIndicatorTip)
            {
                this.ToComponent().CapsLockIndicatorTip = capsLockIndicatorTip;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<CapsLockDetectorListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<CapsLockDetectorDirectEvents> action)
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
        public partial class Builder : CapsLockDetector.Builder<CapsLockDetector, CapsLockDetector.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CapsLockDetector()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CapsLockDetector component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CapsLockDetector.Config config) : base(new CapsLockDetector(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CapsLockDetector component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CapsLockDetector.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CapsLockDetector(this);
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
        public CapsLockDetector.Builder CapsLockDetector()
        {
#if MVC
			return this.CapsLockDetector(new CapsLockDetector { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CapsLockDetector(new CapsLockDetector());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CapsLockDetector.Builder CapsLockDetector(CapsLockDetector component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CapsLockDetector.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CapsLockDetector.Builder CapsLockDetector(CapsLockDetector.Config config)
        {
#if MVC
			return new CapsLockDetector.Builder(new CapsLockDetector(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CapsLockDetector.Builder(new CapsLockDetector(config));
#endif			
        }
    }
}
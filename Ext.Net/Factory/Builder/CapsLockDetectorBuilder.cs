/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
        public partial class Builder : Plugin.Builder<CapsLockDetector, CapsLockDetector.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual CapsLockDetector.Builder PreventCapsLockChar(bool preventCapsLockChar)
            {
                this.ToComponent().PreventCapsLockChar = preventCapsLockChar;
                return this as CapsLockDetector.Builder;
            }
             
 			/// <summary>
			/// The error icon
			/// </summary>
            public virtual CapsLockDetector.Builder CapsLockIndicatorIcon(Icon capsLockIndicatorIcon)
            {
                this.ToComponent().CapsLockIndicatorIcon = capsLockIndicatorIcon;
                return this as CapsLockDetector.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual CapsLockDetector.Builder CapsLockIndicatorIconCls(string capsLockIndicatorIconCls)
            {
                this.ToComponent().CapsLockIndicatorIconCls = capsLockIndicatorIconCls;
                return this as CapsLockDetector.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual CapsLockDetector.Builder CapsLockIndicatorText(string capsLockIndicatorText)
            {
                this.ToComponent().CapsLockIndicatorText = capsLockIndicatorText;
                return this as CapsLockDetector.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual CapsLockDetector.Builder CapsLockIndicatorTip(string capsLockIndicatorTip)
            {
                this.ToComponent().CapsLockIndicatorTip = capsLockIndicatorTip;
                return this as CapsLockDetector.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CapsLockDetector.Builder</returns>
            public virtual CapsLockDetector.Builder Listeners(Action<CapsLockDetectorListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as CapsLockDetector.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CapsLockDetector.Builder</returns>
            public virtual CapsLockDetector.Builder DirectEvents(Action<CapsLockDetectorDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as CapsLockDetector.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CapsLockDetector.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CapsLockDetector(this);
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
            return this.CapsLockDetector(new CapsLockDetector());
        }

        /// <summary>
        /// 
        /// </summary>
        public CapsLockDetector.Builder CapsLockDetector(CapsLockDetector component)
        {
            return new CapsLockDetector.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CapsLockDetector.Builder CapsLockDetector(CapsLockDetector.Config config)
        {
            return new CapsLockDetector.Builder(new CapsLockDetector(config));
        }
    }
}
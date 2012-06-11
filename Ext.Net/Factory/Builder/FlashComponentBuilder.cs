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
    public partial class FlashComponent
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ComponentBase.Builder<FlashComponent, FlashComponent.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FlashComponent()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FlashComponent component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FlashComponent.Config config) : base(new FlashComponent(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FlashComponent component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The background color. Defaults to '#ffffff' (white).
			/// </summary>
            public virtual FlashComponent.Builder BackgroundColor(string backgroundColor)
            {
                this.ToComponent().BackgroundColor = backgroundColor;
                return this as FlashComponent.Builder;
            }
             
 			/// <summary>
			/// True to prompt the user to install flash if not installed. Note that this uses Ext.FlashComponent.EXPRESS_INSTALL_URL, which should be set to the local resource. Defaults to false.
			/// </summary>
            public virtual FlashComponent.Builder ExpressInstall(bool expressInstall)
            {
                this.ToComponent().ExpressInstall = expressInstall;
                return this as FlashComponent.Builder;
            }
             
 			/// <summary>
			/// Indicates the version the flash content was published for. Defaults to '9.0.45'.
			/// </summary>
            public virtual FlashComponent.Builder FlashVersion(string flashVersion)
            {
                this.ToComponent().FlashVersion = flashVersion;
                return this as FlashComponent.Builder;
            }
             
 			/// <summary>
			/// The URL of the swf object to include. Defaults to undefined.
			/// </summary>
            public virtual FlashComponent.Builder Url(string url)
            {
                this.ToComponent().Url = url;
                return this as FlashComponent.Builder;
            }
             
 			/// <summary>
			/// A set of key value pairs to be passed to the flash object as flash variables.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of FlashComponent.Builder</returns>
            public virtual FlashComponent.Builder FlashVars(Action<ParameterCollection> action)
            {
                action(this.ToComponent().FlashVars);
                return this as FlashComponent.Builder;
            }
			 
 			/// <summary>
			/// A set of key value pairs to be passed to the flash object as parameters.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of FlashComponent.Builder</returns>
            public virtual FlashComponent.Builder FlashParams(Action<ParameterCollection> action)
            {
                action(this.ToComponent().FlashParams);
                return this as FlashComponent.Builder;
            }
			 
 			/// <summary>
			/// The height of the embedded SWF movie inside the component. Defaults to \"100%\" so that the movie matches the height of the component.
			/// </summary>
            public virtual FlashComponent.Builder SwfHeight(string swfHeight)
            {
                this.ToComponent().SwfHeight = swfHeight;
                return this as FlashComponent.Builder;
            }
             
 			/// <summary>
			/// The width of the embedded SWF movie inside the component. Defaults to \"100%\" so that the movie matches the width of the component.
			/// </summary>
            public virtual FlashComponent.Builder SwfWidth(string swfWidth)
            {
                this.ToComponent().SwfWidth = swfWidth;
                return this as FlashComponent.Builder;
            }
             
 			/// <summary>
			/// The wmode of the flash object. This can be used to control layering. Set to 'transparent' to ignore the backgroundColor and make the background of the Flash movie transparent.
			/// </summary>
            public virtual FlashComponent.Builder WMode(string wMode)
            {
                this.ToComponent().WMode = wMode;
                return this as FlashComponent.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of FlashComponent.Builder</returns>
            public virtual FlashComponent.Builder Listeners(Action<FlashComponentListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as FlashComponent.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of FlashComponent.Builder</returns>
            public virtual FlashComponent.Builder DirectEvents(Action<FlashComponentDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as FlashComponent.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public FlashComponent.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FlashComponent(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FlashComponent.Builder FlashComponent()
        {
            return this.FlashComponent(new FlashComponent());
        }

        /// <summary>
        /// 
        /// </summary>
        public FlashComponent.Builder FlashComponent(FlashComponent component)
        {
            return new FlashComponent.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FlashComponent.Builder FlashComponent(FlashComponent.Config config)
        {
            return new FlashComponent.Builder(new FlashComponent(config));
        }
    }
}
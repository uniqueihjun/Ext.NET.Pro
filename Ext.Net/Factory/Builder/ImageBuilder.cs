/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class Image
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ImageBase.Builder<Image, Image.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Image()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Image component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Image.Config config) : base(new Image(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Image component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Image.Builder</returns>
            public virtual Image.Builder Listeners(Action<ImageListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Image.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Image.Builder</returns>
            public virtual Image.Builder DirectEvents(Action<ImageDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Image.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Image.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Image(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Image.Builder Image()
        {
            return this.Image(new Image());
        }

        /// <summary>
        /// 
        /// </summary>
        public Image.Builder Image(Image component)
        {
            return new Image.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Image.Builder Image(Image.Config config)
        {
            return new Image.Builder(new Image(config));
        }
    }
}
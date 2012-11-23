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
    public partial class ImageCommand
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TImageCommand, TBuilder> : ImageCommandBase.Builder<TImageCommand, TBuilder>
            where TImageCommand : ImageCommand
            where TBuilder : Builder<TImageCommand, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TImageCommand component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ImageCommand.Builder<ImageCommand, ImageCommand.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ImageCommand()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ImageCommand component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ImageCommand.Config config) : base(new ImageCommand(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ImageCommand component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageCommand.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ImageCommand(this);
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
        public ImageCommand.Builder ImageCommand()
        {
#if MVC
			return this.ImageCommand(new ImageCommand { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ImageCommand(new ImageCommand());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageCommand.Builder ImageCommand(ImageCommand component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ImageCommand.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageCommand.Builder ImageCommand(ImageCommand.Config config)
        {
#if MVC
			return new ImageCommand.Builder(new ImageCommand(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ImageCommand.Builder(new ImageCommand(config));
#endif			
        }
    }
}
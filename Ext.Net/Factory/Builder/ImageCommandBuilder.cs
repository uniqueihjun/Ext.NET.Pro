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
    public partial class ImageCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ImageCommandBase.Builder<ImageCommand, ImageCommand.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageCommand.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ImageCommand(this);
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
            return this.ImageCommand(new ImageCommand());
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageCommand.Builder ImageCommand(ImageCommand component)
        {
            return new ImageCommand.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageCommand.Builder ImageCommand(ImageCommand.Config config)
        {
            return new ImageCommand.Builder(new ImageCommand(config));
        }
    }
}
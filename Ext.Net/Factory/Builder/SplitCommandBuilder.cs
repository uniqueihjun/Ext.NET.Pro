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
    public partial class SplitCommand
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TSplitCommand, TBuilder> : GridCommand.Builder<TSplitCommand, TBuilder>
            where TSplitCommand : SplitCommand
            where TBuilder : Builder<TSplitCommand, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TSplitCommand component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : SplitCommand.Builder<SplitCommand, SplitCommand.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SplitCommand()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SplitCommand component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SplitCommand.Config config) : base(new SplitCommand(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SplitCommand component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public SplitCommand.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SplitCommand(this);
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
        public SplitCommand.Builder SplitCommand()
        {
#if MVC
			return this.SplitCommand(new SplitCommand { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.SplitCommand(new SplitCommand());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public SplitCommand.Builder SplitCommand(SplitCommand component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new SplitCommand.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SplitCommand.Builder SplitCommand(SplitCommand.Config config)
        {
#if MVC
			return new SplitCommand.Builder(new SplitCommand(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new SplitCommand.Builder(new SplitCommand(config));
#endif			
        }
    }
}
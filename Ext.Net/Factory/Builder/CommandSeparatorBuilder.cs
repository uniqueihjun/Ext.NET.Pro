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
    public partial class CommandSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCommandSeparator, TBuilder> : GridCommandBase.Builder<TCommandSeparator, TBuilder>
            where TCommandSeparator : CommandSeparator
            where TBuilder : Builder<TCommandSeparator, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCommandSeparator component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : CommandSeparator.Builder<CommandSeparator, CommandSeparator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CommandSeparator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandSeparator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandSeparator.Config config) : base(new CommandSeparator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CommandSeparator component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandSeparator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CommandSeparator(this);
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
        public CommandSeparator.Builder CommandSeparator()
        {
#if MVC
			return this.CommandSeparator(new CommandSeparator { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CommandSeparator(new CommandSeparator());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandSeparator.Builder CommandSeparator(CommandSeparator component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CommandSeparator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandSeparator.Builder CommandSeparator(CommandSeparator.Config config)
        {
#if MVC
			return new CommandSeparator.Builder(new CommandSeparator(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CommandSeparator.Builder(new CommandSeparator(config));
#endif			
        }
    }
}
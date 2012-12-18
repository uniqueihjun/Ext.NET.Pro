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
    public partial class CommandFill
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCommandFill, TBuilder> : GridCommandBase.Builder<TCommandFill, TBuilder>
            where TCommandFill : CommandFill
            where TBuilder : Builder<TCommandFill, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCommandFill component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : CommandFill.Builder<CommandFill, CommandFill.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CommandFill()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandFill component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandFill.Config config) : base(new CommandFill(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CommandFill component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandFill.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CommandFill(this);
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
        public CommandFill.Builder CommandFill()
        {
#if MVC
			return this.CommandFill(new CommandFill { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CommandFill(new CommandFill());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandFill.Builder CommandFill(CommandFill component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CommandFill.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandFill.Builder CommandFill(CommandFill.Config config)
        {
#if MVC
			return new CommandFill.Builder(new CommandFill(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CommandFill.Builder(new CommandFill(config));
#endif			
        }
    }
}
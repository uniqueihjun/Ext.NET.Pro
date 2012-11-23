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
    public partial class GroupImageCommand
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TGroupImageCommand, TBuilder> : ImageCommandBase.Builder<TGroupImageCommand, TBuilder>
            where TGroupImageCommand : GroupImageCommand
            where TBuilder : Builder<TGroupImageCommand, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TGroupImageCommand component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RightAlign(bool rightAlign)
            {
                this.ToComponent().RightAlign = rightAlign;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : GroupImageCommand.Builder<GroupImageCommand, GroupImageCommand.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GroupImageCommand()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GroupImageCommand component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GroupImageCommand.Config config) : base(new GroupImageCommand(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GroupImageCommand component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupImageCommand.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GroupImageCommand(this);
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
        public GroupImageCommand.Builder GroupImageCommand()
        {
#if MVC
			return this.GroupImageCommand(new GroupImageCommand { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.GroupImageCommand(new GroupImageCommand());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupImageCommand.Builder GroupImageCommand(GroupImageCommand component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new GroupImageCommand.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupImageCommand.Builder GroupImageCommand(GroupImageCommand.Config config)
        {
#if MVC
			return new GroupImageCommand.Builder(new GroupImageCommand(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new GroupImageCommand.Builder(new GroupImageCommand(config));
#endif			
        }
    }
}
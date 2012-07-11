/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class CommandSpacer
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridCommandBase.Builder<CommandSpacer, CommandSpacer.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CommandSpacer()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandSpacer component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandSpacer.Config config) : base(new CommandSpacer(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CommandSpacer component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual CommandSpacer.Builder Width(Unit width)
            {
                this.ToComponent().Width = width;
                return this as CommandSpacer.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandSpacer.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CommandSpacer(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CommandSpacer.Builder CommandSpacer()
        {
            return this.CommandSpacer(new CommandSpacer());
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandSpacer.Builder CommandSpacer(CommandSpacer component)
        {
            return new CommandSpacer.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandSpacer.Builder CommandSpacer(CommandSpacer.Config config)
        {
            return new CommandSpacer.Builder(new CommandSpacer(config));
        }
    }
}
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
    public partial class CommandFill
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridCommandBase.Builder<CommandFill, CommandFill.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandFill.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CommandFill(this);
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
            return this.CommandFill(new CommandFill());
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandFill.Builder CommandFill(CommandFill component)
        {
            return new CommandFill.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandFill.Builder CommandFill(CommandFill.Config config)
        {
            return new CommandFill.Builder(new CommandFill(config));
        }
    }
}
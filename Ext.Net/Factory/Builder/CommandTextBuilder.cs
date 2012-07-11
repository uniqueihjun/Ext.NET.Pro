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
    public partial class CommandText
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridCommandBase.Builder<CommandText, CommandText.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CommandText()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandText component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CommandText.Config config) : base(new CommandText(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CommandText component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual CommandText.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as CommandText.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandText.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CommandText(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CommandText.Builder CommandText()
        {
            return this.CommandText(new CommandText());
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandText.Builder CommandText(CommandText component)
        {
            return new CommandText.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CommandText.Builder CommandText(CommandText.Config config)
        {
            return new CommandText.Builder(new CommandText(config));
        }
    }
}
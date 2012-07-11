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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CommandSpacer(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CommandSpacer.Config Conversion to CommandSpacer
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CommandSpacer(CommandSpacer.Config config)
        {
            return new CommandSpacer(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridCommandBase.Config 
        { 
			/*  Implicit CommandSpacer.Config Conversion to CommandSpacer.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CommandSpacer.Builder(CommandSpacer.Config config)
			{
				return new CommandSpacer.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private Unit width = Unit.Empty;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(typeof(Unit), "")]
			public virtual Unit Width 
			{ 
				get
				{
					return this.width;
				}
				set
				{
					this.width = value;
				}
			}

        }
    }
}
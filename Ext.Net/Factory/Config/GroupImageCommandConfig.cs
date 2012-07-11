/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class GroupImageCommand
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GroupImageCommand(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GroupImageCommand.Config Conversion to GroupImageCommand
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GroupImageCommand(GroupImageCommand.Config config)
        {
            return new GroupImageCommand(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ImageCommandBase.Config 
        { 
			/*  Implicit GroupImageCommand.Config Conversion to GroupImageCommand.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GroupImageCommand.Builder(GroupImageCommand.Config config)
			{
				return new GroupImageCommand.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool rightAlign = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool RightAlign 
			{ 
				get
				{
					return this.rightAlign;
				}
				set
				{
					this.rightAlign = value;
				}
			}

        }
    }
}
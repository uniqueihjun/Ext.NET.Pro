/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class CommandText
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CommandText(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CommandText.Config Conversion to CommandText
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CommandText(CommandText.Config config)
        {
            return new CommandText(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridCommandBase.Config 
        { 
			/*  Implicit CommandText.Config Conversion to CommandText.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CommandText.Builder(CommandText.Config config)
			{
				return new CommandText.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string text = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Text 
			{ 
				get
				{
					return this.text;
				}
				set
				{
					this.text = value;
				}
			}

        }
    }
}
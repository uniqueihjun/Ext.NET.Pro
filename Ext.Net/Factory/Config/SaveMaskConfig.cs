/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class SaveMask
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SaveMask(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SaveMask.Config Conversion to SaveMask
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SaveMask(SaveMask.Config config)
        {
            return new SaveMask(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : LoadMask.Config 
        { 
			/*  Implicit SaveMask.Config Conversion to SaveMask.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SaveMask.Builder(SaveMask.Config config)
			{
				return new SaveMask.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string msg = "Saving...";

			/// <summary>
			/// The text to display in a centered saving message box (defaults to 'Saving...').
			/// </summary>
			[DefaultValue("Saving...")]
			public override string Msg 
			{ 
				get
				{
					return this.msg;
				}
				set
				{
					this.msg = value;
				}
			}

        }
    }
}
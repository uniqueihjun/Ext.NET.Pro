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
    public partial class PasswordMask
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public PasswordMask(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit PasswordMask.Config Conversion to PasswordMask
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PasswordMask(PasswordMask.Config config)
        {
            return new PasswordMask(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Plugin.Config 
        { 
			/*  Implicit PasswordMask.Config Conversion to PasswordMask.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator PasswordMask.Builder(PasswordMask.Config config)
			{
				return new PasswordMask.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int duration = 2000;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(2000)]
			public virtual int Duration 
			{ 
				get
				{
					return this.duration;
				}
				set
				{
					this.duration = value;
				}
			}

			private char replacementChar = '\u25CF';

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue('\u25CF')]
			public virtual char ReplacementChar 
			{ 
				get
				{
					return this.replacementChar;
				}
				set
				{
					this.replacementChar = value;
				}
			}

        }
    }
}
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
    public partial class XScript
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public XScript(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit XScript.Config Conversion to XScript
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator XScript(XScript.Config config)
        {
            return new XScript(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : XControl.Config 
        { 
			/*  Implicit XScript.Config Conversion to XScript.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator XScript.Builder(XScript.Config config)
			{
				return new XScript.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string scriptBlock = "";

			/// <summary>
			/// Script text
			/// </summary>
			[DefaultValue("")]
			public virtual string ScriptBlock 
			{ 
				get
				{
					return this.scriptBlock;
				}
				set
				{
					this.scriptBlock = value;
				}
			}

        }
    }
}
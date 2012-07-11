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
    public partial class ToolbarHtmlElement
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ToolbarHtmlElement(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ToolbarHtmlElement.Config Conversion to ToolbarHtmlElement
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolbarHtmlElement(ToolbarHtmlElement.Config config)
        {
            return new ToolbarHtmlElement(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ToolbarItem.Config 
        { 
			/*  Implicit ToolbarHtmlElement.Config Conversion to ToolbarHtmlElement.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ToolbarHtmlElement.Builder(ToolbarHtmlElement.Config config)
			{
				return new ToolbarHtmlElement.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string target = "";

			/// <summary>
			/// The target element which will be placed to toolbar.
			/// </summary>
			[DefaultValue("")]
			public virtual string Target 
			{ 
				get
				{
					return this.target;
				}
				set
				{
					this.target = value;
				}
			}

        }
    }
}
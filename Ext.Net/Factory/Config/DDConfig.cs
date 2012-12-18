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
    public partial class DD
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DD(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DD.Config Conversion to DD
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DD(DD.Config config)
        {
            return new DD(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DragDrop.Config 
        { 
			/*  Implicit DD.Config Conversion to DD.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DD.Builder(DD.Config config)
			{
				return new DD.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool scroll = true;

			/// <summary>
			/// When set to true, the utility automatically tries to scroll the browser window when a drag and drop element is dragged near the viewport boundary. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool Scroll 
			{ 
				get
				{
					return this.scroll;
				}
				set
				{
					this.scroll = value;
				}
			}

        }
    }
}
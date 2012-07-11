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
    public partial class HyperLink
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public HyperLink(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit HyperLink.Config Conversion to HyperLink
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HyperLink(HyperLink.Config config)
        {
            return new HyperLink(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Label.Config 
        { 
			/*  Implicit HyperLink.Config Conversion to HyperLink.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator HyperLink.Builder(HyperLink.Config config)
			{
				return new HyperLink.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string imageUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string ImageUrl 
			{ 
				get
				{
					return this.imageUrl;
				}
				set
				{
					this.imageUrl = value;
				}
			}

			private string navigateUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string NavigateUrl 
			{ 
				get
				{
					return this.navigateUrl;
				}
				set
				{
					this.navigateUrl = value;
				}
			}

			private string target = "";

			/// <summary>
			/// 
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
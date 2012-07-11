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
    public partial class ListItem
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ListItem(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ListItem.Config Conversion to ListItem
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListItem(ListItem.Config config)
        {
            return new ListItem(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit ListItem.Config Conversion to ListItem.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ListItem.Builder(ListItem.Config config)
			{
				return new ListItem.Builder(config);
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

			private string value = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual string Value 
			{ 
				get
				{
					return this.value;
				}
				set
				{
					this.value = value;
				}
			}

        }
    }
}
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
    public partial class SelectedListItem
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SelectedListItem(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SelectedListItem.Config Conversion to SelectedListItem
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SelectedListItem(SelectedListItem.Config config)
        {
            return new SelectedListItem(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit SelectedListItem.Config Conversion to SelectedListItem.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SelectedListItem.Builder(SelectedListItem.Config config)
			{
				return new SelectedListItem.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string value = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
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

			private int index = -1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(-1)]
			public virtual int Index 
			{ 
				get
				{
					return this.index;
				}
				set
				{
					this.index = value;
				}
			}

        }
    }
}
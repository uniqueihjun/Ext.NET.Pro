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
    public partial class FormLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public FormLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit FormLayout.Config Conversion to FormLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FormLayout(FormLayout.Config config)
        {
            return new FormLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AnchorLayout.Config 
        { 
			/*  Implicit FormLayout.Config Conversion to FormLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator FormLayout.Builder(FormLayout.Config config)
			{
				return new FormLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool hideLabels = false;

			/// <summary>
			/// True to hide field labels by default (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public override bool HideLabels 
			{ 
				get
				{
					return this.hideLabels;
				}
				set
				{
					this.hideLabels = value;
				}
			}

			private string itemCls = "";

			/// <summary>
			/// A CSS class to add to the div wrapper that contains each field label and field element (the default class is 'x-form-item' and itemCls will be added to that)
			/// </summary>
			[DefaultValue("")]
			public override string ItemCls 
			{ 
				get
				{
					return this.itemCls;
				}
				set
				{
					this.itemCls = value;
				}
			}

        }
    }
}
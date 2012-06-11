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
    public partial class FieldSet
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public FieldSet(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit FieldSet.Config Conversion to FieldSet
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FieldSet(FieldSet.Config config)
        {
            return new FieldSet(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Panel.Config 
        { 
			/*  Implicit FieldSet.Config Conversion to FieldSet.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator FieldSet.Builder(FieldSet.Config config)
			{
				return new FieldSet.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool animCollapse = false;

			/// <summary>
			/// True to render a checkbox into the fieldset frame just in front of the legend (defaults to false). The fieldset will be expanded or collapsed when the checkbox is toggled.
			/// </summary>
			[DefaultValue(false)]
			public override bool AnimCollapse 
			{ 
				get
				{
					return this.animCollapse;
				}
				set
				{
					this.animCollapse = value;
				}
			}

			private string checkboxName = "";

			/// <summary>
			/// True to render a checkbox into the fieldset frame just in front of the legend (defaults to false). The fieldset will be expanded or collapsed when the checkbox is toggled.
			/// </summary>
			[DefaultValue("")]
			public virtual string CheckboxName 
			{ 
				get
				{
					return this.checkboxName;
				}
				set
				{
					this.checkboxName = value;
				}
			}

			private bool checkboxToggle = false;

			/// <summary>
			/// True to render a checkbox into the fieldset frame just in front of the legend (defaults to false). The fieldset will be expanded or collapsed when the checkbox is toggled.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool CheckboxToggle 
			{ 
				get
				{
					return this.checkboxToggle;
				}
				set
				{
					this.checkboxToggle = value;
				}
			}

			private string itemCls = "";

			/// <summary>
			/// A css class to apply to the x-form-items of fields. This property cascades to child containers.
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

			private int labelWidth = 75;

			/// <summary>
			/// The width of labels. This property cascades to child containers.
			/// </summary>
			[DefaultValue(75)]
			public override int LabelWidth 
			{ 
				get
				{
					return this.labelWidth;
				}
				set
				{
					this.labelWidth = value;
				}
			}

			private string layout = "form";

			/// <summary>
			/// The Ext.Container.layout to use inside the fieldset (defaults to 'form').
			/// </summary>
			[DefaultValue("form")]
			public override string Layout 
			{ 
				get
				{
					return this.layout;
				}
				set
				{
					this.layout = value;
				}
			}

        }
    }
}
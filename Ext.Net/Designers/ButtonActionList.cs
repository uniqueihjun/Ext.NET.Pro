/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ButtonActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ButtonActionList(IComponent component) : base(component) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool AutoPostBack
        {
            get
            {
                return ((Button)this.Control).AutoPostBack;
            }
            set
            {
                this.GetPropertyByName("AutoPostBack").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Text
        {
            get
            {
                return ((ButtonBase)this.Control).Text;
            }
            set
            {
                this.GetPropertyByName("Text").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Icon Icon
        {
            get
            {
                return ((ButtonBase)this.Control).Icon;
            }
            set
            {
                this.GetPropertyByName("Icon").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddPropertyItem(new DesignerActionPropertyItem("AutoPostBack", "AutoPostBack", "500", "Set the Button to AutoPostBack when clicked."));
            this.AddPropertyItem(new DesignerActionPropertyItem("Text", "Text", "500", "Set the text of the Button."));
            this.AddPropertyItem(new DesignerActionPropertyItem("Icon", "Icon", "500", "Set an icon to use in the Title bar"));

            return base.GetSortedActionItems();
        }
    }
}
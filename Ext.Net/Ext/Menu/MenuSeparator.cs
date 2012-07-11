/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Adds a separator bar to a menu, used to divide logical groups of menu items. Generally you will add one of these by using \" - \" in you call to add() or in your items config rather than creating one directly.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("Adds a separator bar to a menu, used to divide logical groups of menu items. Generally you will add one of these by using \" - \" in you call to add() or in your items config rather than creating one directly.")]
    public partial class MenuSeparator : BaseMenuItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public MenuSeparator() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.menu.Separator";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "menuseparator";
            }
        }

        /// <summary>
        /// True to hide the containing menu after this item is clicked (defaults to true).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("5. Separator")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True to hide the containing menu after this item is clicked (defaults to true).")]
        public override bool HideOnClick
        {
            get
            {
                object obj = this.ViewState["HideOnClick"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["HideOnClick"] = value;
            }
        }

        /// <summary>
        /// Render this component disabled (default is false).
        /// </summary>
        [Meta]
        [ConfigOption]
        [DirectEventUpdate(MethodName = "SetDisabled")]
        [Category("5. Separator")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("Render this component disabled (default is false).")]
        public override bool Disabled
        {
            get
            {
                object obj = this.ViewState["Disabled"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["Disabled"] = value;
            }
        }

        /// <summary>
        /// The default CSS class to use for text items (defaults to \"x-menu-text\")
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("5. Separator")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The default CSS class to use for text items (defaults to \"x-menu-text\")")]
        public override string ItemCls
        {
            get
            {
                return (string)this.ViewState["ItemCls"] ?? "";
            }
            set
            {
                this.ViewState["ItemCls"] = value;
            }
        }
    }
}
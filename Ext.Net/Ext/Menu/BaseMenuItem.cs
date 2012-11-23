/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public abstract partial class BaseMenuItem : Component
    {
        /// <summary>
        /// The CSS class to use when the item becomes activated (defaults to \"x-menu-item-active\").
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("4. BaseItem")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The CSS class to use when the item becomes activated (defaults to \"x-menu-item-active\").")]
        public virtual string ActiveClass
        {
            get
            {
                return (string)this.ViewState["ActiveClass"] ?? "";
            }
            set
            {
                this.ViewState["ActiveClass"] = value;
            }
        }

        /// <summary>
        /// True if this item can be visually activated (defaults to false).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("4. BaseItem")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True if this item can be visually activated (defaults to false).")]
        public virtual bool CanActivate
        {
            get
            {
                object obj = this.ViewState["CanActivate"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["CanActivate"] = value;
            }
        }

        /// <summary>
        /// A function that will handle the click event of this menu item (defaults to undefined).
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("4. BaseItem")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("A function that will handle the click event of this menu item (defaults to undefined).")]
        public virtual string Handler
        {
            get
            {
                return (string)this.ViewState["Handler"] ?? "";
            }
            set
            {
                this.ViewState["Handler"] = value;
            }
        }

        /// <summary>
        /// The scope (this reference) in which the handler function will be called.
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("4. BaseItem")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The scope (this reference) in which the handler function will be called.")]
        public virtual string Scope
        {
            get
            {
                return (string)this.ViewState["Scope"] ?? "";
            }
            set
            {
                this.ViewState["Scope"] = value;
            }
        }

        /// <summary>
        /// Length of time in milliseconds to wait before hiding after a click (defaults to 100).
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("4. BaseItem")]
        [DefaultValue(100)]
        [NotifyParentProperty(true)]
        [Description("Length of time in milliseconds to wait before hiding after a click (defaults to 100).")]
        public virtual int HideDelay
        {
            get
            {
                object obj = this.ViewState["HideDelay"];
                return (obj == null) ? 100 : (int)obj;
            }
            set
            {
                this.ViewState["HideDelay"] = value;
            }
        }

        /// <summary>
        /// True to hide the containing menu after this item is clicked (defaults to true).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("4. BaseItem")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to hide the containing menu after this item is clicked (defaults to true).")]
        public virtual bool HideOnClick
        {
            get
            {
                object obj = this.ViewState["HideOnClick"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["HideOnClick"] = value;
            }
        }
    }
}
/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class MenuItemDirectEvents : ComponentDirectEvents
    {
        public MenuItemDirectEvents() { }

        public MenuItemDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent click;

        /// <summary>
        /// Fires when this item is clicked
        /// Parameters
        /// item : Ext.menu.Item
        ///     The item that was clicked
        /// e : Ext.EventObject
        ///     The underyling Ext.EventObject.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is clicked")]
        public virtual ComponentDirectEvent Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent activate;

        /// <summary>
        /// Fires when this item is activated
        /// Parameters
        /// item : Ext.menu.Item
        ///     The item that was clicked
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("activate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is activated")]
        public virtual ComponentDirectEvent Activate
        {
            get
            {
                return this.activate ?? (this.activate = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent deactivate;

        /// <summary>
        /// Fires when this tiem is deactivated
        /// Parameters
        /// item : Ext.menu.Item
        ///     The item that was clicked
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("deactivate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this tiem is deactivated")]
        public virtual ComponentDirectEvent Deactivate
        {
            get
            {
                return this.deactivate ?? (this.deactivate = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent textchange;

        /// <summary>
        /// Fired when the item's text is changed by the setText} method.
        /// Parameters
        /// item : Ext.button.Button
        /// oldText : String
        /// newText : String
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "oldText")]
        [ListenerArgument(2, "newText")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("textchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired when the item's text is changed by the setText} method.")]
        public virtual ComponentDirectEvent TextChange
        {
            get
            {
                return this.textchange ?? (this.textchange = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent iconchange;

        /// <summary>
        /// Fired when the item's icon is changed by the setIcon or setIconCls methods.
        /// Parameters
        /// item : Ext.button.Button
        /// oldIcon : String
        /// newIcon : String
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "oldIcon")]
        [ListenerArgument(2, "newIcon")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("iconchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired when the item's icon is changed by the setIcon or setIconCls methods.")]
        public virtual ComponentDirectEvent IconChange
        {
            get
            {
                return this.iconchange ?? (this.iconchange = new ComponentDirectEvent(this));
            }
        }
    }
}
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
    public partial class MenuItemListeners : AbstractComponentListeners
    {
        private ComponentListener click;

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
        [ConfigOption("click", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is clicked")]
        public virtual ComponentListener Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentListener());
            }
        }

        private ComponentListener activate;

        /// <summary>
        /// Fires when this item is activated
        /// Parameters
        /// item : Ext.menu.Item
        ///     The item that was clicked
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("activate", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is activated")]
        public override ComponentListener Activate
        {
            get
            {
                return this.activate ?? (this.activate = new ComponentListener());
            }
        }

        private ComponentListener deactivate;

        /// <summary>
        /// Fires when this item is deactivated
        /// Parameters
        /// item : Ext.menu.Item
        ///     The item that was clicked
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("deactivate", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is deactivated")]
        public override ComponentListener Deactivate
        {
            get
            {
                return this.deactivate ?? (this.deactivate = new ComponentListener());
            }
        }

        private ComponentListener textchange;

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
        [ConfigOption("textchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired when the item's text is changed by the setText} method.")]
        public virtual ComponentListener TextChange
        {
            get
            {
                return this.textchange ?? (this.textchange = new ComponentListener());
            }
        }

        private ComponentListener iconchange;

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
        [ConfigOption("iconchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired when the item's icon is changed by the setIcon or setIconCls methods.")]
        public virtual ComponentListener IconChange
        {
            get
            {
                return this.iconchange ?? (this.iconchange = new ComponentListener());
            }
        }
    }
}
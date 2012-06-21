/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    }
}
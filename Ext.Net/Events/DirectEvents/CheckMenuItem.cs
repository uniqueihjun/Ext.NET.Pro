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
    public partial class CheckMenuItemDirectEvents : MenuItemDirectEvents
    {
        public CheckMenuItemDirectEvents() { }

        public CheckMenuItemDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforeCheckChange;

        /// <summary>
        /// Fires before a change event. Return false to cancel.
        /// Parameters
        /// item : Ext.menu.CheckItem
        /// checked : Boolean
        /// </summary>
        [ListenerArgument(0, "item", typeof(CheckMenuItem), "this")]
        [ListenerArgument(1, "checked", typeof(bool), "checked")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforecheckchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a change event. Return false to cancel.")]
        public virtual ComponentDirectEvent BeforeCheckChange
        {
            get
            {
                return this.beforeCheckChange ?? (this.beforeCheckChange = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent checkChange;

        /// <summary>
        /// Fires after a change event.
        /// Parameters
        /// item : Ext.menu.CheckItem
        /// checked : Boolean
        /// </summary>
        [ListenerArgument(0, "item", typeof(CheckMenuItem), "this")]
        [ListenerArgument(1, "checked", typeof(bool), "checked")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("checkchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after a change event.")]
        public virtual ComponentDirectEvent CheckChange
        {
            get
            {
                return this.checkChange ?? (this.checkChange = new ComponentDirectEvent(this));
            }
        }
    }
}
/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class GroupTabPanelDirectEvents : ContainerDirectEvents
    {
        public GroupTabPanelDirectEvents() { }

        public GroupTabPanelDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforeGroupChange;

        /// <summary>
        /// Fires before a group change (activated by setActiveGroup). Return false in any listener to cancel the groupchange
        /// Parameters
        /// item : Ext.ux.GroupTabPanel
        ///     The GroupTabPanel
        /// newGroup : Ext.Component
        ///     The root group card that is about to be activated
        /// oldGroup : Ext.Component
        ///     The root group card that is currently active
        /// </summary>
        [ListenerArgument(0, "item", typeof(GroupTabPanel), "this")]
        [ListenerArgument(1, "newGroup")]
        [ListenerArgument(2, "oldGroup")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforegroupchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a group change (activated by setActiveGroup). Return false in any listener to cancel the groupchange")]
        public virtual ComponentDirectEvent BeforeGroupChange
        {
            get
            {
                return this.beforeGroupChange ?? (this.beforeGroupChange = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent groupChange;

        /// <summary>
        /// Fires when a new group has been activated (activated by setActiveGroup).
        /// Parameters
        /// item : Ext.ux.GroupTabPanel
        ///     The GroupTabPanel
        /// newGroup : Ext.Component
        ///     The newly activated root group item
        /// oldGroup : Ext.Component
        ///     The previously active root group item
        /// </summary>
        [ListenerArgument(0, "item", typeof(GroupTabPanel), "this")]
        [ListenerArgument(1, "newGroup")]
        [ListenerArgument(2, "oldGroup")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a new group has been activated (activated by setActiveGroup).")]
        public virtual ComponentDirectEvent GroupChange
        {
            get
            {
                return this.groupChange ?? (this.groupChange = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent beforeTabChange;

        /// <summary>
        /// Fires before a tab change (activated by setActiveTab). Return false in any listener to cancel the tabchange
        /// Parameters
        /// item : Ext.ux.GroupTabPanel
        ///     The GroupTabPanel
        /// newCard : Ext.Component
        ///     The card that is about to be activated
        /// oldCard : Ext.Component
        ///     The card that is currently active
        /// </summary>
        [ListenerArgument(0, "item", typeof(AbstractComponent), "this")]
        [ListenerArgument(1, "newCard", typeof(AbstractComponent), "newCard")]
        [ListenerArgument(2, "oldCard", typeof(AbstractComponent), "oldCard")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a tab change (activated by setActiveTab). Return false in any listener to cancel the tabchange")]
        public virtual ComponentDirectEvent BeforeTabChange
        {
            get
            {
                return this.beforeTabChange ?? (this.beforeTabChange = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent tabChange;

        /// <summary>
        /// Fires when a new tab has been activated (activated by setActiveTab).
        /// Parameters
        /// item : Ext.ux.GroupTabPanel
        ///     The GroupTabPanel
        /// newCard : Ext.Component
        ///     The newly activated item
        /// oldCard : Ext.Component
        ///     The previously active item
        /// </summary>
        [ListenerArgument(0, "item", typeof(AbstractComponent), "this")]
        [ListenerArgument(1, "newCard", typeof(AbstractComponent), "newCard")]
        [ListenerArgument(2, "oldCard", typeof(AbstractComponent), "oldCard")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("tabchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a new tab has been activated (activated by setActiveTab).")]
        public virtual ComponentDirectEvent TabChange
        {
            get
            {
                return this.tabChange ?? (this.tabChange = new ComponentDirectEvent(this));
            }
        }
    }
}
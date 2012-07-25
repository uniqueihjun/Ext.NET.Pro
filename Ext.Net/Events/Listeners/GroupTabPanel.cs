/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class GroupTabPanelListeners : ContainerListeners
    {
        private ComponentListener beforeGroupChange;

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
        [ConfigOption("beforegroupchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a group change (activated by setActiveGroup). Return false in any listener to cancel the groupchange")]
        public virtual ComponentListener BeforeGroupChange
        {
            get
            {
                return this.beforeGroupChange ?? (this.beforeGroupChange = new ComponentListener());
            }
        }

        private ComponentListener groupChange;

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
        [ConfigOption("groupchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a new group has been activated (activated by setActiveGroup).")]
        public virtual ComponentListener GroupChange
        {
            get
            {
                return this.groupChange ?? (this.groupChange = new ComponentListener());
            }
        }

        private ComponentListener beforeTabChange;

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
        [ConfigOption("beforetabchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a tab change (activated by setActiveTab). Return false in any listener to cancel the tabchange")]
        public virtual ComponentListener BeforeTabChange
        {
            get
            {
                return this.beforeTabChange ?? (this.beforeTabChange = new ComponentListener());
            }
        }

        private ComponentListener tabChange;

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
        [ConfigOption("tabchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a new tab has been activated (activated by setActiveTab).")]
        public virtual ComponentListener TabChange
        {
            get
            {
                return this.tabChange ?? (this.tabChange = new ComponentListener());
            }
        }
    }
}
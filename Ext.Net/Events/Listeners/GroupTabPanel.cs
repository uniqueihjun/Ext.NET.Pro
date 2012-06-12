/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
        /// Fires before the active group changes. Handlers can return false to cancel the tab change.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GroupTabPanel), "this")]
        [ListenerArgument(1, "newGroup", typeof(GroupTab), "The group being activated")]
        [ListenerArgument(2, "currentGroup", typeof(GroupTab), "The current active group")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforegroupchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before the active group changes. Handlers can return false to cancel the tab change.")]
        public virtual ComponentListener BeforeGroupChange
        {
            get
            {
                if (this.beforeGroupChange == null)
                {
                    this.beforeGroupChange = new ComponentListener();
                }

                return this.beforeGroupChange;
            }
        }

        private ComponentListener groupChange;

        /// <summary>
        /// Fires after the active group has changed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GroupTabPanel), "this")]
        [ListenerArgument(1, "group", typeof(GroupTab), "The new active group")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the active group has changed.")]
        public virtual ComponentListener GroupChange
        {
            get
            {
                if (this.groupChange == null)
                {
                    this.groupChange = new ComponentListener();
                }

                return this.groupChange;
            }
        }
    }
}
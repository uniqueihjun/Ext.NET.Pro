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
    public partial class TabStripListeners : ContainerListeners
    {
        private ComponentListener beforeTabChange;

        /// <summary>
        /// Fires before the active tab changes. Handlers can return false to cancel the tab change.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "newTab")]
        [ListenerArgument(2, "currentTab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before the active tab changes. Handlers can return false to cancel the tab change.")]
        public virtual ComponentListener BeforeTabChange
        {
            get
            {
                return this.beforeTabChange ?? (this.beforeTabChange = new ComponentListener());
            }
        }

        private ComponentListener tabChange;

        /// <summary>
        /// Fires after the active tab has changed.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "tab")]
        [ListenerArgument(2, "oldTab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("tabchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the active tab has changed.")]
        public virtual ComponentListener TabChange
        {
            get
            {
                return this.tabChange ?? (this.tabChange = new ComponentListener());
            }
        }

        private ComponentListener tabClose;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(TabStrip))]
        [ListenerArgument(1, "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("tabclose", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener TabClose
        {
            get
            {
                return this.tabClose ?? (this.tabClose = new ComponentListener());
            }
        }

        private ComponentListener beforeTabClose;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(TabStrip))]
        [ListenerArgument(1, "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabclose", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener BeforeTabClose
        {
            get
            {
                return this.beforeTabClose ?? (this.beforeTabClose = new ComponentListener());
            }
        }
    }
}

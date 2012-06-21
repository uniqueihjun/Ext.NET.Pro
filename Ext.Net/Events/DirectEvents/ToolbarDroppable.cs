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
    public partial class ToolbarDroppableDirectEvents : ComponentDirectEvents
    {
        public ToolbarDroppableDirectEvents() { }

        public ToolbarDroppableDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforeremotecreate;

        /// <summary>
        /// Fires before remote item creating request.
        /// Parameters
        ///     - item 
        ///     - data
        ///     - remoteOptions
        ///     - dragSource
        ///     - event
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "data")]
        [ListenerArgument(2, "remoteOptions")]
        [ListenerArgument(3, "dragSource")]
        [ListenerArgument(4, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeremotecreate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before remote item creating request.")]
        public virtual ComponentDirectEvent BeforeRemoteCreate
        {
            get
            {
                return this.beforeremotecreate ?? (this.beforeremotecreate = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent remotecreate;

        /// <summary>
        /// Fires after remote item creating request is finished.
        /// Parameters
        ///     - item 
        ///     - success
        ///     - message
        ///     - response
        ///     - o
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "success")]
        [ListenerArgument(2, "message")]
        [ListenerArgument(3, "response")]
        [ListenerArgument(4, "o")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("remotecreate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after remote item creating request is finished.")]
        public virtual ComponentDirectEvent RemoteCreate
        {
            get
            {
                return this.remotecreate ?? (this.remotecreate = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent drop;

        /// <summary>
        /// Fires an item is created and added to the toolbar
        /// Parameters
        ///     - item 
        ///     - toolbarItem
        ///     - index
        ///     - data
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "toolbarItem")]
        [ListenerArgument(2, "index")]
        [ListenerArgument(3, "data")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("drop", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires an item is created and added to the toolbar")]
        public virtual ComponentDirectEvent Drop
        {
            get
            {
                return this.drop ?? (this.drop = new ComponentDirectEvent(this));
            }
        }
    }
}

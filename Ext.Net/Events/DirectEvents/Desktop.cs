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
    public partial class DesktopDirectEvents : ComponentDirectEvents
    {
        public DesktopDirectEvents() { }

        public DesktopDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent shortcutmove;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "module")]
        [ListenerArgument(2, "record")]
        [ListenerArgument(3, "xy")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("shortcutmove", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent ShortcutMove
        {
            get
            {
                return this.shortcutmove ?? (this.shortcutmove = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent shortcutnameedit;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "module")]
        [ListenerArgument(2, "value")]
        [ListenerArgument(3, "oldValue")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("shortcutnameedit", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent ShortcutNameEdit
        {
            get
            {
                return this.shortcutnameedit ?? (this.shortcutnameedit = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent ready;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "el")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("ready", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Ready
        {
            get
            {
                return this.ready ?? (this.ready = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent beforeUnload;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "el")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeunload", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeUnload
        {
            get
            {
                return this.beforeUnload ?? (this.beforeUnload = new ComponentDirectEvent(this));
            }
        }
    }
}
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
    public partial class DesktopListeners : ComponentListeners
    {
        private ComponentListener shortcutmove;

		/// <summary>
		/// 
		/// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "module")]
        [ListenerArgument(2, "record")]
        [ListenerArgument(3, "xy")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("shortcutmove", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
		[Description("")]
        public virtual ComponentListener ShortcutMove
        {
            get
            {
                return this.shortcutmove ?? (this.shortcutmove = new ComponentListener());
            }
        }

        private ComponentListener shortcutnameedit;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "el")]
        [ListenerArgument(1, "module")]
        [ListenerArgument(2, "value")]
        [ListenerArgument(3, "oldValue")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("shortcutnameedit", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener ShortcutNameEdit
        {
            get
            {
                return this.shortcutnameedit ?? (this.shortcutnameedit = new ComponentListener());
            }
        }

        private ComponentListener ready;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "el")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("ready", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Ready
        {
            get
            {
                return this.ready ?? (this.ready = new ComponentListener());
            }
        }

        private ComponentListener beforeUnload;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "el")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeunload", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener BeforeUnload
        {
            get
            {
                return this.beforeUnload ?? (this.beforeUnload = new ComponentListener());
            }
        }
    }
}
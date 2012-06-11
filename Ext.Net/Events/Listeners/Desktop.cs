/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
        private ComponentListener shortcutClick;

		/// <summary>
		/// 
		/// </summary>
        [ListenerArgument(0, "id")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("shortcutclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
		[Description("")]
        public virtual ComponentListener ShortcutClick
        {
            get
            {
                if (this.shortcutClick == null)
                {
                    this.shortcutClick = new ComponentListener();
                }

                return this.shortcutClick;
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
                if (this.ready == null)
                {
                    this.ready = new ComponentListener();
                }

                return this.ready;
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
                if (this.beforeUnload == null)
                {
                    this.beforeUnload = new ComponentListener();
                }

                return this.beforeUnload;
            }
        }
    }
}
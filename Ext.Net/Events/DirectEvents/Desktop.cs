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
    public partial class DesktopDirectEvents : ComponentDirectEvents
    {
        private ComponentDirectEvent shortcutClick;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "id")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("shortcutclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent ShortcutClick
        {
            get
            {
                if (this.shortcutClick == null)
                {
                    this.shortcutClick = new ComponentDirectEvent();
                }

                return this.shortcutClick;
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
                if (this.ready == null)
                {
                    this.ready = new ComponentDirectEvent();
                }

                return this.ready;
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
                if (this.beforeUnload == null)
                {
                    this.beforeUnload = new ComponentDirectEvent();
                }

                return this.beforeUnload;
            }
        }
    }
}
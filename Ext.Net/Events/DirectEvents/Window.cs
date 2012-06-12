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
    public partial class WindowDirectEvents : PanelDirectEvents
    {
        private ComponentDirectEvent maximize;

        /// <summary>
        /// Fires after the window has been maximized.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Window), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("maximize", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the window has been maximized.")]
        public virtual ComponentDirectEvent Maximize
        {
            get
            {
                if (this.maximize == null)
                {
                    this.maximize = new ComponentDirectEvent();
                }

                return this.maximize;
            }
        }

        private ComponentDirectEvent minimize;

        /// <summary>
        /// Fires after the window has been minimized.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Window), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("minimize", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the window has been minimized.")]
        public virtual ComponentDirectEvent Minimize
        {
            get
            {
                if (this.minimize == null)
                {
                    this.minimize = new ComponentDirectEvent();
                }

                return this.minimize;
            }
        }

        private ComponentDirectEvent restore;

        /// <summary>
        /// Fires after the window has been restored to its original size after being maximized.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Window), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("restore", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the window has been restored to its original size after being maximized.")]
        public virtual ComponentDirectEvent Restore
        {
            get
            {
                if (this.restore == null)
                {
                    this.restore = new ComponentDirectEvent();
                }

                return this.restore;
            }
        }
    }
}
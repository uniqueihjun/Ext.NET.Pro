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
    public partial class WindowDirectEvents : PanelDirectEvents
    {
        public WindowDirectEvents() { }

        public WindowDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent maximize;

        /// <summary>
        /// Fires after the window has been maximized.
        /// Parameters
        /// item : Ext.window.Window
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
                return this.maximize ?? (this.maximize = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent minimize;

        /// <summary>
        /// Fires after the window has been minimized.
        /// Parameters
        /// item : Ext.window.Window
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
                return this.minimize ?? (this.minimize = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent restore;

        /// <summary>
        /// Fires after the window has been restored to its original size after being maximized.
        /// Parameters
        /// item : Ext.window.Window
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
                return this.restore ?? (this.restore = new ComponentDirectEvent(this));
            }
        }
    }
}
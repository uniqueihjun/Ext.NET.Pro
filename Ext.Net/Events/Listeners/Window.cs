/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class WindowListeners : PanelListeners
    {
        private ComponentListener maximize;

        /// <summary>
        /// Fires after the window has been maximized.
        /// Parameters
        /// item : Ext.window.Window
        /// </summary>
        [ListenerArgument(0, "item", typeof(Window), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("maximize", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the window has been maximized.")]
        public virtual ComponentListener Maximize
        {
            get
            {
                return this.maximize ?? (this.maximize = new ComponentListener());
            }
        }

        private ComponentListener minimize;

        /// <summary>
        /// Fires after the window has been minimized.
        /// Parameters
        /// item : Ext.window.Window
        /// </summary>
        [ListenerArgument(0, "item", typeof(Window), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("minimize", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the window has been minimized.")]
        public virtual ComponentListener Minimize
        {
            get
            {
                return this.minimize ?? (this.minimize = new ComponentListener());
            }
        }

        private ComponentListener restore;

        /// <summary>
        /// Fires after the window has been restored to its original size after being maximized.
        /// Parameters
        /// item : Ext.window.Window
        /// </summary>
        [ListenerArgument(0, "item", typeof(Window), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("restore", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the window has been restored to its original size after being maximized.")]
        public virtual ComponentListener Restore
        {
            get
            {
                return this.restore ?? (this.restore = new ComponentListener());
            }
        }
    }
}
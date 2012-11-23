/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
                if (this.maximize == null)
                {
                    this.maximize = new ComponentListener();
                }

                return this.maximize;
            }
        }

        private ComponentListener minimize;

        /// <summary>
        /// Fires after the window has been minimized.
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
                if (this.minimize == null)
                {
                    this.minimize = new ComponentListener();
                }

                return this.minimize;
            }
        }

        private ComponentListener restore;

        /// <summary>
        /// Fires after the window has been restored to its original size after being maximized.
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
                if (this.restore == null)
                {
                    this.restore = new ComponentListener();
                }

                return this.restore;
            }
        }
    }
}
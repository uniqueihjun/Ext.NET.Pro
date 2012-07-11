/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class BaseMenuItemDirectEvents : ComponentDirectEvents
    {
        private ComponentDirectEvent activate;

        /// <summary>
        /// Fires when this item is activated
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("activate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is activated")]
        public virtual ComponentDirectEvent Activate
        {
            get
            {
                if (this.activate == null)
                {
                    this.activate = new ComponentDirectEvent();
                }

                return this.activate;
            }
        }

        private ComponentDirectEvent click;

        /// <summary>
        /// Fires when this item is clicked
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [ListenerArgument(1, "e", typeof(object), "Ext.EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is clicked")]
        public virtual ComponentDirectEvent Click
        {
            get
            {
                if (this.click == null)
                {
                    this.click = new ComponentDirectEvent();
                }

                return this.click;
            }
        }

        private ComponentDirectEvent deactivate;

        /// <summary>
        /// Fires when this item is deactivated
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("activate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is deactivated")]
        public virtual ComponentDirectEvent Deactivate
        {
            get
            {
                if (this.deactivate == null)
                {
                    this.deactivate = new ComponentDirectEvent();
                }

                return this.deactivate;
            }
        }
    }
}
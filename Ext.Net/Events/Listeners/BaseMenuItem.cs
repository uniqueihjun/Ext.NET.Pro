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
    public partial class BaseMenuItemListeners : ComponentBaseListeners
    {
        private ComponentListener activate;

        /// <summary>
        /// Fires when this item is activated
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("activate", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is activated")]
        public virtual ComponentListener Activate
        {
            get
            {
                if (this.activate == null)
                {
                    this.activate = new ComponentListener();
                }

                return this.activate;
            }
        }

        private ComponentListener click;

        /// <summary>
        /// Fires when this item is clicked
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [ListenerArgument(1, "e", typeof(Component), "Ext.EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is clicked")]
        public virtual ComponentListener Click
        {
            get
            {
                if (this.click == null)
                {
                    this.click = new ComponentListener();
                }

                return this.click;
            }
        }

        private ComponentListener deactivate;

        /// <summary>
        /// Fires when this item is deactivated
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("activate", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this item is deactivated")]
        public virtual ComponentListener Deactivate
        {
            get
            {
                if (this.deactivate == null)
                {
                    this.deactivate = new ComponentListener();
                }

                return this.deactivate;
            }
        }
    }
}
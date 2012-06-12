/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    [ToolboxItem(false)]
    [TypeConverter(typeof(ListenersConverter))]
    public partial class GridFilterListeners : ComponentListeners
    {
        private ComponentListener activate;

        /// <summary>
        /// Fires when an inactive filter becomes active
        /// </summary>
        [ListenerArgument(0, "filter", typeof(object), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("activate", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when an inactive filter becomes active")]
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

        private ComponentListener deactivate;

        /// <summary>
        /// Fires when an active filter becomes inactive
        /// </summary>
        [ListenerArgument(0, "filter", typeof(object), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("deactivate", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when an active filter becomes inactive")]
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

        private ComponentListener serialize;

        /// <summary>
        /// Fires after the serialization process. Use this to attach additional parameters to serialization
        /// data before it is encoded and sent to the server.
        /// </summary>
        [ListenerArgument(0, "data", typeof(object), "A map or collection of maps representing the current filter configuration.")]
        [ListenerArgument(1, "filter", typeof(object), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("serialize", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the serialization process. Use this to attach additional parameters to serialization data before it is encoded and sent to the server.")]
        public virtual ComponentListener Serialize
        {
            get
            {
                if (this.serialize == null)
                {
                    this.serialize = new ComponentListener();
                }

                return this.serialize;
            }
        }

        private ComponentListener update;

        /// <summary>
        /// Fires when a filter configuration has changed
        /// </summary>
        [ListenerArgument(0, "filter", typeof(object), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("update", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a filter configuration has changed")]
        public virtual ComponentListener Update
        {
            get
            {
                if (this.update == null)
                {
                    this.update = new ComponentListener();
                }

                return this.update;
            }
        }
    }
}
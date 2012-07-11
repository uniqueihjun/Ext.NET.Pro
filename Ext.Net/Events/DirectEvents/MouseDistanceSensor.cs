/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    public partial class MouseDistanceSensorDirectEvents : ComponentDirectEvents
    {
        public MouseDistanceSensorDirectEvents() { }

        public MouseDistanceSensorDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent far;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(MouseDistanceSensor), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("far", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Far
        {
            get
            {
                if (this.far == null)
                {
                    this.far = new ComponentDirectEvent(this);
                }

                return this.far;
            }
        }

        private ComponentDirectEvent near;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(MouseDistanceSensor), "this")]
        [ListenerArgument(1, "sensorEl", typeof(object), "sensor element")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("near", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Near
        {
            get
            {
                if (this.near == null)
                {
                    this.near = new ComponentDirectEvent(this);
                }

                return this.near;
            }
        }

        private ComponentDirectEvent distance;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(MouseDistanceSensor), "this")]
        [ListenerArgument(1, "distance", typeof(int), "distance in pixel")]
        [ListenerArgument(2, "rdistance", typeof(decimal), "relative distance")]
        [ListenerArgument(3, "sensorEl", typeof(object), "sensor element")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("distance", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Distance
        {
            get
            {
                if (this.distance == null)
                {
                    this.distance = new ComponentDirectEvent(this);
                }

                return this.distance;
            }
        }
    }
}

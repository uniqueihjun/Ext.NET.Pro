/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    public partial class MouseDistanceSensorListeners : ComponentListeners
    {
        private ComponentListener far;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(MouseDistanceSensor), "this")]        
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("far", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Far
        {
            get
            {
                if (this.far == null)
                {
                    this.far = new ComponentListener();
                }

                return this.far;
            }
        }

        private ComponentListener near;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(MouseDistanceSensor), "this")]
        [ListenerArgument(1, "sensorEl", typeof(object), "sensor element")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("near", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Near
        {
            get
            {
                if (this.near == null)
                {
                    this.near = new ComponentListener();
                }

                return this.near;
            }
        }

        private ComponentListener distance;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(MouseDistanceSensor), "this")]
        [ListenerArgument(1, "distance", typeof(int), "distance in pixel")]
        [ListenerArgument(2, "rdistance", typeof(decimal), "relative distance")]
        [ListenerArgument(3, "sensorEl", typeof(object), "sensor element")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("distance", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Distance
        {
            get
            {
                if (this.distance == null)
                {
                    this.distance = new ComponentListener();
                }

                return this.distance;
            }
        }
    }
}
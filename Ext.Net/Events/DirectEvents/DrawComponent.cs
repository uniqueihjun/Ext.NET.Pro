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
    ///<summary>
    ///</summary>
    public partial class DrawComponentDirectEvents : AbstractComponentDirectEvents
    {
        public DrawComponentDirectEvents() { }

        public DrawComponentDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent click;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent dblclick;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dblclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent DblClick
        {
            get
            {
                return this.dblclick ?? (this.dblclick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseup;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseup", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent MouseUp
        {
            get
            {
                return this.mouseup ?? (this.mouseup = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mousedown;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mousedown", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent MouseDown
        {
            get
            {
                return this.mousedown ?? (this.mousedown = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseenter;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseenter", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent MouseEnter
        {
            get
            {
                return this.mouseenter ?? (this.mouseenter = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mouseleave;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseleave", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent MouseLeave
        {
            get
            {
                return this.mouseleave ?? (this.mouseleave = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent mousemove;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mousemove", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent MouseMove
        {
            get
            {
                return this.mousemove ?? (this.mousemove = new ComponentDirectEvent(this));
            }
        }
    }
}

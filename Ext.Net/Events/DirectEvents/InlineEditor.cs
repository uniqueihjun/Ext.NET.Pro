/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    public partial class InlineEditorDirectEvents : ComponentBaseDirectEvents
    {
        private ComponentDirectEvent beforestartedit;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "editor")]
        [ListenerArgument(1, "boundEl")]
        [ListenerArgument(2, "value")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforestartedit", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeStartEdit
        {
            get
            {
                if (this.beforestartedit == null)
                {
                    this.beforestartedit = new ComponentDirectEvent();
                }

                return this.beforestartedit;
            }
        }

        private ComponentDirectEvent beforecomplete;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "editor")]
        [ListenerArgument(1, "value")]
        [ListenerArgument(2, "startValue")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforecomplete", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeComplete
        {
            get
            {
                if (this.beforecomplete == null)
                {
                    this.beforecomplete = new ComponentDirectEvent();
                }

                return this.beforecomplete;
            }
        }

        private ComponentDirectEvent canceledit;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "editor")]
        [ListenerArgument(1, "value")]
        [ListenerArgument(2, "startValue")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("canceledit", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent CancelEdit
        {
            get
            {
                if (this.canceledit == null)
                {
                    this.canceledit = new ComponentDirectEvent();
                }

                return this.canceledit;
            }
        }

        private ComponentDirectEvent complete;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "editor")]
        [ListenerArgument(1, "value")]
        [ListenerArgument(2, "startValue")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("complete", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Complete
        {
            get
            {
                if (this.complete == null)
                {
                    this.complete = new ComponentDirectEvent();
                }

                return this.complete;
            }
        }

        private ComponentDirectEvent specialkey;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "field")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("specialkey", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent SpecialKey
        {
            get
            {
                if (this.specialkey == null)
                {
                    this.specialkey = new ComponentDirectEvent();
                }

                return this.specialkey;
            }
        }

        private ComponentDirectEvent startedit;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "boundEl")]
        [ListenerArgument(1, "value")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("startedit", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent StartEdit
        {
            get
            {
                if (this.startedit == null)
                {
                    this.startedit = new ComponentDirectEvent();
                }

                return this.startedit;
            }
        }
    }
}
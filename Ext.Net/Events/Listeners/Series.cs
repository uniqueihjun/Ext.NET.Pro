/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    public partial class SeriesListeners : ComponentListeners
    {
        private ComponentListener afterrender;

        /// <summary>
        /// Will be triggered when the animation ends or when the series has been rendered completely.
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("afterrender", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Will be triggered when the animation ends or when the series has been rendered completely.")]
        public virtual ComponentListener AfterRender
        {
            get
            {
                return this.afterrender ?? (this.afterrender = new ComponentListener());
            }
        }

        private ComponentListener titlechange;

        /// <summary>
        /// Fires when the series title is changed via setTitle.
        /// Parameters
        /// title : String
        ///     The new title value
        /// index : Number
        ///     The index in the collection of titles
        /// </summary>
        [ListenerArgument(0, "title")]
        [ListenerArgument(1, "index")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("titlechange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the series title is changed via setTitle.")]
        public virtual ComponentListener TitleChange
        {
            get
            {
                return this.titlechange ?? (this.titlechange = new ComponentListener());
            }
        }

        private ComponentListener itemclick;

        /// <summary>
        /// Fires when the user interacts with a marker.
        /// Parameters
        /// item : Sprite
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("itemclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the user interacts with a marker.")]
        public virtual ComponentListener ItemClick
        {
            get
            {
                return this.itemclick ?? (this.itemclick = new ComponentListener());
            }
        }

        private ComponentListener itemmousedown;

        /// <summary>
        /// Fires when the user interacts with a marker.
        /// Parameters
        /// item : Sprite
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("itemmousedown", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the user interacts with a marker.")]
        public virtual ComponentListener ItemMouseDown
        {
            get
            {
                return this.itemmousedown ?? (this.itemmousedown = new ComponentListener());
            }
        }

        private ComponentListener itemmouseup;

        /// <summary>
        /// Fires when the user interacts with a marker.
        /// Parameters
        /// item : Sprite
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("itemmouseup", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the user interacts with a marker.")]
        public virtual ComponentListener ItemMouseUp
        {
            get
            {
                return this.itemmouseup ?? (this.itemmouseup = new ComponentListener());
            }
        }

        private ComponentListener itemmouseout;

        /// <summary>
        /// Fires when the user interacts with a marker.
        /// Parameters
        /// item : Sprite
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("itemmouseout", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the user interacts with a marker.")]
        public virtual ComponentListener ItemMouseOut
        {
            get
            {
                return this.itemmouseout ?? (this.itemmouseout = new ComponentListener());
            }
        }

        private ComponentListener itemmouseover;

        /// <summary>
        /// Fires when the user interacts with a marker.
        /// Parameters
        /// item : Sprite
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("itemmouseover", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the user interacts with a marker.")]
        public virtual ComponentListener ItemMouseOver
        {
            get
            {
                return this.itemmouseover ?? (this.itemmouseover = new ComponentListener());
            }
        }
    }
}

/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    ///<summary>
    ///</summary>
    [ToolboxItem(false)]
    [TypeConverter(typeof(ListenersConverter))]
    public partial class SpriteListeners : ComponentListeners
    {
        private ComponentListener click;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Sprite), "this")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Click
        {
            get
            {
                return this.click ?? (this.click = new ComponentListener());
            }
        }

        private ComponentListener mouseup;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Sprite), "this")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseup", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener MouseUp
        {
            get
            {
                return this.mouseup ?? (this.mouseup = new ComponentListener());
            }
        }

        private ComponentListener mousedown;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Sprite), "this")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mousedown", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener MouseDown
        {
            get
            {
                return this.mousedown ?? (this.mousedown = new ComponentListener());
            }
        }

        private ComponentListener mouseover;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Sprite), "this")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseover", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener MouseOver
        {
            get
            {
                return this.mouseover ?? (this.mouseover = new ComponentListener());
            }
        }

        private ComponentListener mouseout;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Sprite), "this")]
        [ListenerArgument(1, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseout", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener MouseOut
        {
            get
            {
                return this.mouseout ?? (this.mouseout = new ComponentListener());
            }
        }

        private ComponentListener render;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Sprite), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("render", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Render
        {
            get
            {
                return this.render ?? (this.render = new ComponentListener());
            }
        }
    }
}

/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    ///<summary>
    ///</summary>
    public partial class AnimConfigListeners : ComponentListeners
    {
        private ComponentListener afterAnimate;

        /// <summary>
        /// Fires when the animation is complete.
        /// Parameters
        /// item : Ext.fx.Anim
        /// startTime : Date
        /// </summary>
        [ListenerArgument(0, "item", typeof(AnimConfig), "Ext.fx.Anim")]
        [ListenerArgument(1, "startTime", typeof(DateTime), "Date")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("afteranimate", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the animation is complete.")]
        public virtual ComponentListener AfterAnimate
        {
            get
            {
                return this.afterAnimate ?? (this.afterAnimate = new ComponentListener());
            }
        }

        private ComponentListener beforeAnimate;

        /// <summary>
        /// Fires before the animation starts. A handler can return false to cancel the animation.
        /// Parameters
        /// item : Ext.fx.Anim
        /// </summary>
        [ListenerArgument(0, "item", typeof(AnimConfig), "Ext.fx.Anim")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeanimate", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before the animation starts. A handler can return false to cancel the animation.")]
        public virtual ComponentListener BeforeAnimate
        {
            get
            {
                return this.beforeAnimate ?? (this.beforeAnimate = new ComponentListener());
            }
        }

        private ComponentListener lastFrame;

        /// <summary>
        /// Fires when the animation's last frame has been set.
        /// Parameters
        /// item : Ext.fx.Anim
        /// startTime : Date
        /// </summary>
        [ListenerArgument(0, "item", typeof(AnimConfig), "Ext.fx.Anim")]
        [ListenerArgument(1, "startTime", typeof(DateTime), "Date")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("lastframe", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the animation's last frame has been set.")]
        public virtual ComponentListener LastFrame
        {
            get
            {
                return this.lastFrame ?? (this.lastFrame = new ComponentListener());
            }
        }
    }
}

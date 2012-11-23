/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class ResizableListeners : ComponentListeners
    {
        private ComponentListener beforeResize;

        /// <summary>
        /// Fired before resize is allowed. Set enabled to false to cancel resize.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Resizable), "this")]
        [ListenerArgument(1, "e", typeof(object), "The mousedown event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeresize", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired before resize is allowed. Set enabled to false to cancel resize.")]
        public virtual ComponentListener BeforeResize
        {
            get
            {
                if (this.beforeResize == null)
                {
                    this.beforeResize = new ComponentListener();
                }

                return this.beforeResize;
            }
        }

        private ComponentListener resize;

        /// <summary>
        /// Fired after a resize.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Resizable), "this")]
        [ListenerArgument(1, "width", typeof(int), "The new width")]
        [ListenerArgument(2, "height", typeof(int), "The new height")]
        [ListenerArgument(3, "e", typeof(object), "The mousedown event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("resize", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a resize.")]
        public virtual ComponentListener Resize
        {
            get
            {
                if (this.resize == null)
                {
                    this.resize = new ComponentListener();
                }

                return this.resize;
            }
        }
    }
}
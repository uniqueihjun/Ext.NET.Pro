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
    public partial class BoxComponentListeners : ComponentBaseListeners
    {
        private ComponentListener move;

        /// <summary>
        /// Fires after the component is resized.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [ListenerArgument(1, "x", typeof(int), "The new x position")]
        [ListenerArgument(2, "y", typeof(int), "The new y position")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("move", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the component is resized.")]
        public virtual ComponentListener Move
        {
            get
            {
                if (this.move == null)
                {
                    this.move = new ComponentListener();
                }

                return this.move;
            }
        }

        private ComponentListener resize;

        /// <summary>
        /// Fires after the component is resized.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [ListenerArgument(1, "adjWidth", typeof(int), "The box-adjusted width that was set")]
        [ListenerArgument(2, "adjHeight", typeof(Component), "The box-adjusted height that was set")]
        [ListenerArgument(3, "rawWidth", typeof(Component), "The width that was originally specified")]
        [ListenerArgument(4, "rawHeight", typeof(Component), "The height that was originally specified")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("resize", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the component is resized.")]
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
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
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BoxReordererListeners : ComponentListeners
    {
        private ComponentListener startDrag;

        /// <summary>
        /// Fires when dragging of a child Component begins.
        ///     - item
        ///       this 
        ///     - container 
        ///       The owning Container
        ///     - dragCmp 
        ///       The Component being dragged
        ///     - idx 
        ///       The start index of the Component being dragged.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "container")]
        [ListenerArgument(2, "dragCmp")]
        [ListenerArgument(3, "idx")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("StartDrag", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when dragging of a child Component begins.")]
        public virtual ComponentListener StartDrag
        {
            get
            {
                return this.startDrag ?? (this.startDrag = new ComponentListener());
            }
        }

        private ComponentListener drag;

        /// <summary>
        /// Fires during dragging of a child Component.
        ///     - item
        ///       this 
        ///     - container 
        ///       The owning Container
        ///     - dragCmp 
        ///       The Component being dragged
        ///     - startIdx 
        ///       The index position from which the Component was initially dragged.
        ///     - idx 
        ///       The current closest index to which the Component would drop.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "container")]
        [ListenerArgument(2, "dragCmp")]
        [ListenerArgument(3, "startIdx")]
        [ListenerArgument(4, "idx")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("Drag", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires during dragging of a child Component.")]
        public virtual ComponentListener Drag
        {
            get
            {
                return this.drag ?? (this.drag = new ComponentListener());
            }
        }

        private ComponentListener changeIndex;

        /// <summary>
        /// Fires when dragging of a child Component causes its drop index to change.
        ///     - item
        ///       this 
        ///     - container 
        ///       The owning Container
        ///     - dragCmp 
        ///       The Component being dragged
        ///     - startIdx 
        ///       The index position from which the Component was initially dragged.
        ///     - idx 
        ///       The current closest index to which the Component would drop.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "container")]
        [ListenerArgument(2, "dragCmp")]
        [ListenerArgument(3, "startIdx")]
        [ListenerArgument(4, "idx")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("ChangeIndex", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when dragging of a child Component causes its drop index to change.")]
        public virtual ComponentListener ChangeIndex
        {
            get
            {
                return this.changeIndex ?? (this.changeIndex = new ComponentListener());
            }
        }

        private ComponentListener drop;

        /// <summary>
        /// Fires when a child Component is dropped at a new index position.
        ///     - item
        ///       this 
        ///     - container 
        ///       The owning Container
        ///     - dragCmp 
        ///       The Component being dragged
        ///     - startIdx 
        ///       The index position from which the Component was initially dragged.
        ///     - idx 
        ///       The index at which the Component is being dropped.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "container")]
        [ListenerArgument(2, "dragCmp")]
        [ListenerArgument(3, "startIdx")]
        [ListenerArgument(4, "idx")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("Drop", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a child Component is dropped at a new index position.")]
        public virtual ComponentListener Drop
        {
            get
            {
                return this.drop ?? (this.drop = new ComponentListener());
            }
        }
    }
}
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
    public partial class ComponentColumnListeners : ColumnListeners
    {
        private ComponentListener pin;

        /// <summary>
        /// Fires when a over component is pinned
        /// Parameters:
        ///    - item
        ///         Current column
        ///    - cmp
        ///         Over component 
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "cmp")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("pin", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a over component is pinned")]
        public virtual ComponentListener Pin
        {
            get
            {
                return this.pin ?? (this.pin = new ComponentListener());
            }
        }

        private ComponentListener unpin;

        /// <summary>
        /// Fires when a over component is unpinned
        /// Parameters:
        ///    - item
        ///         Current column
        ///    - cmp
        ///         Over component 
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "cmp")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("unpin", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a over component is unpinned")]
        public virtual ComponentListener Unpin
        {
            get
            {
                return this.unpin ?? (this.unpin = new ComponentListener());
            }
        }

        private ComponentListener bind;

        /// <summary>
        /// Fires when a component is bound to a record. Return false to cancel component showing for this record
        /// Parameters:
        ///    - item
        ///         Current column
        ///    - cmp
        ///         Component 
        ///    - record
        ///    - rowIndex
        ///    - grid
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "cmp")]
        [ListenerArgument(2, "record")]
        [ListenerArgument(3, "rowIndex")]
        [ListenerArgument(4, "grid")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("bind", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a component is bound to a record. Return false to cancel component showing for this record")]
        public virtual ComponentListener Bind
        {
            get
            {
                return this.bind ?? (this.bind = new ComponentListener());
            }
        }

        private ComponentListener unbind;

        /// <summary>
        /// Fires when a component is unbound from a record.
        /// Parameters:
        ///    - item
        ///         Current column
        ///    - cmp
        ///         Component 
        ///    - record
        ///    - rowIndex
        ///    - grid
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "cmp")]
        [ListenerArgument(2, "record")]
        [ListenerArgument(3, "rowIndex")]
        [ListenerArgument(4, "grid")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("unbind", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a component is unbound from a record.")]
        public virtual ComponentListener Unbind
        {
            get
            {
                return this.unbind ?? (this.unbind = new ComponentListener());
            }
        }
    }
}

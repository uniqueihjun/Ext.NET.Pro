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
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class SplitButtonDirectEvents : ButtonDirectEvents
    {
        public SplitButtonDirectEvents() { }

        public SplitButtonDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent arrowClick;

        /// <summary>
        /// Fires when this button's arrow is clicked.
        /// Parameters
        /// item : Ext.button.Split
        /// e : Event
        /// The click event
        /// </summary>
        [ListenerArgument(0, "item", typeof(SplitButton), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("arrowclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this button's arrow is clicked.")]
        public virtual ComponentDirectEvent ArrowClick
        {
            get
            {
                return this.arrowClick ?? (this.arrowClick = new ComponentDirectEvent(this));
            }
        }
    }
}
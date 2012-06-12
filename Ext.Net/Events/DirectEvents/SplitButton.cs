/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
        private ComponentDirectEvent arrowClick;

        /// <summary>
        /// Fires when this button's arrow is clicked.
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
                if (this.arrowClick == null)
                {
                    this.arrowClick = new ComponentDirectEvent();
                }

                return this.arrowClick;
            }
        }
    }
}
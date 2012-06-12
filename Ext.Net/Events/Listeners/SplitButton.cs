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
    public partial class SplitButtonListeners : ButtonListeners
    {
        private ComponentListener arrowClick;

        /// <summary>
        /// Fires when this button's arrow is clicked.
        /// </summary>
        [ListenerArgument(0, "item", typeof(SplitButton), "this")]
        [ListenerArgument(1, "e", typeof(object), "The click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("arrowclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when this button's arrow is clicked.")]
        public virtual ComponentListener ArrowClick
        {
            get
            {
                if (this.arrowClick == null)
                {
                    this.arrowClick = new ComponentListener();
                }

                return this.arrowClick;
            }
        }
    }
}
/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class TriggerFieldListeners : TextFieldListeners
    {
        private ComponentListener triggerClick;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This trigger field")]
        [ListenerArgument(1, "trigger", typeof(object), "trigger")]
        [ListenerArgument(2, "index", typeof(int), "trigger index")]
        [ListenerArgument(3, "tag", typeof(string), "trigger tag")]
        [ListenerArgument(4, "e", typeof(int), "click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("triggerclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener TriggerClick
        {
            get
            {
                if (this.triggerClick == null)
                {
                    this.triggerClick = new ComponentListener();
                }

                return this.triggerClick;
            }
        }
    }
}
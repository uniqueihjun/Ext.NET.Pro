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
    public partial class TriggerFieldDirectEvents : TextFieldDirectEvents
    {
        private ComponentDirectEvent triggerClick;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This trigger field")]
        [ListenerArgument(1, "trigger", typeof(object), "trigger")]
        [ListenerArgument(2, "index", typeof(int), "trigger index")]
        [ListenerArgument(3, "tag", typeof(string), "trigger tag")]
        [ListenerArgument(4, "e", typeof(int), "click event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("triggerclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent TriggerClick
        {
            get
            {
                if (this.triggerClick == null)
                {
                    this.triggerClick = new ComponentDirectEvent();
                }

                return this.triggerClick;
            }
        }
    }
}
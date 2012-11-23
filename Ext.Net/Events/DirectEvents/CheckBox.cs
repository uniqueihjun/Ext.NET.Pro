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
    public partial class CheckboxDirectEvents : FieldDirectEvents
    {
        private ComponentDirectEvent check;

        /// <summary>
        /// Fires when the Checkbox is checked or unchecked.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Checkbox), "this")]
        [ListenerArgument(1, "checked", typeof(bool), "The new checked value")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("check", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the Checkbox is checked or unchecked.")]
        public virtual ComponentDirectEvent Check
        {
            get
            {
                if (this.check == null)
                {
                    this.check = new ComponentDirectEvent();
                }

                return this.check;
            }
        }
    }
}
/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class RadioGroupDirectEvents : CheckboxGroupDirectEvents
    {
        private ComponentDirectEvent change;

        /// <summary>
        /// Fires when the state of a child radio changes.
        /// </summary>
        [ListenerArgument(0, "item", typeof(RadioGroup), "this")]
        [ListenerArgument(1, "checked", typeof(Radio), "The checked radio")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("change", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the state of a child radio changes.")]
        public override ComponentDirectEvent Change
        {
            get
            {
                if (this.change == null)
                {
                    this.change = new ComponentDirectEvent();
                }

                return this.change;
            }
        }
    }
}
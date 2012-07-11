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
    public partial class DateMenuListeners : MenuListeners
    {
        private ComponentListener select;

		/// <summary>
        /// Fires when a date is selected
        /// Parameters
        /// item : Ext.picker.Date
        ///     DatePicker
        /// date : Date
        ///     The selected date
		/// </summary>
        [ListenerArgument(0, "item", typeof(DatePicker), "picker")]
        [ListenerArgument(1, "date", typeof(object), "Date")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
		[Description("")]
        public virtual ComponentListener Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentListener());
            }
        }
    }
}
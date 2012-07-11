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
    public partial class ColorMenuDirectEvents : MenuDirectEvents
    {
        public ColorMenuDirectEvents() { }

        public ColorMenuDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent select;

        /// <summary>
        /// Fires when a color is selected
        /// Parameters
        /// item : Ext.picker.Color
        /// color : String
        ///     The 6-digit color hex code (without the # symbol)
        /// </summary>
        [ListenerArgument(0, "item", typeof(ColorPicker), "palette")]
        [ListenerArgument(1, "color", typeof(object), "color")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentDirectEvent(this));
            }
        }
    }
}
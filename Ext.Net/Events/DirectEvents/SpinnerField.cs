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
    public partial class SpinnerFieldDirectEvents : TextFieldDirectEvents
    {
        private ComponentDirectEvent spin;

        /// <summary>
        /// Fires when the autosize function is triggered. The field may or may not have actually changed size according to the default logic, but this event provides a hook for the developer to apply additional logic at runtime to resize the field if needed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This text field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spin", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the autosize function is triggered. The field may or may not have actually changed size according to the default logic, but this event provides a hook for the developer to apply additional logic at runtime to resize the field if needed.")]
        public virtual ComponentDirectEvent Spin
        {
            get
            {
                if (this.spin == null)
                {
                    this.spin = new ComponentDirectEvent();
                }

                return this.spin;
            }
        }

        private ComponentDirectEvent spinup;

        /// <summary>
        /// Fires when the autosize function is triggered. The field may or may not have actually changed size according to the default logic, but this event provides a hook for the developer to apply additional logic at runtime to resize the field if needed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This text field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spinup", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the autosize function is triggered. The field may or may not have actually changed size according to the default logic, but this event provides a hook for the developer to apply additional logic at runtime to resize the field if needed.")]
        public virtual ComponentDirectEvent SpinUp
        {
            get
            {
                if (this.spinup == null)
                {
                    this.spinup = new ComponentDirectEvent();
                }

                return this.spinup;
            }
        }

        private ComponentDirectEvent spindown;

        /// <summary>
        /// Fires when the autosize function is triggered. The field may or may not have actually changed size according to the default logic, but this event provides a hook for the developer to apply additional logic at runtime to resize the field if needed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This text field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spindown", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the autosize function is triggered. The field may or may not have actually changed size according to the default logic, but this event provides a hook for the developer to apply additional logic at runtime to resize the field if needed.")]
        public virtual ComponentDirectEvent SpinDown
        {
            get
            {
                if (this.spindown == null)
                {
                    this.spindown = new ComponentDirectEvent();
                }

                return this.spindown;
            }
        }
    }
}
/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class SpinnerFieldDirectEvents : TriggerFieldDirectEvents
    {
        public SpinnerFieldDirectEvents() { }

        public SpinnerFieldDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent spin;

        /// <summary>
        /// Fires when the spinner is made to spin up or down.
        /// Parameters
        /// item : Ext.form.field.Spinner
        /// direction : String
        ///     Either 'up' if spinning up, or 'down' if spinning down.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This field")]
        [ListenerArgument(1, "direction")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spin", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Spin
        {
            get
            {
                return this.spin ?? (this.spin = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent spinup;

        /// <summary>
        /// Fires when the spinner is made to spin up.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This trigger field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spinup", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent SpinUp
        {
            get
            {
                return this.spinup ?? (this.spinup = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent spindown;

        /// <summary>
        /// Fires when the spinner is made to spin down.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This trigger field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spindown", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent SpinDown
        {
            get
            {
                return this.spindown ?? (this.spindown = new ComponentDirectEvent(this));
            }
        }
    }
}
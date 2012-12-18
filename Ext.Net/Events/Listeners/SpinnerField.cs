/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class SpinnerFieldListeners : TriggerFieldListeners
    {
        private ComponentListener spin;

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
        [ConfigOption("spin", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener Spin
        {
            get
            {
                return this.spin ?? (this.spin = new ComponentListener());
            }
        }

        private ComponentListener spinup;

        /// <summary>
        /// Fires when the spinner is made to spin up.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This trigger field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spinup", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener SpinUp
        {
            get
            {
                return this.spinup ?? (this.spinup = new ComponentListener());
            }
        }

        private ComponentListener spindown;

        /// <summary>
        /// Fires when the spinner is made to spin down.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This trigger field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("spindown", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener SpinDown
        {
            get
            {
                return this.spindown ?? (this.spindown = new ComponentListener());
            }
        }
    }
}
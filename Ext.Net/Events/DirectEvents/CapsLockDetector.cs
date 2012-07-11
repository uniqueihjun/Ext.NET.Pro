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
    public partial class CapsLockDetectorDirectEvents : ComponentDirectEvents
    {
        public CapsLockDetectorDirectEvents() { }

        public CapsLockDetectorDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent capslockon;

        /// <summary>
        /// Fires when capslock is detected.
        /// Parameters
        /// item : plugin
        /// </summary>
        [ListenerArgument(0, "item", typeof(CapsLockDetector), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("capslockon", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent CapsLockOn
        {
            get
            {
                return this.capslockon ?? (this.capslockon = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent capslockoff;

        /// <summary>
        /// Fires when capslock deactivating is detected.
        /// Parameters
        /// item : plugin
        /// </summary>
        [ListenerArgument(0, "item", typeof(CapsLockDetector), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("capslockoff", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent CapsLockOff
        {
            get
            {
                return this.capslockoff ?? (this.capslockoff = new ComponentDirectEvent(this));
            }
        }
    }
}
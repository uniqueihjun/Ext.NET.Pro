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
    public partial class CapsLockDetectorListeners : ComponentListeners
    {
        private ComponentListener capslockon;

        /// <summary>
        /// Fires when capslock is detected.
        /// Parameters
        /// item : plugin
        /// </summary>
        [ListenerArgument(0, "item", typeof(CapsLockDetector), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("capslockon", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener CapsLockOn
        {
            get
            {
                return this.capslockon ?? (this.capslockon = new ComponentListener());
            }
        }

        private ComponentListener capslockoff;

        /// <summary>
        /// Fires when capslock deactivating is detected.
        /// Parameters
        /// item : plugin
        /// </summary>
        [ListenerArgument(0, "item", typeof(CapsLockDetector), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("capslockoff", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentListener CapsLockOff
        {
            get
            {
                return this.capslockoff ?? (this.capslockoff = new ComponentListener());
            }
        }
    }
}
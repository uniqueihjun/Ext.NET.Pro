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
    public partial class FlashComponentDirectEvents : AbstractComponentDirectEvents
    {
        public FlashComponentDirectEvents() { }

        public FlashComponentDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent failure;

        /// <summary>
        /// Fired when the Flash movie embedding fails
        /// Parameters
        ///     item : Ext.flash.Component
        /// </summary>
        [ListenerArgument(0, "item", typeof(FlashComponent), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("failure", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired when the Flash movie embedding fails")]
        public virtual ComponentDirectEvent Failure
        {
            get
            {
                return this.failure ?? (this.failure = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent success;

        /// <summary>
        /// Fired when the Flash movie has been successfully embedded
        /// Parameters
        ///     item : Ext.flash.Component
        /// </summary>
        [ListenerArgument(0, "item", typeof(FlashComponent), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("success", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired when the Flash movie has been successfully embedded")]
        public virtual ComponentDirectEvent Success
        {
            get
            {
                return this.success ?? (this.success = new ComponentDirectEvent(this));
            }
        }
    }
}
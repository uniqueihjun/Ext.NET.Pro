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
    public partial class CheckMenuItemDirectEvents : BaseMenuItemDirectEvents
    {
        private ComponentDirectEvent beforeCheckChange;

        /// <summary>
        /// Fires before the checked value is set, providing an opportunity to cancel if needed
        /// </summary>
        [ListenerArgument(0, "item", typeof(CheckMenuItem), "this")]
        [ListenerArgument(1, "checked", typeof(bool), "checked")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforecheckchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before the checked value is set, providing an opportunity to cancel if needed")]
        public virtual ComponentDirectEvent BeforeCheckChange
        {
            get
            {
                if (this.beforeCheckChange == null)
                {
                    this.beforeCheckChange = new ComponentDirectEvent();
                }

                return this.beforeCheckChange;
            }
        }

        private ComponentDirectEvent checkChange;

        /// <summary>
        /// Fires after the checked value has been set
        /// </summary>
        [ListenerArgument(0, "item", typeof(CheckMenuItem), "this")]
        [ListenerArgument(1, "checked", typeof(bool), "checked")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("checkchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the checked value has been set")]
        public virtual ComponentDirectEvent CheckChange
        {
            get
            {
                if (this.checkChange == null)
                {
                    this.checkChange = new ComponentDirectEvent();
                }

                return this.checkChange;
            }
        }
    }
}
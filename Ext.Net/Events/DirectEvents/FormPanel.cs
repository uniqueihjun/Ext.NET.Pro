/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    public partial class FormPanelDirectEvents : PanelDirectEvents
    {
        private ComponentDirectEvent clientValidation;

        /// <summary>
        /// If the monitorValid config option is true, this event fires repetitively to notify of valid state
        /// </summary>
        [ListenerArgument(0, "item", typeof(FormPanel))]
        [ListenerArgument(1, "valid")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("clientvalidation", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("If the monitorValid config option is true, this event fires repetitively to notify of valid state")]
        public virtual ComponentDirectEvent ClientValidation
        {
            get
            {
                if (this.clientValidation == null)
                {
                    this.clientValidation = new ComponentDirectEvent();
                }

                return this.clientValidation;
            }
        }

        private ComponentDirectEvent actionComplete;

        /// <summary>
        /// Fires when an action is completed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(FormPanel))]
        [ListenerArgument(1, "action")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("actioncomplete", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when an action is completed.")]
        public virtual ComponentDirectEvent ActionComplete
        {
            get
            {
                if (this.actionComplete == null)
                {
                    this.actionComplete = new ComponentDirectEvent();
                }

                return this.actionComplete;
            }
        }

        private ComponentDirectEvent actionFailed;

        /// <summary>
        /// Fires when an action fails.
        /// </summary>
        [ListenerArgument(0, "item", typeof(FormPanel))]
        [ListenerArgument(1, "action")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("actionfailed", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when an action fails.")]
        public virtual ComponentDirectEvent ActionFailed
        {
            get
            {
                if (this.actionFailed == null)
                {
                    this.actionFailed = new ComponentDirectEvent();
                }

                return this.actionFailed;
            }
        }

        private ComponentDirectEvent beforeAction;

        /// <summary>
        /// Fires before any action is performed. Return false to cancel the action.
        /// </summary>
        [ListenerArgument(0, "item", typeof(FormPanel))]
        [ListenerArgument(1, "action")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeaction", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before any action is performed. Return false to cancel the action.")]
        public virtual ComponentDirectEvent BeforeAction
        {
            get
            {
                if (this.beforeAction == null)
                {
                    this.beforeAction = new ComponentDirectEvent();
                }

                return this.beforeAction;
            }
        }
    }
}
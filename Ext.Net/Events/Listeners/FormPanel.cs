/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class FormPanelListeners : PanelListeners
    {
        private ComponentListener clientValidation;

        /// <summary>
        /// If the monitorValid config option is true, this event fires repetitively to notify of valid state
        /// </summary>
        [ListenerArgument(0, "item", typeof(FormPanel))]
        [ListenerArgument(1, "valid")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("clientvalidation", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("If the monitorValid config option is true, this event fires repetitively to notify of valid state")]
        public virtual ComponentListener ClientValidation
        {
            get
            {
                if (this.clientValidation == null)
                {
                    this.clientValidation = new ComponentListener();
                }

                return this.clientValidation;
            }
        }

        private ComponentListener actionComplete;

        /// <summary>
        /// Fires when an action is completed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(FormPanel))]
        [ListenerArgument(1, "action")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("actioncomplete", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when an action is completed.")]
        public virtual ComponentListener ActionComplete
        {
            get
            {
                if (this.actionComplete == null)
                {
                    this.actionComplete = new ComponentListener();
                }

                return this.actionComplete;
            }
        }

        private ComponentListener actionFailed;

        /// <summary>
        /// Fires when an action fails.
        /// </summary>
        [ListenerArgument(0, "item", typeof(FormPanel))]
        [ListenerArgument(1, "action")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("actionfailed", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when an action fails.")]
        public virtual ComponentListener ActionFailed
        {
            get
            {
                if (this.actionFailed == null)
                {
                    this.actionFailed = new ComponentListener();
                }

                return this.actionFailed;
            }
        }

        private ComponentListener beforeAction;

        /// <summary>
        /// Fires before any action is performed. Return false to cancel the action.
        /// </summary>
        [ListenerArgument(0, "item", typeof(FormPanel))]
        [ListenerArgument(1, "action")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeaction", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before any action is performed. Return false to cancel the action.")]
        public virtual ComponentListener BeforeAction
        {
            get
            {
                if (this.beforeAction == null)
                {
                    this.beforeAction = new ComponentListener();
                }

                return this.beforeAction;
            }
        }
    }
}
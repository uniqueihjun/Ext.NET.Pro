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
    public partial class GroupTabDirectEvents : ContainerDirectEvents
    {
        private ComponentDirectEvent activate;

        /// <summary>
        /// Fires after tab is activated.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("activate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after tab is activated.")]
        public virtual ComponentDirectEvent Activate
        {
            get
            {
                if (this.activate == null)
                {
                    this.activate = new ComponentDirectEvent();
                }

                return this.activate;
            }
        }

        private ComponentDirectEvent deactivate;

        /// <summary>
        /// Fires after tab is deactivated.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("deactivate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after tab is deactivated.")]
        public virtual ComponentDirectEvent Deactivate
        {
            get
            {
                if (this.deactivate == null)
                {
                    this.deactivate = new ComponentDirectEvent();
                }

                return this.deactivate;
            }
        }

        private ComponentDirectEvent changeMainItem;

        /// <summary>
        /// Fires after main item is changed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [ListenerArgument(1, "newItem", typeof(Component), "newItem")]
        [ListenerArgument(2, "oldItem", typeof(Component), "oldItem")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("changemainitem", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after main item is changed.")]
        public virtual ComponentDirectEvent ChangeMainItem
        {
            get
            {
                if (this.changeMainItem == null)
                {
                    this.changeMainItem = new ComponentDirectEvent();
                }

                return this.changeMainItem;
            }
        }

        private ComponentDirectEvent beforeTabChange;

        /// <summary>
        /// Fires before tab is changed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [ListenerArgument(1, "newTab", typeof(Component), "newTab")]
        [ListenerArgument(2, "tab", typeof(Component), "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before tab is changed.")]
        public virtual ComponentDirectEvent BeforeTabChange
        {
            get
            {
                if (this.beforeTabChange == null)
                {
                    this.beforeTabChange = new ComponentDirectEvent();
                }

                return this.beforeTabChange;
            }
        }

        private ComponentDirectEvent tabChange;

        /// <summary>
        /// Fires after tab is changed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Component), "this")]
        [ListenerArgument(1, "tab", typeof(Component), "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("tabchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after tab is changed.")]
        public virtual ComponentDirectEvent TabChange
        {
            get
            {
                if (this.tabChange == null)
                {
                    this.tabChange = new ComponentDirectEvent();
                }

                return this.tabChange;
            }
        }
    }
}
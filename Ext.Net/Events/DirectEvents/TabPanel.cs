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
    public partial class TabPanelDirectEvents : PanelDirectEvents
    {
        private ComponentDirectEvent beforeTabChange;

        /// <summary>
        /// Fires before the active tab changes. Handlers can return false to cancel the tab change.
        /// </summary>
        [ListenerArgument(0, "item", typeof(TabPanel), "this")]
        [ListenerArgument(1, "newTab", typeof(Panel), "The tab being activated")]
        [ListenerArgument(2, "currentTab", typeof(Panel), "The current active tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before the active tab changes. Handlers can return false to cancel the tab change.")]
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

        private ComponentDirectEvent contextMenu;

        /// <summary>
        /// Fires when the original browser contextmenu event originated from a tab element.
        /// </summary>
        [ListenerArgument(0, "item", typeof(TabPanel), "this")]
        [ListenerArgument(1, "tab", typeof(Panel), "The target tab")]
        [ListenerArgument(2, "e", typeof(object), "EventObject")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("contextmenu", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the original browser contextmenu event originated from a tab element.")]
        public virtual ComponentDirectEvent ContextMenu 
        {
            get
            {
                if (this.contextMenu == null)
                {
                    this.contextMenu = new ComponentDirectEvent();
                }

                return this.contextMenu;
            }
        }

        private ComponentDirectEvent tabChange;

        /// <summary>
        /// Fires after the active tab has changed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(TabPanel), "this")]
        [ListenerArgument(1, "tab", typeof(Panel), "The new active tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("tabchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the active tab has changed.")]
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

        private ComponentDirectEvent beforeTabClose;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(PanelBase), "tabpanel")]
        [ListenerArgument(1, "tab", typeof(PanelBase), "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabclose", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeTabClose
        {
            get
            {
                if (this.beforeTabClose == null)
                {
                    this.beforeTabClose = new ComponentDirectEvent();
                }

                return this.beforeTabClose;
            }
        }

        private ComponentDirectEvent beforeTabHide;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(PanelBase), "tabpanel")]
        [ListenerArgument(1, "tab", typeof(PanelBase), "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabhide", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeTabHide
        {
            get
            {
                if (this.beforeTabHide == null)
                {
                    this.beforeTabHide = new ComponentDirectEvent();
                }

                return this.beforeTabHide;
            }
        }

        private ComponentDirectEvent tabClose;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(PanelBase), "tabpanel")]
        [ListenerArgument(1, "tab", typeof(PanelBase), "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("tabclose", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent TabClose
        {
            get
            {
                if (this.tabClose == null)
                {
                    this.tabClose = new ComponentDirectEvent();
                }

                return this.tabClose;
            }
        }

        private ComponentDirectEvent beforeTabMenuShow;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(TabPanel), "el")]
        [ListenerArgument(0, "tab", typeof(PanelBase), "tab")]
        [ListenerArgument(0, "menu", typeof(MenuBase), "menu")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabmenushow", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeTabMenuShow
        {
            get
            {
                if (this.beforeTabMenuShow == null)
                {
                    this.beforeTabMenuShow = new ComponentDirectEvent();
                }

                return this.beforeTabMenuShow;
            }
        }
    }
}
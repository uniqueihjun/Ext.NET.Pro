/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
        public TabPanelDirectEvents() { }

        public TabPanelDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforeTabChange;

        /// <summary>
        /// Fires before a tab change (activated by setActiveTab). Return false in any listener to cancel the tabchange
        /// Parameters
        /// item : Ext.tab.Panel
        ///     The TabPanel
        /// newTab : Ext.Component
        ///     The tab that is about to be activated
        /// oldTab : Ext.Component
        ///     The tab that is currently active
        /// eOpts : Object
        ///     The options object passed to Ext.util.Observable.addListener.
        /// </summary>
        [ListenerArgument(0, "item", typeof(TabPanel), "this")]
        [ListenerArgument(1, "newTab", typeof(AbstractPanel), "The tab being activated")]
        [ListenerArgument(2, "oldTab", typeof(AbstractPanel), "The card that is currently active")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a tab change (activated by setActiveTab). Return false in any listener to cancel the tabchange")]
        public virtual ComponentDirectEvent BeforeTabChange
        {
            get
            {
                return this.beforeTabChange ?? (this.beforeTabChange = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent tabChange;

        /// <summary>
        /// Fires when a new tab has been activated (activated by setActiveTab).
        /// Parameters
        /// item : Ext.tab.Panel
        ///     The TabPanel
        /// newTab : Ext.Component
        ///     The newly activated item
        /// oldTab : Ext.Component
        /// The previously active item
        /// eOpts : Object
        /// The options object passed to Ext.util.Observable.addListener.
        /// </summary>
        [ListenerArgument(0, "item", typeof(TabPanel), "this")]
        [ListenerArgument(1, "newTab", typeof(AbstractPanel), "The tab being activated")]
        [ListenerArgument(2, "oldTab", typeof(AbstractPanel), "The tab that is currently active")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("tabchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a new tab has been activated (activated by setActiveTab).")]
        public virtual ComponentDirectEvent TabChange
        {
            get
            {
                return this.tabChange ?? (this.tabChange = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent beforeTabClose;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(AbstractPanel), "tabpanel")]
        [ListenerArgument(1, "tab", typeof(AbstractPanel), "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabclose", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeTabClose
        {
            get
            {
                return this.beforeTabClose ?? (this.beforeTabClose = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent beforeTabHide;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(AbstractPanel), "tabpanel")]
        [ListenerArgument(1, "tab", typeof(AbstractPanel), "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforetabhide", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent BeforeTabHide
        {
            get
            {
                return this.beforeTabHide ?? (this.beforeTabHide = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent tabClose;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(AbstractPanel), "tabpanel")]
        [ListenerArgument(1, "tab", typeof(AbstractPanel), "tab")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("tabclose", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent TabClose
        {
            get
            {
                return this.tabClose ?? (this.tabClose = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent beforeTabMenuShow;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(TabPanel), "el")]
        [ListenerArgument(0, "tab", typeof(AbstractPanel), "tab")]
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
                return this.beforeTabMenuShow ?? (this.beforeTabMenuShow = new ComponentDirectEvent(this));
            }
        }
    }
}
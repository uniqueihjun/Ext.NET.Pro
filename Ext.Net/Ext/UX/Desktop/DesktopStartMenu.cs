/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    public partial class DesktopStartMenu : Panel
    {
        /// <summary>
        /// 
        /// </summary>
        public DesktopStartMenu()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DesktopStartMenu")]
        [DefaultValue("bl-tl")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string DefaultAlign
        {
            get
            {
                return this.State.Get<string>("DefaultAlign", "bl-tl");
            }
            set
            {
                this.State.Set("DefaultAlign", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DesktopStartMenu")]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool HideTools
        {
            get
            {
                return this.State.Get<bool>("HideTools", false);
            }
            set
            {
                this.State.Set("HideTools", value);
            }
        }

        private ItemsCollection<AbstractComponent> menuItems;

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("menu", typeof(ItemCollectionJsonConverter))]
        [Category("6. DesktopStartMenu")]
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual ItemsCollection<AbstractComponent> MenuItems
        {
            get
            {
                if (this.menuItems == null)
                {
                    this.menuItems = new ItemsCollection<AbstractComponent>();
                    this.menuItems.AfterItemAdd += this.AfterItemAdd;
                    this.menuItems.AfterItemRemove += this.AfterItemRemove;
                    this.menuItems.SingleItemMode = false;
                }

                return this.menuItems;
            }
        }

        private ToolbarCollection toolConfig;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("toolConfig", typeof(SingleItemCollectionJsonConverter))]
        [Category("6. DesktopStartMenu")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual ToolbarCollection ToolConfig
        {
            get
            {
                if (this.toolConfig == null)
                {
                    this.toolConfig = new ToolbarCollection();
                    this.toolConfig.AfterItemAdd += this.AfterItemAdd;
                    this.toolConfig.AfterItemRemove += this.AfterItemRemove;
                }

                return this.toolConfig;
            }
        }
    }
}
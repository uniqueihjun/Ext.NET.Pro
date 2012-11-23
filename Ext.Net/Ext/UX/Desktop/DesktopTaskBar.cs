/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class DesktopTaskBar : Toolbar
    {
        /// <summary>
        /// 
        /// </summary>
        public DesktopTaskBar()
        {
        }

        private ToolbarCollection quickStartConfig;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("quickStartConfig", typeof(SingleItemCollectionJsonConverter))]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual ToolbarCollection QuickStart
        {
            get
            {
                if (this.quickStartConfig == null)
                {
                    this.quickStartConfig = new ToolbarCollection();
                    this.quickStartConfig.AfterItemAdd += this.AfterItemAdd;
                    this.quickStartConfig.AfterItemRemove += this.AfterItemRemove;
                }

                return this.quickStartConfig;
            }
        }

        private ToolbarCollection trayConfig;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("trayConfig", typeof(SingleItemCollectionJsonConverter))]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual ToolbarCollection Tray
        {
            get
            {
                if (this.trayConfig == null)
                {
                    this.trayConfig = new ToolbarCollection();
                    this.trayConfig.AfterItemAdd += this.AfterItemAdd;
                    this.trayConfig.AfterItemRemove += this.AfterItemRemove;
                }

                return this.trayConfig;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool HideQuickStart
        {
            get
            {
                return this.State.Get<bool>("HideQuickStart", false);
            }
            set
            {
                this.State.Set("HideQuickStart", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool HideTray
        {
            get
            {
                return this.State.Get<bool>("HideTray", false);
            }
            set
            {
                this.State.Set("HideTray", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(60)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual int QuickStartWidth
        {
            get
            {
                return this.State.Get<int>("QuickStartWidth", 60);
            }
            set
            {
                this.State.Set("QuickStartWidth", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(80)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual int TrayWidth
        {
            get
            {
                return this.State.Get<int>("TrayWidth", 80);
            }
            set
            {
                this.State.Set("TrayWidth", value);
            }
        }

        private TrayClock trayClock;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("trayClock", typeof(LazyControlJsonConverter))]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual TrayClock TrayClock
        {
            get
            {
                if (this.trayClock == null)
                {
                    this.trayClock = new TrayClock();                    
                }

                return this.trayClock;
            }
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            this.Controls.Add(this.TrayClock);
            this.LazyItems.Add(this.TrayClock);
        }
    }
}
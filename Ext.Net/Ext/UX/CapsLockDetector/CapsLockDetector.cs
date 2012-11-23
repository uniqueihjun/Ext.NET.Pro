/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(ValidationStatus), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:CapsLockDetector runat=\"server\" />")]
    [Description("")]
    public partial class CapsLockDetector : Plugin, IIcon
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CapsLockDetector() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                baseList.Add(new ClientScriptItem(typeof(CapsLockDetector), "Ext.Net.Build.Ext.Net.ux.capslockdetector.capslockdetector.js", "/ux/capslockdetector/capslockdetector.js"));

                return baseList;
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.net.CapsLockDetector";
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
        public virtual bool PreventCapsLockChar
        {
            get
            {
                return this.State.Get<bool>("PreventCapsLockChar", false);
            }
            set
            {
                this.State.Set("PreventCapsLockChar", value);
            }
        }

        /// <summary>
        /// The error icon
        /// </summary>
        [Meta]
        [Category("3. CapsLockDetector")]
        [DefaultValue(Icon.None)]
        [Description("The error icon")]
        public virtual Icon CapsLockIndicatorIcon
        {
            get
            {
                return this.State.Get<Icon>("CapsLockIndicatorIcon", Icon.None);
            }
            set
            {
                this.State.Set("CapsLockIndicatorIcon", value);
            }
        }

        /// <summary>
        /// The error icon css class
        /// </summary>
        [Meta]
        [Category("3. CapsLockDetector")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string CapsLockIndicatorIconCls
        {
            get
            {
                return this.State.Get<string>("CapsLockIndicatorIconCls", "");
            }
            set
            {
                this.State.Set("CapsLockIndicatorIconCls", value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("capsLockIndicatorIconCls")]
        [DefaultValue("")]
		[Description("")]
        protected virtual string CapsLockIndicatorIconClsProxy
        {
            get
            {
                if (this.CapsLockIndicatorIcon != Icon.None)
                {
                    return ResourceManager.GetIconRequester(this.CapsLockIndicatorIcon);
                }

                return this.CapsLockIndicatorIconCls;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. CapsLockDetector")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string CapsLockIndicatorText
        {
            get
            {
                return this.State.Get<string>("CapsLockIndicatorText", "");
            }
            set
            {
                this.State.Set("CapsLockIndicatorText", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. CapsLockDetector")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string CapsLockIndicatorTip
        {
            get
            {
                return this.State.Get<string>("CapsLockIndicatorTip", "");
            }
            set
            {
                this.State.Set("CapsLockIndicatorTip", value);
            }
        }

        private CapsLockDetectorListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Client-side JavaScript Event Handlers")]
        public CapsLockDetectorListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new CapsLockDetectorListeners();
                }

                return this.listeners;
            }
        }


        private CapsLockDetectorDirectEvents directEvents;

        /// <summary>
        /// Server-side DirectEvent Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [Description("Server-side DirectEventHandlers")]
        public CapsLockDetectorDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new CapsLockDetectorDirectEvents(this);
                }

                return this.directEvents;
            }
        }

        List<Icon> IIcon.Icons
        {
            get
            {
                List<Icon> icons = new List<Icon>(1);
                icons.Add(this.CapsLockIndicatorIcon);
                return icons;
            }
        }
    }
}
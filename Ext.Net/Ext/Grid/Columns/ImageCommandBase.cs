/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public abstract partial class ImageCommandBase : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("command")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public string CommandName
        {
            get
            {
                return this.State.Get<string>("CommandName", "");
            }
            set
            {
                this.State.Set("CommandName", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. ImageCommand")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string Cls
        {
            get
            {
                return this.State.Get<string>("Cls", "");
            }
            set
            {
                this.State.Set("Cls", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. ImageCommand")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool Hidden
        {
            get
            {
                return this.State.Get<bool>("Hidden", false);
            }
            set
            {
                this.State.Set("Hidden", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue(Icon.None)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual Icon Icon
        {
            get
            {
                return this.State.Get<Icon>("Icon", Icon.None);
            }
            set
            {
                this.State.Set("Icon", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string IconCls
        {
            get
            {
                if (this.Icon != Icon.None)
                {
                    return "icon-{0}".FormatWith(this.Icon.ToString().ToLowerInvariant());
                }

                return this.State.Get<string>("IconCls", "");
            }
            set
            {
                this.State.Set("IconCls", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string Text
        {
            get
            {
                return this.State.Get<string>("Text", "");
            }
            set
            {
                this.State.Set("Text", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string Style
        {
            get
            {
                return this.State.Get<string>("Style", "");
            }
            set
            {
                this.State.Set("Style", value);
            }
        }

        private SimpleToolTip toolTip;
        
        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("tooltip", JsonMode.Object)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public SimpleToolTip ToolTip
        {
            get
            {
                if (this.toolTip == null)
                {
                    this.toolTip = new SimpleToolTip();
                }

                return this.toolTip;
            }
        }

        /// <summary>
        /// How this component should be hidden. Supported values are 'visibility' (css visibility), 'offsets' (negative offset position) and 'display' (css display) - defaults to 'display'.
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.ToLower)]
        [Category("2. ImageCommand")]
        [DefaultValue(HideMode.Display)]
        [NotifyParentProperty(true)]
        [Description("How this component should be hidden. Supported values are 'visibility' (css visibility), 'offsets' (negative offset position) and 'display' (css display) - defaults to 'display'.")]
        public virtual HideMode HideMode
        {
            get
            {
                return this.State.Get<HideMode>("HideMode", HideMode.Display);
            }
            set
            {
                this.State.Set("HideMode", value);
            }
        }
    }
}
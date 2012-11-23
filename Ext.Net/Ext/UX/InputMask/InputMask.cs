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
    [ToolboxBitmap(typeof(InputMask), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:InputMask runat=\"server\" />")]
    [Description("")]
    public partial class InputMask : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public InputMask()
        {
        }

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

                baseList.Add(new ClientScriptItem(typeof(InputMask), "Ext.Net.Build.Ext.Net.ux.inputmask.inputmask.js", "/ux/inputmask/inputmask.js"));

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
                return "Ext.net.InputMask";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string PType
        {
            get
            {
                return "inputmask";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool AlwaysShow
        {
            get
            {
                return this.State.Get<bool>("AlwaysShow", false);
            }
            set
            {
                this.State.Set("AlwaysShow", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(true)]
        [Description("")]
        public virtual bool ClearWhenInvalid
        {
            get
            {
                return this.State.Get<bool>("ClearWhenInvalid", true);
            }
            set
            {
                this.State.Set("ClearWhenInvalid", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool AllowInvalid
        {
            get
            {
                return this.State.Get<bool>("AllowInvalid", false);
            }
            set
            {
                this.State.Set("AllowInvalid", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [Description("")]
        public virtual string InvalidMaskText
        {
            get
            {
                return this.State.Get<string>("InvalidMaskText", "");
            }
            set
            {
                this.State.Set("InvalidMaskText", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DirectEventUpdate(MethodName="SetMask")]
        [ConfigOption]
        [DefaultValue("")]
        [Description("")]
        public virtual string Mask
        {
            get
            {
                return this.State.Get<string>("Mask", "");
            }
            set
            {
                this.State.Set("Mask", value);
            }
        }

        private MaskSymbolCollection maskSymbols;

        /// <summary>
        /// Default symbols:
        /// "9": "[0-9]",
		/// "a": "[A-Za-z]",
		/// "*": "[A-Za-z0-9]"
        /// </summary>
        [Meta]        
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual MaskSymbolCollection MaskSymbols
        {
            get
            {
                return this.maskSymbols ?? (this.maskSymbols = new MaskSymbolCollection());
            }
        }

        [ConfigOption("maskSymbols", JsonMode.Raw)]
        [DefaultValue("")]
        protected string MaskSymbolsProxy
        {
            get
            {
                if (this.MaskSymbols.Count == 0)
                {
                    return "";
                }

                return this.MaskSymbols.ToJson();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue('_')]
        [Description("")]
        public virtual char Placeholder
        {
            get
            {
                return this.State.Get<char>("Placeholder", '_');
            }
            set
            {
                this.State.Set("Placeholder", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool UnmaskOnBlur
        {
            get
            {
                return this.State.Get<bool>("UnmaskOnBlur", false);
            }
            set
            {
                this.State.Set("UnmaskOnBlur", value);
            }
        }

        protected virtual void SetMask(string mask)
        {
            this.PluginOwner.Call("inputMask.setMask", mask);
        }

        public virtual void Unmask()
        {
            this.PluginOwner.Call("inputMask.unmask");
        }
    }
}
/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using System.Drawing;

namespace Ext.Net
{
    [Meta]
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(Preview), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:Preview runat=\"server\" />")]
    public partial class Preview : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        public Preview()
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

                baseList.Add(new ClientScriptItem(typeof(Preview), "Ext.Net.Build.Ext.Net.ux.preview.preview.js", "/ux/preview/preview.js"));

                return baseList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [ConfigOption("ptype")]
        [DefaultValue("")]
        [Description("")]
        public override string PType
        {
            get
            {
                return "preview";
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
                return "Ext.ux.PreviewPlugin";
            }
        }

        /// <summary>
        /// Field to display in the preview. Must me a field within the Model definition that the store is using.
        /// </summary>
        [ConfigOption]
        [Category("3. Preview")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Field to display in the preview. Must me a field within the Model definition that the store is using.")]
        public virtual string BodyField
        {
            get
            {
                return this.State.Get<string>("BodyField", "");
            }
            set
            {
                this.State.Set("BodyField", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [Category("3. Preview")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool PreviewExpanded
        {
            get
            {
                return this.State.Get<bool>("PreviewExpanded", true);
            }
            set
            {
                this.State.Set("PreviewExpanded", value);
            }
        }
    }
}

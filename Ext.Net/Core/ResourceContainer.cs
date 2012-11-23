/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Simple Container Control to allow for custom placement of Scripts and Styles in the &lt;head> of the Page by the ResourceManager. If the Page does not contain a &lt;ext:ResourcePlaceHolder> control, the &lt;script>'s and &lt;style>'s will be added as the last items in the &lt;head>. The ResourceContainer does not render any HTML to the Page.
    /// </summary>
    [ToolboxData("<{0}:ResourcePlaceHolder runat=\"server\" />")]
    [NonVisualControl]
    [Designer(typeof(ResourcePlaceHolderDesigner))]
    [ToolboxBitmap(typeof(ResourcePlaceHolder), "Build.ToolboxIcons.ResourceContainer.bmp")]
    [Description("Simple Container Control to allow for custom placement of Scripts and Styles in the &lt;head> of the Page by the ResourceManager. If the Page does not contain a &lt;ext:ResourcePlaceHolder> control, the &lt;script>'s and &lt;style>'s will be added as the last items in the &lt;head>. The ResourceContainer does not render any HTML to the Page.")]
    public partial class ResourcePlaceHolder : Control
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ResourcePlaceHolder() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ResourcePlaceHolder(ResourceMode mode)
        {
            this.Mode = mode;
        }

        internal ResourcePlaceHolder(bool configResourcePlaceHolder)
        {
            this.configResourcePlaceHolder = configResourcePlaceHolder;
        }

        private bool configResourcePlaceHolder;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool ConfigResourcePlaceHolder
        {
            get
            {
                return this.configResourcePlaceHolder;
            }
        }

        private ResourceMode resourceMode = ResourceMode.Script;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);

            if (this.configResourcePlaceHolder)
            {
                writer.Write(InitScriptFilter.CONFIG_SCRIPT_PLACEHOLDER);
                return;
            }

            switch (this.Mode)
            {
                case ResourceMode.Style:
                    writer.Write(InitScriptFilter.INIT_STYLE_PLACEHOLDER);
                    break;
                case ResourceMode.Script:
                    writer.Write(InitScriptFilter.INIT_SCRIPT_PLACEHOLDER);
                    break;
                case ResourceMode.ScriptFiles:
                    writer.Write(InitScriptFilter.INIT_SCRIPT_FILES_PLACEHOLDER);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(ResourceMode.Script)]
        [Description("")]
        public ResourceMode Mode
        {
            get
            {
                return this.resourceMode;
            }
            set
            {
                this.resourceMode = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public enum ResourceMode
    {
        /// <summary>
        /// 
        /// </summary>
        Style,

        /// <summary>
        /// 
        /// </summary>
        Script,

        /// <summary>
        /// 
        /// </summary>
        ScriptFiles
    }
}
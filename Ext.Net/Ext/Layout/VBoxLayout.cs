/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A layout that arranges items vertically
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:VBoxLayout runat=\"server\"></{0}:VBoxLayout>")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(VBoxLayout), "Build.ToolboxIcons.Layout.bmp")]
    [Description("A layout that arranges items vertically")]
    public partial class VBoxLayout : BoxLayout
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public VBoxLayout() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("4. Layout")]
		[Description("")]
        public override string LayoutType
        {
            get
            {
                return "vbox";
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.Object)]
        [Browsable(false)]
		[Description("")]
        protected internal override LayoutConfig LayoutConfig
        {
            get
            {
                return new VBoxLayoutConfig(
                    this.Align,
                    this.DefaultMargins,
                    this.Padding,
                    this.Pack,
                    this.ScrollOffset,
                    this.RenderHidden,
                    this.ExtraCls);
            }
        }
        
        /// <summary>
        /// Controls how the child items of the container are aligned.
        /// </summary>
        [Meta]
        [Category("7. VBoxLayout")]
        [DefaultValue(VBoxAlign.Left)]
        [Description("Controls how the child items of the container are aligned.")]
        public virtual VBoxAlign Align
        {
            get
            {
                object obj = this.ViewState["Align"];
                return (obj == null) ? VBoxAlign.Left : (VBoxAlign)obj;
            }
            set
            {
                this.ViewState["Align"] = value;
            }
        }
    }
}
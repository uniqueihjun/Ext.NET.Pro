/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A layout that arranges items horizontally
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:HBoxLayout runat=\"server\"></{0}:HBoxLayout>")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(HBoxLayout), "Build.ToolboxIcons.Layout.bmp")]
    [Description("A layout that arranges items horizontally")]
    public partial class HBoxLayout : BoxLayout
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public HBoxLayout() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("4. Layout")]
		[Description("")]
        public override string LayoutType
        {
            get
            {
                return "hbox";
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
                return new HBoxLayoutConfig(
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
        [Category("7. HBoxLayout")]
        [DefaultValue(HBoxAlign.Top)]
        [Description("Controls how the child items of the container are aligned.")]
        public virtual HBoxAlign Align
        {
            get
            {
                object obj = this.ViewState["Align"];
                return (obj == null) ? HBoxAlign.Top : (HBoxAlign)obj;
            }
            set
            {
                this.ViewState["Align"] = value;
            }
        }
    }
}
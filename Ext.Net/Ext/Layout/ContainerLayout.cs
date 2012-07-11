/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Every layout is composed of one or more Ext.Container elements internally, and ContainerLayout provides the basic foundation for all other layout classes in Ext. It is a non-visual class that simply provides the base logic required for a Container to function as a layout. 
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:ContainerLayout runat=\"server\"></{0}:ContainerLayout>")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(ContainerLayout), "Build.ToolboxIcons.Layout.bmp")]
    [Description("")]
    public partial class ContainerLayout : Layout
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ContainerLayout() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("4. Layout")]
		[Description("")]
        public override string LayoutType
        {
            get
            {
                return "container";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Object)]
        [Description("")]
        protected internal virtual LayoutConfig LayoutConfig
        {
            get
            {
                return new LayoutConfig(this.RenderHidden, this.ExtraCls);
            }
        }
    }
}
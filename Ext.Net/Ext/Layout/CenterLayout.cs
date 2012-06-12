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
    /// This is a very simple layout style used to center contents within a container.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:CenterLayout runat=\"server\"><{0}:Panel runat=\"server\" Title=\"Title\"><Items></Items></{0}:Panel></{0}:CenterLayout>")]
    [ToolboxBitmap(typeof(CenterLayout), "Build.ToolboxIcons.Layout.bmp")]
    [Description("This is a very simple layout style used to center contents within a container.")]
    [Designer(typeof(EmptyDesigner))]
    public partial class CenterLayout : ContainerLayout
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CenterLayout() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("4. Layout")]
		[Description("")]
        public override string LayoutType
        {
            get
            {
                return "ux.center";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override bool SingleItemMode
        {
            get
            {
                return true;
            }
        }
    }
}
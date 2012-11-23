/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// This is a base class for layouts that contain a single items that automatically expands to fill the layout's content Container. This class is intended to be extended or created via the layout:'fit' Ext.Container.layout config, and should generally not need to be created directly via the new keyword. FitLayout does not have any direct config options (other than inherited ones). To fit a panel to a content Container using FitLayout, simply set layout:'fit' on the content Container and add a single panel to it. If the content Container has multiple panels, only the first one will be displayed.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:FitLayout runat=\"server\"><Items><{0}:Panel runat=\"server\" Title=\"Title\"><Items></Items></{0}:Panel></Items></{0}:FitLayout>")]
    [ToolboxBitmap(typeof(FitLayout), "Build.ToolboxIcons.Layout.bmp")]
    [Description("This is a base class for layouts that contain a single items that automatically expands to fill the layout's content Container. This class is intended to be extended or created via the layout:'fit' Ext.Container.layout config, and should generally not need to be created directly via the new keyword. FitLayout does not have any direct config options (other than inherited ones). To fit a panel to a content Container using FitLayout, simply set layout:'fit' on the content Container and add a single panel to it. If the content Container has multiple panels, only the first one will be displayed.")]
    [Designer(typeof(FitLayoutDesigner))]
    public partial class FitLayout : ContainerLayout
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public FitLayout() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("4. Layout")]
		[Description("")]
        public override string LayoutType
        {
            get
            {
                return "fit";
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
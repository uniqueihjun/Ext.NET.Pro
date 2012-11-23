/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    [ToolboxBitmap(typeof(PortalColumn), "Build.ToolboxIcons.PortalColumn.bmp")]
    [ToolboxData("<{0}:PortalColumn runat=\"server\" StyleSpec=\"padding:10px 0 10px 10px\"><Items><{0}:AnchorLayout ID=\"AnchorLayout1\" runat=\"server\"><{0}:Anchor Horizontal=\"100%\"><{0}:Portlet Title=\"Portlet\" runat=\"server\" /></{0}:Anchor></{0}:AnchorLayout></Items></{0}:PortalColumn>")]
    [Description("")]
    public partial class PortalColumn : PanelBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public PortalColumn() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "portalcolumn";
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
                return "Ext.ux.PortalColumn";
            }
        }
    }
}
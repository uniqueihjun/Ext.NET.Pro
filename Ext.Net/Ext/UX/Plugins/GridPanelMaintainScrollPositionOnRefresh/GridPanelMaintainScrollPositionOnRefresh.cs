/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(GridPanelMaintainScrollPositionOnRefresh), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:GridPanelMaintainScrollPositionOnRefresh runat=\"server\" />")]
    [Description("")]
    public partial class GridPanelMaintainScrollPositionOnRefresh : Plugin 
    {
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

                baseList.Add(new ClientScriptItem(typeof(GridPanelMaintainScrollPositionOnRefresh), "Ext.Net.Build.Ext.Net.ux.plugins.gridpanelmaintainscrollpositiononrefresh.gridpanelmaintainscrollpositiononrefresh.js", "/ux/plugins/gridpanelmaintainscrollpositiononrefresh/gridpanelmaintainscrollpositiononrefresh.js"));

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
                return "Ext.ux.plugins.GridPanelMaintainScrollPositionOnRefresh";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. GridPanelMaintainScrollPositionOnRefresh")]
        [DefaultValue(20)]
        [Description("")]
        public virtual int RestoreDelay
        {
            get
            {
                object obj = this.ViewState["RestoreDelay"];
                return (obj == null) ? 20 : (int)obj;
            }
            set
            {
                this.ViewState["RestoreDelay"] = value;
            }
        }
    }
}

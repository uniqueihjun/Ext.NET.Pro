/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    [ToolboxBitmap(typeof(DataViewDragSelector), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:DataViewDragSelector runat=\"server\" />")]
    [Description("")]
    public partial class DataViewDragSelector : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public DataViewDragSelector() { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 2;

                baseList.Add(new ClientStyleItem(typeof(DataViewDragSelector), "Ext.Net.Build.Ext.Net.ux.resources.DragSelector-embedded.css", "/ux/resources/DragSelector.css"));
                baseList.Add(new ClientScriptItem(typeof(DataViewDragSelector), "Ext.Net.Build.Ext.Net.ux.view.DragSelector.js", "/ux/view/DragSelector.js"));

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
                return "Ext.ux.DataView.DragSelector";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override System.Type RequiredOwnerType
        {
            get
            {
                return typeof(AbstractDataView);
            }
        }
    }
}
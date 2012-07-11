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
    /// Adds capability to specify the summary data for the group via json
    /// </summary>
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(GroupingSummary), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:HybridSummary runat=\"server\" />")]
    [Description("Adds capability to specify the summary data for the group via json")]
    public partial class HybridSummary : GroupingSummary
    {
        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.grid.HybridSummary";
            }
        }

        /// <summary>
        /// Update summary with new data
        /// </summary>
        /// <param name="groupValue">group value</param>
        /// <param name="data">data object</param>
        /// <param name="skipRefresh">skip grid refresh</param>
        public void UpdateSummaryData(string groupValue, object data, bool skipRefresh)
        {
            this.Call("updateSummaryData", groupValue, data, skipRefresh);
        }

        /// <summary>
        /// Update summary with new data
        /// </summary>
        /// <param name="groupValue">group value</param>
        /// <param name="data">data object</param>
        public void UpdateSummaryData(string groupValue, object data)
        {
            this.Call("updateSummaryData", groupValue, data);
        }
    }
}
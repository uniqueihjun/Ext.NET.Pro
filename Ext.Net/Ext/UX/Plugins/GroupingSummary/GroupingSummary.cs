/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Web.UI;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A GridPanel plugin that enables dynamic column calculations and a dynamically updated grouped summary row.
    /// </summary>
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(GroupingSummary), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:GroupingSummary runat=\"server\" />")]
    [Description("Grouping summary plugin for GridPanel")]
    public partial class GroupingSummary : Plugin 
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
                baseList.Capacity += 2;

                baseList.Add(new ClientScriptItem(typeof(GroupingSummary), "Ext.Net.Build.Ext.Net.ux.plugins.groupingsummary.groupingsummary.js", "/ux/plugins/groupingsummary/groupingsummary.js"));
                baseList.Add(new ClientStyleItem(typeof(GroupingSummary), "Ext.Net.Build.Ext.Net.ux.plugins.groupingsummary.resources.css.groupingsummary.css", "/ux/plugins/groupingsummary/resources/css/groupingsummary.css"));

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
                return "Ext.grid.GroupSummary";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

            if (!X.IsAjaxRequest)
            {
                this.RegisterCalculations();
            }
        }

        private List<JFunction> calculations;

        /// <summary>
        ///  Calculation types for summary row
        /// </summary>
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DefaultValue(null)]
        [Description("Calculation types for summary row")]
        public List<JFunction> Calculations
        {
            get
            {
                if (this.calculations == null)
                {
                    this.calculations = new List<JFunction>();
                }

                return this.calculations;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected internal virtual void RegisterCalculations()
        {
            if (this.Calculations.Count == 0)
                {
                    return;
                }

                StringBuilder sb = new StringBuilder();

                sb.Append("Ext.apply(Ext.grid.GroupSummary.Calculations,{");
                bool comma = false;
                foreach (JFunction f in this.Calculations)
                {
                    if (f.Name.IsEmpty())
                    {
                        throw new Exception("You have to define Name for GroupingSummary calculation function");
                    }

                    if (comma)
                    {
                        sb.Append(",");
                    }
                    f.Args = new string[] { "v", "record", "field", "data" };
                    sb.Append(f.ToScript());
                    comma = true;
                }
                sb.Append("});");

                this.AddScript(sb.ToString());
        }

        /// <summary>
        /// Toggle the display of the summary row on/off
        /// </summary>
        /// <param name="visible">visible 'true' to show the summary, 'false' to hide the summary.</param>
        public void ToggleSummaries(bool visible)
        {
            this.Call("toggleSummaries", visible);
        }

        /// <summary>
        /// Note: requires that all (or the first) record in the group share the same group value.
        /// </summary>
        /// <param name="groupValue"></param>
        public void RefreshSummary(string groupValue)
        {
            this.Call("refreshSummary", groupValue);
        }

        /// <summary>
        /// Show a message in the summary row.
        /// </summary>
        /// <param name="groupValue">group value</param>
        /// <param name="msg">Text to use as innerHTML for the summary row.</param>
        public void ShowSummaryMsg(string groupValue, string msg)
        {
            this.Call("showSummaryMsg", groupValue);
        }
    }
}

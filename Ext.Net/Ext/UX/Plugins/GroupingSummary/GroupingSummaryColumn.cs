/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class GroupingSummaryColumn : Column
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [Category("3. GroupingSummaryColumn")]
        [DefaultValue(SummaryType.None)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual SummaryType SummaryType
        {
            get
            {
                object obj = this.ViewState["SummaryType"];
                return (obj == null) ? SummaryType.None : (SummaryType)obj;
            }
            set
            {
                this.ViewState["SummaryType"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("summaryType")]
        [Category("3. GroupingSummaryColumn")]
        [DefaultValue("")]
        [Description("")]
        public virtual string CustomSummaryType
        {
            get
            {
                return (string)this.ViewState["CustomSummaryType"] ?? "";
            }
            set
            {
                this.ViewState["CustomSummaryType"] = value;
            }
        }

        private Renderer summaryRenderer;

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(typeof(RendererJsonConverter))]
        [Category("3. GroupingSummaryColumn")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ViewStateMember]
        [Description("")]
        public virtual Renderer SummaryRenderer
        {
            get
            {
                if (this.summaryRenderer == null)
                {
                    this.summaryRenderer = new Renderer();
                }

                return this.summaryRenderer;
            }
            set
            {
                this.summaryRenderer = value;
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public enum SummaryType
    {
        /// <summary>
        /// 
        /// </summary>
        None,

        /// <summary>
        /// 
        /// </summary>
        Average,

        /// <summary>
        /// 
        /// </summary>
        Count,

        /// <summary>
        /// 
        /// </summary>
        Max,

        /// <summary>
        /// 
        /// </summary>
        Min,

        /// <summary>
        /// 
        /// </summary>
        Sum
    }
}
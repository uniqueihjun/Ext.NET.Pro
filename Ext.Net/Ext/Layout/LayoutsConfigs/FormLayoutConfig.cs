/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class FormLayoutConfig : LayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public FormLayoutConfig(bool trackLabels, string elementStyle, string labelSeparator, string labelStyle, bool renderHidden, string extraCls) : base(renderHidden, extraCls)
        {
            this.TrackLabels = trackLabels;
            this.ElementStyle = elementStyle;
            this.LabelSeparator = labelSeparator;
            this.LabelStyle = labelStyle;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public FormLayoutConfig() { }

        /// <summary>
        /// True to show/hide the field label when the field is hidden. Defaults to true. 
        /// </summary>
        [ConfigOption]
        [DefaultValue(true)]
        [Description("True to show/hide the field label when the field is hidden. Defaults to true.")]
        public virtual bool TrackLabels
        {
            get
            {
                object obj = this.ViewState["TrackLabels"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["TrackLabels"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [Description("")]
        public virtual string ElementStyle
        {
            get
            {
                return (string)this.ViewState["ElementStyle"] ?? "";
            }
            set
            {
                this.ViewState["ElementStyle"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(":")]
        [Localizable(true)]
		[Description("")]
        public virtual string LabelSeparator
        {
            get
            {
                return (string)this.ViewState["LabelSeparator"] ?? ":";
            }
            set
            {
                this.ViewState["LabelSeparator"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue("")]
		[Description("")]
        public string LabelStyle
        {
            get
            {
                return (string)this.ViewState["LabelStyle"] ?? "";
            }
            set
            {
                this.ViewState["LabelStyle"] = value;
            }
        }
    }
}
/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BooleanFilter : GridFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [Category("3. BooleanFilter")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public override FilterType Type
        {
            get 
            {
                return FilterType.Boolean;
            }
        }

        /// <summary>
        /// The text displayed for the 'Yes' checkbox
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanFilter")]
        [DefaultValue("Yes")]
        [Localizable(true)]
        [NotifyParentProperty(true)]
        [Description("The text displayed for the 'Yes' checkbox")]
        public string YesText
        {
            get
            {
                object obj = this.ViewState["YesText"];
                return obj == null ? "Yes" : (string)obj;
            }
            set
            {
                this.ViewState["YesText"] = value;
            }
        }

        /// <summary>
        /// The text displayed for the 'No' checkbox
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanFilter")]
        [DefaultValue("No")]
        [Localizable(true)]
        [NotifyParentProperty(true)]
        [Description("The text displayed for the 'No' checkbox")]
        public string NoText
        {
            get
            {
                object obj = this.ViewState["NoText"];
                return obj == null ? "No" : (string)obj;
            }
            set
            {
                this.ViewState["NoText"] = value;
            }
        }

        /// <summary>
        /// The default value of this filter (defaults to false)
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanFilter")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("The default value of this filter (defaults to false)")]
        public bool DefaultValue
        {
            get
            {
                object obj = this.ViewState["DefaultValue"];
                return obj == null ? false : (bool)obj;
            }
            set
            {
                this.ViewState["DefaultValue"] = value;
            }
        }

        /// <summary>
        /// Predefined filter value
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanFilter")]
        [DefaultValue(null)]
        [Description("Predefined filter value")]
        public virtual bool? Value
        {
            get
            {
                object obj = this.ViewState["Value"];
                return (obj == null) ? null : (bool?)obj;
            }
            set
            {
                this.ViewState["Value"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void SetValue(bool? value)
        {
            RequestManager.EnsureDirectEvent();

            if (this.ParentGrid != null)
            {
                this.ParentGrid.AddScript("{0}.getFilterPlugin().getFilter({1}).setValue({2});", this.ParentGrid.ClientID, JSON.Serialize(this.DataIndex), JSON.Serialize(value));
            }
        }
    }
}

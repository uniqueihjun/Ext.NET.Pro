/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    [Meta]
	[Description("")]
    public partial class BooleanFilter : GridFilter
    {
        public BooleanFilter() { }

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
        [Meta]
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
                return this.State.Get<string>("YesText", "Yes");
            }
            set
            {
                this.State.Set("YesText", value);
            }
        }

        /// <summary>
        /// The text displayed for the 'No' checkbox
        /// </summary>
        [Meta]
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
                return this.State.Get<string>("NoText", "No");
            }
            set
            {
                this.State.Set("NoText", value);
            }
        }

        /// <summary>
        /// The default value of this filter (defaults to false)
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. BooleanFilter")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("The default value of this filter (defaults to false)")]
        public bool DefaultValue
        {
            get
            {
                return this.State.Get<bool>("DefaultValue", false);
            }
            set
            {
                this.State.Set("DefaultValue", value);
            }
        }

        /// <summary>
        /// Predefined filter value
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. BooleanFilter")]
        [DefaultValue(null)]
        [Description("Predefined filter value")]
        public virtual bool? Value
        {
            get
            {
                return this.State.Get<bool?>("Value", null);
            }
            set
            {
                this.State.Set("Value", value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void SetValue(bool? value)
        {
            RequestManager.EnsureDirectEvent();

            if (this.Plugin != null)
            {
                this.Plugin.AddScript("{0}.getFilter({1}).setValue({2});", this.Plugin.ClientID, JSON.Serialize(this.DataIndex), JSON.Serialize(value));
            }
        }
    }
}

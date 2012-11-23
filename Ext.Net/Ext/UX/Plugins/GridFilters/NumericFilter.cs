/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.IO;
using System.Text;
using Newtonsoft.Json;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class NumericFilter : GridFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [Category("3. NumericFilter")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public override FilterType Type
        {
            get 
            { 
                return FilterType.Numeric;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [Category("3. NumericFilter")]
        [DefaultValue("Enter Filter Text...")]
        [Localizable(true)]
        [NotifyParentProperty(true)]
        [Description("")]
        public string EmptyText
        {
            get
            {
                object obj = this.ViewState["EmptyText"];
                return obj == null ? "Enter Filter Text..." : (string)obj;
            }
            set
            {
                this.ViewState["EmptyText"] = value;
            }
        }

        /// <summary>
        /// Predefined filter value
        /// </summary>
        [Category("3. NumericFilter")]
        [DefaultValue("")]
        [Description("Predefined filter value")]
        public virtual float? GreaterThanValue
        {
            get
            {
                object obj = this.ViewState["GreaterThanValue"];
                return (obj == null) ? null : (float?)obj;
            }
            set
            {
                this.ViewState["GreaterThanValue"] = value;
            }
        }

        /// <summary>
        /// Predefined filter value
        /// </summary>
        [Category("3. NumericFilter")]
        [DefaultValue("")]
        [Description("Predefined filter value")]
        public virtual float? LessThanValue
        {
            get
            {
                object obj = this.ViewState["LessThanValue"];
                return (obj == null) ? null : (float?)obj;
            }
            set
            {
                this.ViewState["LessThanValue"] = value;
            }
        }

        /// <summary>
        /// Predefined filter value
        /// </summary>
        [Category("3. NumericFilter")]
        [DefaultValue("")]
        [Description("Predefined filter value")]
        public virtual float? EqualValue
        {
            get
            {
                object obj = this.ViewState["EqualValue"];
                return (obj == null) ? null : (float?)obj;
            }
            set
            {
                this.ViewState["EqualValue"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("value", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected string ValueProxy
        {
            get
            {
                if (this.GreaterThanValue.HasValue || this.LessThanValue.HasValue || this.EqualValue.HasValue)
                {
                    StringWriter sw = new StringWriter(new StringBuilder());
                    JsonTextWriter jw = new JsonTextWriter(sw);
                    jw.WriteStartObject();

                    if (this.GreaterThanValue.HasValue)
                    {
                        jw.WritePropertyName("gt");
                        jw.WriteValue(this.GreaterThanValue);
                    }

                    if (this.LessThanValue.HasValue)
                    {
                        jw.WritePropertyName("lt");
                        jw.WriteValue(this.LessThanValue);
                    }

                    if (this.EqualValue.HasValue)
                    {
                        jw.WritePropertyName("eq");
                        jw.WriteValue(this.EqualValue);
                    }
                    
                    jw.WriteEndObject();

                    return sw.GetStringBuilder().ToString();
                }

                return "";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void SetValue(float? greaterThanValue, float? lessThanValue)
        {
            RequestManager.EnsureDirectEvent();

            if (this.ParentGrid != null)
            {
                string value = "{gt:".ConcatWith(greaterThanValue.HasValue ? JSON.Serialize(greaterThanValue.Value) : "undefined",
                    ",lt:", lessThanValue.HasValue ? JSON.Serialize(lessThanValue.Value) : "undefined", "}");

                this.ParentGrid.AddScript("{0}.getFilterPlugin().getFilter({1}).setValue({2});", this.ParentGrid.ClientID, JSON.Serialize(this.DataIndex), value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void SetValue(float? eqValue)
        {
            RequestManager.EnsureDirectEvent();
            
            if (this.ParentGrid != null)
            {
                string value = "{eq:".ConcatWith(eqValue.HasValue ? JSON.Serialize(eqValue.Value) : "undefined", "}");
                this.ParentGrid.AddScript("{0}.getFilterPlugin().getFilter({1}).setValue({2});", this.ParentGrid.ClientID, JSON.Serialize(this.DataIndex), value);
            }
        }
    }
}

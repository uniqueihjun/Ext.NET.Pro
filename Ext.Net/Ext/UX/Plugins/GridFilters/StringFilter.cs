/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    public partial class StringFilter : GridFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [Category("3. StringFilter")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public override FilterType Type
        {
            get 
            { 
                return FilterType.String;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [Category("3. StringFilter")]
        [DefaultValue("Enter Filter Text...")]
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
        [ConfigOption]
        [Category("3. StringFilter")]
        [DefaultValue("")]
        [Description("Predefined filter value")]
        public virtual string Value
        {
            get
            {
                object obj = this.ViewState["Value"];
                return (obj == null) ? "" : (string)obj;
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
        public void SetValue(string value)
        {
            RequestManager.EnsureDirectEvent();

            if (this.ParentGrid != null)
            {
                this.ParentGrid.AddScript("{0}.getFilterPlugin().getFilter({1}).setValue({2});", this.ParentGrid.ClientID, JSON.Serialize(this.DataIndex), JSON.Serialize(value));
            }
        }
    }
}

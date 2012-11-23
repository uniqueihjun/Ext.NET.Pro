/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI.WebControls;
using System.Web.UI;
using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ListFilter : GridFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [Category("3. ListFilter")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public override FilterType Type
        {
            get 
            { 
                return FilterType.List;
            }
        }

        /// <summary>
        /// The loading text displayed when data loading
        /// </summary>
        [ConfigOption]
        [Category("3. ListFilter")]
        [DefaultValue("Loading...")]
        [Localizable(true)]
        [NotifyParentProperty(true)]
        [Description("The loading text displayed when data loading")]
        public string LoadingText
        {
            get
            {
                object obj = this.ViewState["LoadingText"];
                return obj == null ? "Loading..." : (string)obj;
            }
            set
            {
                this.ViewState["LoadingText"] = value;
            }
        }

        /// <summary>
        /// If true then the data loading on show
        /// </summary>
        [ConfigOption]
        [Category("3. ListFilter")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("If true then the data loading on show")]
        public bool LoadOnShow
        {
            get
            {
                object obj = this.ViewState["LoadOnShow"];
                return obj == null ? true : (bool)obj;
            }
            set
            {
                this.ViewState["LoadOnShow"] = value;
            }
        }

        /// <summary>
        /// The list of options
        /// </summary>
        [TypeConverter(typeof(StringArrayConverter))]
        [DefaultValue(null)]
        [Description("The list of options")]
        public virtual string[] Options
        {
            get
            {
                object obj = this.ViewState["Options"];
                return (obj == null) ? null : (string[])obj;
            }
            set
            {
                this.ViewState["Options"] = value;
            }
        }

        /// <summary>
        /// The list of options
        /// </summary>
        [ConfigOption(typeof(StringArrayJsonConverter))]
        [TypeConverter(typeof(StringArrayConverter))]
        [DefaultValue(null)]
        [Description("The list of options")]
        public virtual string[] Value
        {
            get
            {
                object obj = this.ViewState["Value"];
                return (obj == null) ? null : (string[])obj;
            }
            set
            {
                this.ViewState["Value"] = value;
            }
        }

        /// <summary>
        /// The data store to use.
        /// </summary>
        [Meta]        
        [DefaultValue("")]
        [IDReferenceProperty(typeof(Store))]
        [Description("The data store to use.")]
        public virtual string StoreID
        {
            get
            {
                return (string)this.ViewState["StoreID"] ?? "";
            }
            set
            {
                this.ViewState["StoreID"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue("text")]
        public virtual string LabelField
        {
            get
            {
                return (string)this.ViewState["LabelField"] ?? "text";
            }
            set
            {
                this.ViewState["LabelField"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("options", JsonMode.Raw)]
        [DefaultValue("")]
        protected internal string OptionsProxy
        {
            get
            {
                if (this.StoreID.IsEmpty() && this.Options != null && this.Options.Length > 0)
                {
                    return JSON.Serialize(this.Options);
                }

                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("store", JsonMode.Raw)]
        [DefaultValue("")]
        protected internal string StoreProxy
        {
            get
            {
                if (!this.StoreID.IsEmpty())
                {
                    Control c = ControlUtils.FindControl(this.ParentGrid, this.StoreID);
                    return c != null ? c.ClientID : this.StoreID;
                }

                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("labelField")]
        [DefaultValue("text")]
        protected internal string LabelFieldProxy
        {
            get
            {
                if (!this.StoreID.IsEmpty())
                {
                    return this.LabelField;
                }

                return "text";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public void UpdateOptions(string[] options)
        {
            RequestManager.EnsureDirectEvent();

            if (this.ParentGrid != null)
            {
                this.ParentGrid.AddScript("{0}.getFilterPlugin().getFilter({1}).updateOptions({2});", this.ParentGrid.ClientID, JSON.Serialize(this.DataIndex), JSON.Serialize(options));
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void SetValue(string[] value)
        {
            RequestManager.EnsureDirectEvent();

            if (this.ParentGrid != null)
            {
                this.ParentGrid.AddScript("{0}.getFilterPlugin().getFilter({1}).setValue({2});", this.ParentGrid.ClientID, JSON.Serialize(this.DataIndex), JSON.Serialize(value));
            }
        }
    }
}
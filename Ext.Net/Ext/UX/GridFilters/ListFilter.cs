/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
                return this.State.Get<string>("LoadingText", "Loading...");
            }
            set
            {
                this.State.Set("LoadingText", value);
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
                return this.State.Get<bool>("LoadOnShow", true);
            }
            set
            {
                this.State.Set("LoadOnShow", value);
            }
        }

        /// <summary>
        /// Specify true to group all items in this list into a single-select radio button group. Defaults to false.
        /// </summary>
        [ConfigOption]
        [Category("3. ListFilter")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Specify true to group all items in this list into a single-select radio button group. Defaults to false.")]
        public bool Single
        {
            get
            {
                return this.State.Get<bool>("Single", false);
            }
            set
            {
                this.State.Set("Single", value);
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
                return this.State.Get<string[]>("Options", null);
            }
            set
            {
                this.State.Set("Options", value);
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
                return this.State.Get<string[]>("Value", null);
            }
            set
            {
                this.State.Set("Value", value);
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
                return this.State.Get<string>("StoreID", "");
            }
            set
            {
                this.State.Set("StoreID", value);
            }
        }

        /// <summary>
        /// Defaults to 'text'.
        /// </summary>
        [Meta]
        [DefaultValue("text")]
        public virtual string LabelField
        {
            get
            {
                return this.State.Get<string>("LabelField", "text");
            }
            set
            {
                this.State.Set("LabelField", value);
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
                    return ControlUtils.FindControl(this.ParentGrid, this.StoreID).ClientID;
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

            this.AddScript("{0}.getFilter({1}).updateOptions({2});", this.Plugin.ClientID, JSON.Serialize(this.DataIndex), JSON.Serialize(options));
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void SetValue(string[] value)
        {
            RequestManager.EnsureDirectEvent();

            this.AddScript("{0}.getFilterPlugin().getFilter({1}).setValue({2});", this.Plugin.ClientID, JSON.Serialize(this.DataIndex), JSON.Serialize(value));
        }
    }
}
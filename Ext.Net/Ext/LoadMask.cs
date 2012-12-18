/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A simple utility class for generically masking elements while loading data. If the element being masked has an underlying Ext.data.Store, the masking will be automatically synchronized with the store's loading process and the mask element will be cached for reuse. For all other elements, this mask will replace the element's UpdateOptions load indicator and will be destroyed after the initial load.
    /// </summary>
    [Meta]
    [Description("A simple utility class for generically masking elements while loading data. If the element being masked has an underlying Ext.data.Store, the masking will be automatically synchronized with the store's loading process and the mask element will be cached for reuse. For all other elements, this mask will replace the element's UpdateOptions load indicator and will be destroyed after the initial load.")]
    public partial class LoadMask : BaseItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public LoadMask() { }

        /// <summary>
        /// True to create a single-use mask that is automatically destroyed after loading (useful for page loads), False to persist the mask element reference for multiple uses (e.g., for paged data widgets). Defaults to false.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue(false)]
        [Description("True to create a single-use mask that is automatically destroyed after loading (useful for page loads), False to persist the mask element reference for multiple uses (e.g., for paged data widgets). Defaults to false.")]
        public virtual bool ShowMask
        {
            get
            {
                return this.State.Get<bool>("ShowMask", false);
            }
            set
            {
                this.State.Set("ShowMask", value);
            }
        }

        /// <summary>
        /// The text to display in a centered loading message box. Defaults to: "Loading..."
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue("Loading...")]
        [Description("The text to display in a centered loading message box (defaults to 'Loading...').")]
        public virtual string Msg
        {
            get
            {
                return this.State.Get<string>("Msg", "Loading...");
            }
            set
            {
                this.State.Set("Msg", value);
            }
        }

        /// <summary>
        /// The CSS class to apply to the loading message element (defaults to 'x-mask-loading').
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue("x-mask-loading")]
        [Description("The CSS class to apply to the loading message element (defaults to 'x-mask-loading').")]
        public virtual string MsgCls
        {
            get
            {
                return this.State.Get<string>("MsgCls", "x-mask-loading");
            }
            set
            {
                this.State.Set("MsgCls", value);
            }
        }

        /// <summary>
        /// Optional Store to which the mask is bound. The mask is displayed when a load request is issued, and hidden on either load success, or load fail.
        /// </summary>
        [Meta]
        [ConfigOption("store", JsonMode.ToClientID)]
        [Category("Config Options")]
        [DefaultValue("")]
        [IDReferenceProperty(typeof(Store))]
        [Description("Optional Store to which the mask is bound. The mask is displayed when a load request is issued, and hidden on either load success, or load fail.")]
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
        /// Whether or not to use a loading message class or simply mask the bound element. Defaults to: true
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue(true)]
        [Description("Whether or not to use a loading message class or simply mask the bound element. Defaults to: true")]
        public virtual bool UseMsg
        {
            get
            {
                return this.State.Get<bool>("UseMsg", true);
            }
            set
            {
                this.State.Set("UseMsg", value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool IsDefault
        {
            get
            {
                if (this is EventMask)
                {
                    return base.IsDefault;
                }

                return (this.ShowMask == false);
            }
        }
    }
}
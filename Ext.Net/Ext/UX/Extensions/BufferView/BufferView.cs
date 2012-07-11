/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// A custom GridView which renders rows on an as-needed basis.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A custom GridView which renders rows on an as-needed basis.")]
    public partial class BufferView : GridView
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BufferView() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.ux.grid.BufferView";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                baseList.Add(new ClientScriptItem(typeof(BufferView), "Ext.Net.Build.Ext.Net.ux.extensions.bufferview.bufferview.js", "/ux/extensions/bufferview/bufferview.js"));

                return baseList;
            }
        }

        /// <summary>
        /// The height of a row in the grid.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Localizable(true)]
        [Category("4. BufferView")]
        [DefaultValue(19)]
        [Description("The height of a row in the grid.")]
        public virtual int RowHeight
        {
            get
            {
                object obj = this.ViewState["RowHeight"];
                return (obj == null) ? 19 : (int)obj;
            }
            set
            {
                this.ViewState["RowHeight"] = value;
            }
        }

        /// <summary>
        /// The combined height of border-top and border-bottom of a row.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Localizable(true)]
        [Category("4. BufferView")]
        [DefaultValue(2)]
        [Description("The combined height of border-top and border-bottom of a row.")]
        public virtual int BorderHeight
        {
            get
            {
                object obj = this.ViewState["BorderHeight"];
                return (obj == null) ? 2 : (int)obj;
            }
            set
            {
                this.ViewState["BorderHeight"] = value;
            }
        }

        /// <summary>
        /// The number of milliseconds before rendering rows out of the visible viewing area. Defaults to 100. Rows will render immediately with a config of false.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Localizable(true)]
        [Category("4. BufferView")]
        [DefaultValue(100)]
        [Description("The number of milliseconds before rendering rows out of the visible viewing area. Defaults to 100. Rows will render immediately with a config of false.")]
        public virtual int ScrollDelay
        {
            get
            {
                object obj = this.ViewState["ScrollDelay"];
                return (obj == null) ? 100 : (int)obj;
            }
            set
            {
                this.ViewState["ScrollDelay"] = value;
            }
        }

        /// <summary>
        /// The number of rows to look forward and backwards from the currently viewable area.  The cache applies only to rows that have been rendered already.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Localizable(true)]
        [Category("4. BufferView")]
        [DefaultValue(20)]
        [Description("The number of rows to look forward and backwards from the currently viewable area.  The cache applies only to rows that have been rendered already.")]
        public virtual int CacheSize
        {
            get
            {
                object obj = this.ViewState["CacheSize"];
                return (obj == null) ? 20 : (int)obj;
            }
            set
            {
                this.ViewState["CacheSize"] = value;
            }
        }

        /// <summary>
        /// The number of milliseconds to buffer cleaning of extra rows not in the cache.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Localizable(true)]
        [Category("4. BufferView")]
        [DefaultValue(500)]
        [Description("The number of milliseconds to buffer cleaning of extra rows not in the cache.")]
        public virtual int CleanDelay
        {
            get
            {
                object obj = this.ViewState["CleanDelay"];
                return (obj == null) ? 500 : (int)obj;
            }
            set
            {
                this.ViewState["CleanDelay"] = value;
            }
        }
    }
}
/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    public partial class LockingGridView : GridView
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public LockingGridView() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get 
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 2;
                baseList.Add(new ClientStyleItem(typeof(LockingGridView), "Ext.Net.Build.Ext.Net.ux.extensions.lockinggrid.css.LockingGridView.css", "/ux/extensions/lockinggrid/css/LockingGridView.css"));
                baseList.Add(new ClientScriptItem(typeof(LockingGridView), "Ext.Net.Build.Ext.Net.ux.extensions.lockinggrid.LockingGridView.js", "/ux/extensions/lockinggrid/LockingGridView.js"));

                return baseList;
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.ux.grid.LockingGridView";
            }
        }

        /// <summary>
        /// The text displayed in the "Lock" menu item
        /// </summary>
        [Meta]
        [ConfigOption]
        [Localizable(true)]
        [Category("4. LockingGridView")]
        [DefaultValue("Lock")]
        [Description("The text displayed in the \"Lock\" menu item")]
        public virtual string LockText
        {
            get
            {
                return (string)this.ViewState["LockText"] ?? "Lock";
            }
            set
            {
                this.ViewState["LockText"] = value;
            }
        }

        /// <summary>
        /// The text displayed in the "Unlock" menu item
        /// </summary>
        [Meta]
        [ConfigOption]
        [Localizable(true)]
        [Category("4. LockingGridView")]
        [DefaultValue("Unlock")]
        [Description("The text displayed in the \"Unlock\" menu item")]
        public virtual string UnlockText
        {
            get
            {
                return (string)this.ViewState["UnlockText"] ?? "Unlock";
            }
            set
            {
                this.ViewState["UnlockText"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("4. LockingGridView")]
        [DefaultValue(1)]
        [Description("")]
        public virtual int RowBorderWidth
        {
            get
            {
                object obj = this.ViewState["RowBorderWidth"];
                return (obj == null) ? 1 : (int)obj;
            }
            set
            {
                this.ViewState["RowBorderWidth"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("4. LockingGridView")]
        [DefaultValue(1)]
        [Description("")]
        public virtual int LockedBorderWidth
        {
            get
            {
                object obj = this.ViewState["LockedBorderWidth"];
                return (obj == null) ? 1 : (int)obj;
            }
            set
            {
                this.ViewState["LockedBorderWidth"] = value;
            }
        }

        /// <summary>
        /// This option ensures that height between the rows is synchronized between the locked and unlocked sides. This option only needs to be used when the row heights isn't predictable.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("4. LockingGridView")]
        [DefaultValue(false)]
        public virtual bool SyncHeights
        {
            get
            {
                object obj = this.ViewState["SyncHeights"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["SyncHeights"] = value;
            }
        }
    }
}

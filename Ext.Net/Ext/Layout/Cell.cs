/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class Cell : LayoutItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Cell() { }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("rowspan", JsonMode.Raw)]
        [NotifyParentProperty(true)]
        [Category("6. TableLayout")]
        [DefaultValue(0)]
        [Description("")]
        public virtual int RowSpan
        {
            get
            {
                object obj = this.ViewState["RowSpan"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["RowSpan"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("colspan", JsonMode.Raw)]
        [NotifyParentProperty(true)]
        [Category("6. TableLayout")]
        [DefaultValue(0)]
        [Description("")]
        public virtual int ColSpan
        {
            get
            {
                object obj = this.ViewState["ColSpan"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["ColSpan"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. TableLayout")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string CellCls
        {
            get
            {
                return (string)this.ViewState["CellCls"] ?? "";
            }
            set
            {
                this.ViewState["CellCls"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. TableLayout")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string CellId
        {
            get
            {
                return (string)this.ViewState["CellId"] ?? "";
            }
            set
            {
                this.ViewState["CellId"] = value;
            }
        }
    }
}
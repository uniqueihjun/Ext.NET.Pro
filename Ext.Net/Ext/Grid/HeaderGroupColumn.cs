/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class HeaderGroupColumn : StateManagedItem
    {
        /// <summary>
        /// optional) Set the CSS text-align property of the column. Defaults to undefined.
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.ToLower)]
        [Category("2. HeaderGroupColumn")]
        [DefaultValue(Alignment.Left)]
        [Description("(optional) Set the CSS text-align property of the column. Defaults to undefined.")]
        public virtual Alignment Align
        {
            get
            {
                object obj = this.ViewState["Align"];
                return (obj == null) ? Alignment.Left : (Alignment)obj;
            }
            set
            {
                this.ViewState["Align"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("colspan")]
        [Category("2. HeaderGroupColumn")]
        [DefaultValue(1)]
        [Description("")]
        public virtual int ColSpan
        {
            get
            {
                object obj = this.ViewState["ColSpan"];
                return (obj == null) ? 1 : (int)obj;
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
        [ConfigOption("dataIndex")]
        [Category("2. HeaderGroupColumn")]
        [DefaultValue("")]
        [Description("")]
        public virtual string GroupId
        {
            get
            {
                object obj = this.ViewState["GroupId"];
                return (obj == null) ? "" : (string)obj;
            }
            set
            {
                this.ViewState["GroupId"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. HeaderGroupColumn")]
        [DefaultValue("")]
        [Description("")]
        public virtual string Tooltip
        {
            get
            {
                object obj = this.ViewState["Tooltip"];
                return (obj == null) ? "" : (string)obj;
            }
            set
            {
                this.ViewState["Tooltip"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("2. HeaderGroupColumn")]
        [DefaultValue("")]
        [Description("")]
        public virtual string Header
        {
            get
            {
                object obj = this.ViewState["Header"];
                return (obj == null) ? "" : (string)obj;
            }
            set
            {
                this.ViewState["Header"] = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class HeaderGroupColumns : StateManagedCollection<HeaderGroupColumn> { }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class HeaderGroupRow : StateManagedItem
    {
        private HeaderGroupColumns columns;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual HeaderGroupColumns Columns
        {
            get
            {
                if (this.columns == null)
                {
                    this.columns = new HeaderGroupColumns();
                }

                return this.columns;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class HeaderGroupRows : StateManagedCollection<HeaderGroupRow> { }
}
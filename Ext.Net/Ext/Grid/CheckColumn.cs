/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class CheckColumn : ColumnBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CheckColumn() { }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("xtype")]
        [DefaultValue("")]
		[Description("")]
        public virtual string XType
        {
            get
            {
                return "checkcolumn";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. CheckColumn")]
        [DefaultValue(false)]
        [Description("")]
        public override bool Editable
        {
            get
            {
                object obj = this.ViewState["Editable"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["Editable"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. CheckColumn")]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool SingleSelect
        {
            get
            {
                object obj = this.ViewState["SingleSelect"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["SingleSelect"] = value;
            }
        }
    }
}

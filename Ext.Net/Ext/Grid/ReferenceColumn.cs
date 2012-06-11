/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web.UI;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class ReferenceColumn : ColumnBase, ICustomConfigSerialization
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ReferenceColumn() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ReferenceColumn(string reference)
        {
            this.Reference = reference;
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue("")]
        [Description("")]
        public string Reference
        {
            get
            {
                object obj = this.ViewState["Reference"];
                return (obj == null) ? "" : (string)obj;
            }
            set
            {
                this.ViewState["Reference"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ToScript(Control owner)
        {
            return this.Reference;
        }
    }
}

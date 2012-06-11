/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class SelectedRow : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SelectedRow() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SelectedRow(string recordID)
        {
            this.RecordID = recordID;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SelectedRow(int rowIndex)
        {
            this.RowIndex = rowIndex;
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [DefaultValue("")]
        [ConfigOption]
        [Description("")]
        public string RecordID
        {
            get
            {
                return (string)this.ViewState["RecordID"] ?? "";
            }
            set
            {
                this.ViewState["RecordID"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [DefaultValue(-1)]
        [ConfigOption]
        [Description("")]
        public int RowIndex
        {
            get
            {
                object obj = this.ViewState["RowIndex"];
                return obj == null ? -1 : (int)obj;
            }
            set
            {
                this.ViewState["RowIndex"] = value;
            }
        }
    }
}
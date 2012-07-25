/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class SelectedRow : BaseItem
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
                return this.State.Get<string>("RecordID", "");
            }
            set
            {
                this.State.Set("RecordID", value);
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
                return this.State.Get<int>("RowIndex", -1);
            }
            set
            {
                this.State.Set("RowIndex", value);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class SelectedRowCollection : BaseItemCollection<SelectedRow>
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override bool CreateOnLoading
        {
            get
            {
                return true;
            }
        }
    }
}
/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
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
    public partial class SelectedCell : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SelectedCell() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SelectedCell(int rowIndex, int colIndex)
        {
            this.RowIndex = rowIndex;
            this.ColIndex = colIndex;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SelectedCell(string recordID, string name)
        {
            this.RecordID = recordID;
            this.Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [NotifyParentProperty(true)]
        [DefaultValue(-1)]
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

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [NotifyParentProperty(true)]
        [DefaultValue(-1)]
        [Description("")]
        public int ColIndex
        {
            get
            {
                object obj = this.ViewState["ColIndex"];
                return obj == null ? -1 : (int)obj;
            }
            set
            {
                this.ViewState["ColIndex"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [NotifyParentProperty(true)]
        [DefaultValue("")]
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
        [ConfigOption]
        [NotifyParentProperty(true)]
        [DefaultValue("")]
        [Description("")]
        public string Name
        {
            get
            {
                return (string)this.ViewState["Name"] ?? "";
            }
            set
            {
                this.ViewState["Name"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public virtual string Value
        {
            get
            {
                return (string)this.ViewState["Value"] ?? "";
            }
            internal set
            {
                this.ViewState["Value"] = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class SelectedCellSerializable : SelectedCell
    {
        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public string SubmittedValue
        {
            get 
            { 
                return this.Value; 
            }
            set 
            { 
                this.Value = value; 
            }
        }
    }
}
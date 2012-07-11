/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    public partial class SelectedCell : BaseItem
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
                return this.State.Get<int>("RowIndex", -1);
            }
            set
            {
                this.State.Set("RowIndex", value);
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
                return this.State.Get<int>("ColIndex", -1);
            }
            set
            {
                this.State.Set("ColIndex", value);
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
        [ConfigOption]
        [NotifyParentProperty(true)]
        [DefaultValue("")]
        [Description("")]
        public string Name
        {
            get
            {
                return this.State.Get<string>("Name", "");
            }
            set
            {
                this.State.Set("Name", value);
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
                return this.State.Get<string>("Value", "");
            }
            internal set
            {
                this.State.Set("Value", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Description("")]
        public void Clear()
        {
            this.RowIndex = -1;
            this.ColIndex = -1;
            this.RecordID = "";
            this.Name = "";
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
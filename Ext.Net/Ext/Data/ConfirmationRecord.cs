/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ConfirmationRecord
    {
        private bool confirm;
        private string oldId;
        private string newId;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfirmationRecord(bool confirm, string oldId)
        {
            this.confirm = confirm;
            this.oldId = oldId;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfirmationRecord()
        {
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Confirm
        {
            get { return confirm; }
            set { confirm = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string OldId
        {
            get { return oldId; }
            set { oldId = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string NewId
        {
            get { return newId; }
            set { newId = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void ConfirmRecord(string newId)
        {
            this.Confirm = true;
            this.NewId = newId;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void ConfirmRecord()
        {
            this.Confirm = true;
            this.NewId = this.oldId;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void UnConfirmRecord()
        {
            this.Confirm = false;
            this.NewId = null;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ConfirmationList : SortedList<string, ConfirmationRecord>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void ConfirmRecord(string oldId, string newId)
        {
            this[oldId].ConfirmRecord(newId);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void ConfirmRecord(string oldId)
        {
            this[oldId].ConfirmRecord();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ToJson()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            foreach (KeyValuePair<string, ConfirmationRecord> pair in this)
            {
                sb.AppendFormat("{{s:{0},oldId:{1},newId:{2}}},", pair.Value.Confirm.ToString().ToLower(), JSON.Serialize(pair.Value.OldId), JSON.Serialize(pair.Value.NewId ?? pair.Value.OldId));
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");

            return sb.ToString();
        }
    }
}

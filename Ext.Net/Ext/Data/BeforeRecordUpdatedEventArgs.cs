/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections;
using System.Xml;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BeforeRecordUpdatedEventArgs : RecordModifiedEventArgs
    {
		IDictionary keys;
		IDictionary newValues;
		IDictionary oldValues;
        private bool cancel;
        private bool cancelAll;
        private ConfirmationRecord confirmation;
		
        /// <summary>
        /// 
        /// </summary>
        /// <param name="record"></param>
        [Description("")]
        public BeforeRecordUpdatedEventArgs(XmlNode record) : base(record) { }

        internal BeforeRecordUpdatedEventArgs(XmlNode record, IDictionary keys, IDictionary newValues, IDictionary oldValues, ConfirmationRecord confirmation)
            : base(record)
		{
			this.keys = keys;
			this.newValues = newValues;
			this.oldValues = oldValues;
            this.confirmation = confirmation;
		}
		
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public IDictionary Keys
        {
			get { return keys; }
		}

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public IDictionary NewValues
        {
			get { return newValues; }
		}

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public IDictionary OldValues
        {
			get { return oldValues; }
		}

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Cancel
        {
            get { return cancel; }
            set { cancel = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool CancelAll
        {
            get { return cancelAll; }
            set { cancelAll = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfirmationRecord Confirmation
        {
            get
            {
                return confirmation;
            }
        }
    }
}
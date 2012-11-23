/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class BeforeRecordDeletedEventArgs : RecordModifiedEventArgs
    {
		IDictionary keys;
        private ConfirmationRecord confirmation;
        private bool cancel;
        private bool cancelAll;
		
        /// <summary>
        /// 
        /// </summary>
        /// <param name="record"></param>
        [Description("")]
        public BeforeRecordDeletedEventArgs(XmlNode record) : base(record) { }

        internal BeforeRecordDeletedEventArgs(XmlNode record, IDictionary keys, ConfirmationRecord confirmation)
            : base(record)
		{
			this.keys = keys;
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
            get { return confirmation; }
        }
    }
}
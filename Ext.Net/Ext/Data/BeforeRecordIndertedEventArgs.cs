/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections;
using System.Xml;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BeforeRecordInsertedEventArgs : RecordModifiedEventArgs
    {
        IDictionary keys;
        IDictionary newValues;
        private bool cancel;
        private bool cancelAll;
        private ConfirmationRecord confirmation;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BeforeRecordInsertedEventArgs(XmlNode record)
            : base(record) { }

        internal BeforeRecordInsertedEventArgs(XmlNode record, IDictionary keys, IDictionary newValues, ConfirmationRecord confirmation)
            : base(record)
        {
            this.keys = keys;
            this.newValues = newValues;
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
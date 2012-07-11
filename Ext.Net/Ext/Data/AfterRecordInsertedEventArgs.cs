/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections;
using System.ComponentModel;
using System.Xml;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class AfterRecordInsertedEventArgs : RecordModifiedEventArgs
    {
        private int rowsAffected;
        private Exception e;
        private bool exceptionHandled;
        IDictionary keys;
        IDictionary newValues;
        private ConfirmationRecord confirmation;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterRecordInsertedEventArgs(XmlNode record)
            : base(record) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterRecordInsertedEventArgs(XmlNode record, int rowsAffected, Exception e, IDictionary keys, IDictionary newValues, ConfirmationRecord confirmation)
            : base(record)
        {
            this.rowsAffected = rowsAffected;
            this.e = e;
            this.keys = keys;
            this.newValues = newValues;
            this.confirmation = confirmation;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int AffectedRows
        {
            get { return rowsAffected; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Exception Exception
        {
            get { return e; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool ExceptionHandled
        {
            get { return exceptionHandled; }
            set { exceptionHandled = value; }
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
        public ConfirmationRecord Confirmation
        {
            get
            {
                return confirmation;
            }
        }
    }
}
/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections;
using System.ComponentModel;

using Newtonsoft.Json.Linq;

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
        IDictionary values;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterRecordInsertedEventArgs(JToken record)
            : base(record) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterRecordInsertedEventArgs(JToken record, int rowsAffected, Exception e, IDictionary keys, IDictionary values)
            : base(record)
        {
            this.rowsAffected = rowsAffected;
            this.e = e;
            this.keys = keys;
            this.values = values;
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
        public IDictionary Values
        {
            get { return this.values; }
        }
    }
}
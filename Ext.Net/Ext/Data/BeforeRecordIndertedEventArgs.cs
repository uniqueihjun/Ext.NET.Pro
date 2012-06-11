/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections;
using System.ComponentModel;

using Newtonsoft.Json.Linq;

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

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BeforeRecordInsertedEventArgs(JToken record)
            : base(record) { }

        internal BeforeRecordInsertedEventArgs(JToken record, IDictionary keys, IDictionary newValues)
            : base(record)
        {
            this.keys = keys;
            this.newValues = newValues;
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
    }
}
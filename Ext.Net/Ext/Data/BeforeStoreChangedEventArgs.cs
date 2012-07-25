/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;

using Newtonsoft.Json.Linq;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BeforeStoreChangedEventArgs : EventArgs
    {
        private readonly StoreAction action;
        private readonly string jsonData;
        private bool cancel;
        private readonly JToken parameters;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BeforeStoreChangedEventArgs(string action, string jsonData)
        {
            this.jsonData = jsonData;
		    this.action = Store.Action(action);
		    this.cancel = false;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BeforeStoreChangedEventArgs(string action, string jsonData, JToken parameters)
            : this(action, jsonData)
		{
		    this.parameters = parameters;
		}

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public BeforeStoreChangedEventArgs(string action, string jsonData, JToken parameters, List<object> responseRecords)
            : this(action, jsonData, parameters)
        {
            this.responseRecords = responseRecords;
        }

        List<object> responseRecords;
        /// <summary>
        /// 
        /// </summary>
        public List<object> ResponseRecords
        {
            get
            {
                return this.responseRecords;
            }
        }

	    /// <summary>
	    /// 
	    /// </summary>
        public StoreAction Action
	    {
	        get
	        {
	            return action;
	        }
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

        private ParameterCollection p;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ParameterCollection Parameters
        {
            get
            {
                if (p != null)
                {
                    return p;
                }

                if (this.parameters == null)
                {
                    return new ParameterCollection();
                }

                p = ResourceManager.JTokenToParams(this.parameters);

                return p;
            }
        }

        private StoreDataHandler dataHandler;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreDataHandler DataHandler
        {
            get
            {
                return dataHandler ?? (dataHandler = new StoreDataHandler(jsonData));
            }
        }
    }
}
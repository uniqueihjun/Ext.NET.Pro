/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Xml;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BeforeStoreChangedEventArgs : EventArgs
    {
        private readonly string jsonData;
        private bool cancel;
        private readonly XmlNode ajaxPostBackParams;
        private ConfirmationList confirmationList;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BeforeStoreChangedEventArgs(string jsonData, ConfirmationList confirmationList)
        {
            this.jsonData = jsonData;
            this.cancel = false;
            this.confirmationList = confirmationList;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BeforeStoreChangedEventArgs(string jsonData, ConfirmationList confirmationList, XmlNode callbackParams)
            : this(jsonData, confirmationList)
        {
            this.ajaxPostBackParams = callbackParams;
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
        public XmlNode AjaxPostBackParams
        {
            get
            {
                return this.ajaxPostBackParams;
            }
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

                if (this.ajaxPostBackParams == null)
                {
                    return new ParameterCollection();
                }

                p = ResourceManager.XmlToParams(this.ajaxPostBackParams);

                return p;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfirmationList ConfirmationList
        {
            get
            {
                return confirmationList;
            }
            internal set
            {
                confirmationList = value;
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
                if (dataHandler == null)
                {
                    dataHandler = new StoreDataHandler(jsonData);
                }

                return dataHandler;
            }
        }
    }
}
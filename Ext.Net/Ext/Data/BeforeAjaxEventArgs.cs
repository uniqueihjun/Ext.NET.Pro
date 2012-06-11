/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Xml;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BeforeDirectEventArgs : EventArgs
    {
        private readonly string action;
        private readonly string data;
        private readonly XmlNode parameters;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BeforeDirectEventArgs() { }

        internal BeforeDirectEventArgs(string action, string data, XmlNode parameters)
        {
            this.action = action;
            this.data = data;
            this.parameters = parameters;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Action
        {
            get { return action; }
        }

        private StoreDataHandler dataHandler;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreDataHandler Data
        {
            get
            {
                if (dataHandler == null)
                {
                    dataHandler = new StoreDataHandler(data);
                }

                return dataHandler;
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

                p = new ParameterCollection();

                if (this.parameters == null)
                {
                    return p;
                }

                p = ResourceManager.XmlToParams(this.parameters);

                //foreach (XmlNode param in this.parameters.ChildNodes)
                //{
                //    p.Add(new Parameter(param.Name, param.InnerXml));
                //}

                return p;
            }
        }
    }
}
/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AjaxProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public AjaxProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit AjaxProxy.Config Conversion to AjaxProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AjaxProxy(AjaxProxy.Config config)
        {
            return new AjaxProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ServerProxy.Config 
        { 
			/*  Implicit AjaxProxy.Config Conversion to AjaxProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator AjaxProxy.Builder(AjaxProxy.Config config)
			{
				return new AjaxProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ParameterCollection headers = null;

			/// <summary>
			/// Any headers to add to the Ajax request. Defaults to undefined.
			/// </summary>
			public ParameterCollection Headers
			{
				get
				{
					if (this.headers == null)
					{
						this.headers = new ParameterCollection();
					}
			
					return this.headers;
				}
			}
			
			private bool json = false;

			/// <summary>
			/// Send params as JSON object
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Json 
			{ 
				get
				{
					return this.json;
				}
				set
				{
					this.json = value;
				}
			}

			private bool xml = false;

			/// <summary>
			/// Send params as XML object
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Xml 
			{ 
				get
				{
					return this.xml;
				}
				set
				{
					this.xml = value;
				}
			}
        
			private CRUDMethods actionMethods = null;

			/// <summary>
			/// Mapping of action name to HTTP request method. In the basic AjaxProxy these are set to 'GET' for 'read' actions and 'POST' for 'create', 'update' and 'destroy' actions. The Ext.data.proxy.Rest maps these to the correct RESTful methods.
			/// </summary>
			public CRUDMethods ActionMethods
			{
				get
				{
					if (this.actionMethods == null)
					{
						this.actionMethods = new CRUDMethods();
					}
			
					return this.actionMethods;
				}
			}
			        
			private JFunction getMethod = null;

			/// <summary>
			/// Returns the HTTP method name for a given request. By default this returns based on a lookup on actionMethods.
			/// </summary>
			public JFunction GetMethod
			{
				get
				{
					if (this.getMethod == null)
					{
						this.getMethod = new JFunction();
					}
			
					return this.getMethod;
				}
			}
			
        }
    }
}
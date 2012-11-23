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
    public abstract partial class ModelIdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : BaseItem.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string iD = "";

			/// <summary>
			/// The id by which to register a new instance. This instance can be found using the get static method.
			/// </summary>
			[DefaultValue("")]
			public virtual string ID 
			{ 
				get
				{
					return this.iD;
				}
				set
				{
					this.iD = value;
				}
			}
        
			private JFunction getRecId = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction GetRecId
			{
				get
				{
					if (this.getRecId == null)
					{
						this.getRecId = new JFunction();
					}
			
					return this.getRecId;
				}
			}
			
        }
    }
}
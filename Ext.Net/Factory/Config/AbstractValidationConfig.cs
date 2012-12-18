/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public abstract partial class AbstractValidation
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : BaseItem.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string field = null;

			/// <summary>
			/// The name of the field to validate
			/// </summary>
			[DefaultValue(null)]
			public virtual string Field 
			{ 
				get
				{
					return this.field;
				}
				set
				{
					this.field = value;
				}
			}

			private string message = null;

			/// <summary>
			/// The error message used when a validation fails
			/// </summary>
			[DefaultValue(null)]
			public virtual string Message 
			{ 
				get
				{
					return this.message;
				}
				set
				{
					this.message = value;
				}
			}

        }
    }
}
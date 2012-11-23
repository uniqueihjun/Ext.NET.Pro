/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public abstract partial class DataReader
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : StateManagedItem.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private RecordFieldCollection fields = null;

			/// <summary>
			/// Either a Collection of RecordField definition objects
			/// </summary>
			public RecordFieldCollection Fields
			{
				get
				{
					if (this.fields == null)
					{
						this.fields = new RecordFieldCollection();
					}
			
					return this.fields;
				}
			}
			
        }
    }
}
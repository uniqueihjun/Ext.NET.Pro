/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class HeaderRow
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public HeaderRow(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit HeaderRow.Config Conversion to HeaderRow
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HeaderRow(HeaderRow.Config config)
        {
            return new HeaderRow(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit HeaderRow.Config Conversion to HeaderRow.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator HeaderRow.Builder(HeaderRow.Config config)
			{
				return new HeaderRow.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private HeaderColumnCollection columns = null;

			/// <summary>
			/// 
			/// </summary>
			public HeaderColumnCollection Columns
			{
				get
				{
					if (this.columns == null)
					{
						this.columns = new HeaderColumnCollection();
					}
			
					return this.columns;
				}
			}
			
			private string cls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Cls 
			{ 
				get
				{
					return this.cls;
				}
				set
				{
					this.cls = value;
				}
			}

        }
    }
}
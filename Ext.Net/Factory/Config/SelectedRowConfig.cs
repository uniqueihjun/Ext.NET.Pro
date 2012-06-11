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
    public partial class SelectedRow
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SelectedRow(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SelectedRow.Config Conversion to SelectedRow
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SelectedRow(SelectedRow.Config config)
        {
            return new SelectedRow(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit SelectedRow.Config Conversion to SelectedRow.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SelectedRow.Builder(SelectedRow.Config config)
			{
				return new SelectedRow.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string recordID = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RecordID 
			{ 
				get
				{
					return this.recordID;
				}
				set
				{
					this.recordID = value;
				}
			}

			private int rowIndex = -1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(-1)]
			public virtual int RowIndex 
			{ 
				get
				{
					return this.rowIndex;
				}
				set
				{
					this.rowIndex = value;
				}
			}

        }
    }
}
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
    public abstract partial class CheckboxGroupBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : Field.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool allowBlank = true;

			/// <summary>
			/// False to validate that at least one item in the group is checked (defaults to true). If no items are selected at validation time, BlankText will be used as the error text.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool AllowBlank 
			{ 
				get
				{
					return this.allowBlank;
				}
				set
				{
					this.allowBlank = value;
				}
			}

			private string blankText = "";

			/// <summary>
			/// Error text to display if the AllowBlank validation fails (defaults to 'You must select at least one item in this group')
			/// </summary>
			[DefaultValue("")]
			public virtual string BlankText 
			{ 
				get
				{
					return this.blankText;
				}
				set
				{
					this.blankText = value;
				}
			}

			private int columnsNumber = 0;

			/// <summary>
			/// Specifies the number of columns to use when displaying grouped checkbox/radio controls using automatic layout.
			/// </summary>
			[DefaultValue(0)]
			public virtual int ColumnsNumber 
			{ 
				get
				{
					return this.columnsNumber;
				}
				set
				{
					this.columnsNumber = value;
				}
			}

			private string[] columnsWidths = null;

			/// <summary>
			/// You can also specify an array of column widths, mixing integer (fixed width) and float (percentage width) values as needed (e.g., [100, .25, .75]). Any integer values will be rendered first, then any float values will be calculated as a percentage of the remaining space. Float values do not have to add up to 1 (100%) although if you want the controls to take up the entire field container you should do so.
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] ColumnsWidths 
			{ 
				get
				{
					return this.columnsWidths;
				}
				set
				{
					this.columnsWidths = value;
				}
			}

			private bool fireChangeOnLoad = false;

			/// <summary>
			/// Fire change event after rendering
			/// </summary>
			[DefaultValue(false)]
			public virtual bool FireChangeOnLoad 
			{ 
				get
				{
					return this.fireChangeOnLoad;
				}
				set
				{
					this.fireChangeOnLoad = value;
				}
			}

			private bool vertical = false;

			/// <summary>
			/// True to distribute contained controls across columns, completely filling each column top to bottom before starting on the next column. The number of controls in each column will be automatically calculated to keep columns as even as possible. The default value is false, so that controls will be added to columns one at a time, completely filling each row left to right before starting on the next row.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Vertical 
			{ 
				get
				{
					return this.vertical;
				}
				set
				{
					this.vertical = value;
				}
			}

        }
    }
}
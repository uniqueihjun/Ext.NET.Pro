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
    public partial class SelectedCell
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SelectedCell(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SelectedCell.Config Conversion to SelectedCell
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SelectedCell(SelectedCell.Config config)
        {
            return new SelectedCell(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit SelectedCell.Config Conversion to SelectedCell.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SelectedCell.Builder(SelectedCell.Config config)
			{
				return new SelectedCell.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
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

			private int colIndex = -1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(-1)]
			public virtual int ColIndex 
			{ 
				get
				{
					return this.colIndex;
				}
				set
				{
					this.colIndex = value;
				}
			}

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

			private string name = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Name 
			{ 
				get
				{
					return this.name;
				}
				set
				{
					this.name = value;
				}
			}

        }
    }
}
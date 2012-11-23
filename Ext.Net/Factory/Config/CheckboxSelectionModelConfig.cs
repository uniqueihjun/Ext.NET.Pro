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
    public partial class CheckboxSelectionModel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CheckboxSelectionModel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CheckboxSelectionModel.Config Conversion to CheckboxSelectionModel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CheckboxSelectionModel(CheckboxSelectionModel.Config config)
        {
            return new CheckboxSelectionModel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : RowSelectionModel.Config 
        { 
			/*  Implicit CheckboxSelectionModel.Config Conversion to CheckboxSelectionModel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CheckboxSelectionModel.Builder(CheckboxSelectionModel.Config config)
			{
				return new CheckboxSelectionModel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool checkOnly = false;

			/// <summary>
			/// true if rows can only be selected by clicking on the checkbox column (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool CheckOnly 
			{ 
				get
				{
					return this.checkOnly;
				}
				set
				{
					this.checkOnly = value;
				}
			}

			private string injectCheckbox = "0";

			/// <summary>
			/// Instructs the SelectionModel whether or not to inject the checkbox header automatically or not. (Note: By not placing the checkbox in manually, the grid view will need to be rendered 2x on initial render.) Supported values are a Number index, false and the strings 'first' and 'last'. Default is 0.
			/// </summary>
			[DefaultValue("0")]
			public virtual string InjectCheckbox 
			{ 
				get
				{
					return this.injectCheckbox;
				}
				set
				{
					this.injectCheckbox = value;
				}
			}

			private int rowSpan = 1;

			/// <summary>
			/// RowSpan attribute for the checkbox table cell
			/// </summary>
			[DefaultValue(1)]
			public virtual int RowSpan 
			{ 
				get
				{
					return this.rowSpan;
				}
				set
				{
					this.rowSpan = value;
				}
			}

			private bool showHeaderCheckbox = true;

			/// <summary>
			/// RowSpan attribute for the checkbox table cell
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowHeaderCheckbox 
			{ 
				get
				{
					return this.showHeaderCheckbox;
				}
				set
				{
					this.showHeaderCheckbox = value;
				}
			}

			private Renderer renderer = null;

			/// <summary>
			/// (optional) A function used to generate HTML markup for a cell given the cell's data value. If not specified, the default renderer uses the raw data value.
			/// </summary>
			[DefaultValue(null)]
			public virtual Renderer Renderer 
			{ 
				get
				{
					return this.renderer;
				}
				set
				{
					this.renderer = value;
				}
			}

        }
    }
}
/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class PropertyGridParameter
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public PropertyGridParameter(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit PropertyGridParameter.Config Conversion to PropertyGridParameter
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PropertyGridParameter(PropertyGridParameter.Config config)
        {
            return new PropertyGridParameter(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseParameter.Config 
        { 
			/*  Implicit PropertyGridParameter.Config Conversion to PropertyGridParameter.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator PropertyGridParameter.Builder(PropertyGridParameter.Config config)
			{
				return new PropertyGridParameter.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private EditorCollection editor = null;

			/// <summary>
			/// (optional) The Ext.form.Field to use when editing values in this column if editing is supported by the grid.
			/// </summary>
			public EditorCollection Editor
			{
				get
				{
					if (this.editor == null)
					{
						this.editor = new EditorCollection();
					}
			
					return this.editor;
				}
			}
			        
			private CellEditorOptions editorOptions = null;

			/// <summary>
			/// Editor options
			/// </summary>
			public CellEditorOptions EditorOptions
			{
				get
				{
					if (this.editorOptions == null)
					{
						this.editorOptions = new CellEditorOptions();
					}
			
					return this.editorOptions;
				}
			}
			
			private string displayName = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string DisplayName 
			{ 
				get
				{
					return this.displayName;
				}
				set
				{
					this.displayName = value;
				}
			}

        }
    }
}
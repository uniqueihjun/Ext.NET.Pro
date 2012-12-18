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
			
			private string displayName = "";

			/// <summary>
			/// A custom name to appear as label for this field. If specified, the display name will be shown in the name column instead of the property name.
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

			private PropertyGridEditorType editorType = PropertyGridEditorType.Auto;

			/// <summary>
			/// Used to explicitly specify the editor type for a particular value. By default, the type is automatically inferred from the value. See inferTypes.
			/// </summary>
			[DefaultValue(PropertyGridEditorType.Auto)]
			public virtual PropertyGridEditorType EditorType 
			{ 
				get
				{
					return this.editorType;
				}
				set
				{
					this.editorType = value;
				}
			}
        
			private EditorCollection editor = null;

			/// <summary>
			/// Allows the grid to support additional types of editable fields. By default, the grid supports strongly-typed editing of strings, dates, numbers and booleans using built-in form editors, but any custom type can be supported and associated with a custom input control by specifying a custom editor.
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
			
        }
    }
}
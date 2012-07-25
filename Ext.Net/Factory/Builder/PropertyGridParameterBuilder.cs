/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseParameter.Builder<PropertyGridParameter, PropertyGridParameter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new PropertyGridParameter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PropertyGridParameter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PropertyGridParameter.Config config) : base(new PropertyGridParameter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(PropertyGridParameter component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// (optional) The Ext.form.Field to use when editing values in this column if editing is supported by the grid.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of PropertyGridParameter.Builder</returns>
            public virtual PropertyGridParameter.Builder Editor(Action<EditorCollection> action)
            {
                action(this.ToComponent().Editor);
                return this as PropertyGridParameter.Builder;
            }
			 
 			/// <summary>
			/// Editor options
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of PropertyGridParameter.Builder</returns>
            public virtual PropertyGridParameter.Builder EditorOptions(Action<CellEditorOptions> action)
            {
                action(this.ToComponent().EditorOptions);
                return this as PropertyGridParameter.Builder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual PropertyGridParameter.Builder DisplayName(string displayName)
            {
                this.ToComponent().DisplayName = displayName;
                return this as PropertyGridParameter.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public PropertyGridParameter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.PropertyGridParameter(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public PropertyGridParameter.Builder PropertyGridParameter()
        {
            return this.PropertyGridParameter(new PropertyGridParameter());
        }

        /// <summary>
        /// 
        /// </summary>
        public PropertyGridParameter.Builder PropertyGridParameter(PropertyGridParameter component)
        {
            return new PropertyGridParameter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public PropertyGridParameter.Builder PropertyGridParameter(PropertyGridParameter.Config config)
        {
            return new PropertyGridParameter.Builder(new PropertyGridParameter(config));
        }
    }
}
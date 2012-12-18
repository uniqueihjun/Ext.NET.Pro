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
    public partial class DataViewLabelEditor
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDataViewLabelEditor, TBuilder> : Plugin.Builder<TDataViewLabelEditor, TBuilder>
            where TDataViewLabelEditor : DataViewLabelEditor
            where TBuilder : Builder<TDataViewLabelEditor, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDataViewLabelEditor component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DataIndex(string dataIndex)
            {
                this.ToComponent().DataIndex = dataIndex;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// x-editable
			/// </summary>
            public virtual TBuilder LabelSelector(string labelSelector)
            {
                this.ToComponent().LabelSelector = labelSelector;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DataViewLabelEditor.Builder<DataViewLabelEditor, DataViewLabelEditor.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DataViewLabelEditor()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewLabelEditor component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewLabelEditor.Config config) : base(new DataViewLabelEditor(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DataViewLabelEditor component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewLabelEditor.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DataViewLabelEditor(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DataViewLabelEditor.Builder DataViewLabelEditor()
        {
#if MVC
			return this.DataViewLabelEditor(new DataViewLabelEditor { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DataViewLabelEditor(new DataViewLabelEditor());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewLabelEditor.Builder DataViewLabelEditor(DataViewLabelEditor component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DataViewLabelEditor.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewLabelEditor.Builder DataViewLabelEditor(DataViewLabelEditor.Config config)
        {
#if MVC
			return new DataViewLabelEditor.Builder(new DataViewLabelEditor(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DataViewLabelEditor.Builder(new DataViewLabelEditor(config));
#endif			
        }
    }
}
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
    public partial class DataViewDragSelector
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDataViewDragSelector, TBuilder> : Plugin.Builder<TDataViewDragSelector, TBuilder>
            where TDataViewDragSelector : DataViewDragSelector
            where TBuilder : Builder<TDataViewDragSelector, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDataViewDragSelector component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DataViewDragSelector.Builder<DataViewDragSelector, DataViewDragSelector.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DataViewDragSelector()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewDragSelector component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewDragSelector.Config config) : base(new DataViewDragSelector(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DataViewDragSelector component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewDragSelector.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DataViewDragSelector(this);
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
        public DataViewDragSelector.Builder DataViewDragSelector()
        {
#if MVC
			return this.DataViewDragSelector(new DataViewDragSelector { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DataViewDragSelector(new DataViewDragSelector());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewDragSelector.Builder DataViewDragSelector(DataViewDragSelector component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DataViewDragSelector.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewDragSelector.Builder DataViewDragSelector(DataViewDragSelector.Config config)
        {
#if MVC
			return new DataViewDragSelector.Builder(new DataViewDragSelector(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DataViewDragSelector.Builder(new DataViewDragSelector(config));
#endif			
        }
    }
}
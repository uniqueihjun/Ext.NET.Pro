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
    public partial class SelectBox
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TSelectBox, TBuilder> : ComboBox.Builder<TSelectBox, TBuilder>
            where TSelectBox : SelectBox
            where TBuilder : Builder<TSelectBox, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TSelectBox component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : SelectBox.Builder<SelectBox, SelectBox.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SelectBox()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectBox component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectBox.Config config) : base(new SelectBox(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SelectBox component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectBox.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SelectBox(this);
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
        public SelectBox.Builder SelectBox()
        {
#if MVC
			return this.SelectBox(new SelectBox { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.SelectBox(new SelectBox());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectBox.Builder SelectBox(SelectBox component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new SelectBox.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectBox.Builder SelectBox(SelectBox.Config config)
        {
#if MVC
			return new SelectBox.Builder(new SelectBox(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new SelectBox.Builder(new SelectBox(config));
#endif			
        }
    }
}
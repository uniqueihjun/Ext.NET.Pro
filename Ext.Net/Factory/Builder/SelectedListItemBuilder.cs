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
    public partial class SelectedListItem
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TSelectedListItem, TBuilder> : BaseItem.Builder<TSelectedListItem, TBuilder>
            where TSelectedListItem : SelectedListItem
            where TBuilder : Builder<TSelectedListItem, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TSelectedListItem component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Value(string value)
            {
                this.ToComponent().Value = value;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Index(int index)
            {
                this.ToComponent().Index = index;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : SelectedListItem.Builder<SelectedListItem, SelectedListItem.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SelectedListItem()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedListItem component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedListItem.Config config) : base(new SelectedListItem(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SelectedListItem component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedListItem.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SelectedListItem(this);
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
        public SelectedListItem.Builder SelectedListItem()
        {
#if MVC
			return this.SelectedListItem(new SelectedListItem { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.SelectedListItem(new SelectedListItem());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedListItem.Builder SelectedListItem(SelectedListItem component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new SelectedListItem.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedListItem.Builder SelectedListItem(SelectedListItem.Config config)
        {
#if MVC
			return new SelectedListItem.Builder(new SelectedListItem(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new SelectedListItem.Builder(new SelectedListItem(config));
#endif			
        }
    }
}
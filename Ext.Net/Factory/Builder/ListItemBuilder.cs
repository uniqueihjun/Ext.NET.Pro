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
    public partial class ListItem
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TListItem, TBuilder> : BaseItem.Builder<TListItem, TBuilder>
            where TListItem : ListItem
            where TBuilder : Builder<TListItem, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TListItem component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as TBuilder;
            }
             
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
             
 			/// <summary>
			/// Wrap in quotes or not
			/// </summary>
            public virtual TBuilder Mode(ParameterMode mode)
            {
                this.ToComponent().Mode = mode;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ListItem.Builder<ListItem, ListItem.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ListItem()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ListItem component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ListItem.Config config) : base(new ListItem(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ListItem component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ListItem(this);
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
        public ListItem.Builder ListItem()
        {
#if MVC
			return this.ListItem(new ListItem { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ListItem(new ListItem());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ListItem(ListItem component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ListItem.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ListItem(ListItem.Config config)
        {
#if MVC
			return new ListItem.Builder(new ListItem(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ListItem.Builder(new ListItem(config));
#endif			
        }
    }
}
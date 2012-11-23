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
    public partial class SelectedRow
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TSelectedRow, TBuilder> : BaseItem.Builder<TSelectedRow, TBuilder>
            where TSelectedRow : SelectedRow
            where TBuilder : Builder<TSelectedRow, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TSelectedRow component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RecordID(string recordID)
            {
                this.ToComponent().RecordID = recordID;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RowIndex(int rowIndex)
            {
                this.ToComponent().RowIndex = rowIndex;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : SelectedRow.Builder<SelectedRow, SelectedRow.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SelectedRow()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedRow component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedRow.Config config) : base(new SelectedRow(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SelectedRow component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedRow.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SelectedRow(this);
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
        public SelectedRow.Builder SelectedRow()
        {
#if MVC
			return this.SelectedRow(new SelectedRow { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.SelectedRow(new SelectedRow());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedRow.Builder SelectedRow(SelectedRow component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new SelectedRow.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedRow.Builder SelectedRow(SelectedRow.Config config)
        {
#if MVC
			return new SelectedRow.Builder(new SelectedRow(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new SelectedRow.Builder(new SelectedRow(config));
#endif			
        }
    }
}
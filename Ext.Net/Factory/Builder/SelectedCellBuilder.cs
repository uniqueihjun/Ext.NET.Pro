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
    public partial class SelectedCell
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TSelectedCell, TBuilder> : BaseItem.Builder<TSelectedCell, TBuilder>
            where TSelectedCell : SelectedCell
            where TBuilder : Builder<TSelectedCell, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TSelectedCell component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RowIndex(int rowIndex)
            {
                this.ToComponent().RowIndex = rowIndex;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ColIndex(int colIndex)
            {
                this.ToComponent().ColIndex = colIndex;
                return this as TBuilder;
            }
             
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
            public virtual TBuilder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Clear()
            {
                this.ToComponent().Clear();
                return this as TBuilder;
            }
            
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : SelectedCell.Builder<SelectedCell, SelectedCell.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SelectedCell()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedCell component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SelectedCell.Config config) : base(new SelectedCell(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SelectedCell component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedCell.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SelectedCell(this);
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
        public SelectedCell.Builder SelectedCell()
        {
#if MVC
			return this.SelectedCell(new SelectedCell { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.SelectedCell(new SelectedCell());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedCell.Builder SelectedCell(SelectedCell component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new SelectedCell.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SelectedCell.Builder SelectedCell(SelectedCell.Config config)
        {
#if MVC
			return new SelectedCell.Builder(new SelectedCell(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new SelectedCell.Builder(new SelectedCell(config));
#endif			
        }
    }
}
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
    public partial class RatingColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TRatingColumn, TBuilder> : ColumnBase.Builder<TRatingColumn, TBuilder>
            where TRatingColumn : RatingColumn
            where TBuilder : Builder<TRatingColumn, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TRatingColumn component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// (optional) The name of the field in the grid's Ext.data.Store's Ext.data.Record definition from which to draw the column's value. If not specified, the column's index is used as an index into the Record's data Array.
			/// </summary>
            public virtual TBuilder DataIndex(string dataIndex)
            {
                this.ToComponent().DataIndex = dataIndex;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Editable(bool editable)
            {
                this.ToComponent().Editable = editable;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AllowChange(bool allowChange)
            {
                this.ToComponent().AllowChange = allowChange;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SelectedCls(string selectedCls)
            {
                this.ToComponent().SelectedCls = selectedCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder UnselectedCls(string unselectedCls)
            {
                this.ToComponent().UnselectedCls = unselectedCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder MaxRating(int maxRating)
            {
                this.ToComponent().MaxRating = maxRating;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder TickSize(int tickSize)
            {
                this.ToComponent().TickSize = tickSize;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RoundToTick(bool roundToTick)
            {
                this.ToComponent().RoundToTick = roundToTick;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : RatingColumn.Builder<RatingColumn, RatingColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RatingColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RatingColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RatingColumn.Config config) : base(new RatingColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RatingColumn component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public RatingColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RatingColumn(this);
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
        public RatingColumn.Builder RatingColumn()
        {
#if MVC
			return this.RatingColumn(new RatingColumn { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.RatingColumn(new RatingColumn());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public RatingColumn.Builder RatingColumn(RatingColumn component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new RatingColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RatingColumn.Builder RatingColumn(RatingColumn.Config config)
        {
#if MVC
			return new RatingColumn.Builder(new RatingColumn(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new RatingColumn.Builder(new RatingColumn(config));
#endif			
        }
    }
}
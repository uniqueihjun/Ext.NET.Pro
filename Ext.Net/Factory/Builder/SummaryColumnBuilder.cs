/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class SummaryColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Column.Builder<SummaryColumn, SummaryColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SummaryColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SummaryColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SummaryColumn.Config config) : base(new SummaryColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SummaryColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual SummaryColumn.Builder SummaryType(SummaryType summaryType)
            {
                this.ToComponent().SummaryType = summaryType;
                return this as SummaryColumn.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual SummaryColumn.Builder CustomSummaryType(string customSummaryType)
            {
                this.ToComponent().CustomSummaryType = customSummaryType;
                return this as SummaryColumn.Builder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of SummaryColumn.Builder</returns>
            public virtual SummaryColumn.Builder SummaryRenderer(Action<JFunction> action)
            {
                action(this.ToComponent().SummaryRenderer);
                return this as SummaryColumn.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public SummaryColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SummaryColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SummaryColumn.Builder SummaryColumn()
        {
            return this.SummaryColumn(new SummaryColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public SummaryColumn.Builder SummaryColumn(SummaryColumn component)
        {
            return new SummaryColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SummaryColumn.Builder SummaryColumn(SummaryColumn.Config config)
        {
            return new SummaryColumn.Builder(new SummaryColumn(config));
        }
    }
}
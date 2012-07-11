/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public abstract partial class AbstractSummary
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TAbstractSummary, TBuilder> : GridFeature.Builder<TAbstractSummary, TBuilder>
            where TAbstractSummary : AbstractSummary
            where TBuilder : Builder<TAbstractSummary, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAbstractSummary component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// true to add css for column separation lines. Default is false.
			/// </summary>
            public virtual TBuilder ShowSummaryRow(bool showSummaryRow)
            {
                this.ToComponent().ShowSummaryRow = showSummaryRow;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}
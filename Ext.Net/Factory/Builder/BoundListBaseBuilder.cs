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
    public abstract partial class BoundListBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TBoundListBase, TBuilder> : AbstractDataView.Builder<TBoundListBase, TBuilder>
            where TBoundListBase : BoundListBase
            where TBuilder : Builder<TBoundListBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TBoundListBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// If greater than 0, a Ext.toolbar.Paging is displayed at the bottom of the list and store queries will execute with page start and limit parameters. Defaults to 0.
			/// </summary>
            public virtual TBuilder PageSize(int pageSize)
            {
                this.ToComponent().PageSize = pageSize;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The inner portion of the item template to be rendered. Follows an XTemplate structure and will be placed inside of a tpl.
			/// </summary>
            public virtual TBuilder ItemTpl(XTemplate itemTpl)
            {
                this.ToComponent().ItemTpl = itemTpl;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}
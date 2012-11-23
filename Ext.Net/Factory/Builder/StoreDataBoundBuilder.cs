/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public abstract partial class StoreDataBound
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TStoreDataBound, TBuilder> : StoreBase.Builder<TStoreDataBound, TBuilder>
            where TStoreDataBound : StoreDataBound
            where TBuilder : Builder<TStoreDataBound, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TStoreDataBound component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DataSource(object dataSource)
            {
                this.ToComponent().DataSource = dataSource;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DataSourceID(string dataSourceID)
            {
                this.ToComponent().DataSourceID = dataSourceID;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DataMember(string dataMember)
            {
                this.ToComponent().DataMember = dataMember;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DataBind()
            {
                this.ToComponent().DataBind();
                return this as TBuilder;
            }
            
        }        
    }
}
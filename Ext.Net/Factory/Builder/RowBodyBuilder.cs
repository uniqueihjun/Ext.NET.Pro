/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class RowBody
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : GridFeature.Builder<RowBody, RowBody.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RowBody()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowBody component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowBody.Config config) : base(new RowBody(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RowBody component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual RowBody.Builder RowBodyHiddenCls(string rowBodyHiddenCls)
            {
                this.ToComponent().RowBodyHiddenCls = rowBodyHiddenCls;
                return this as RowBody.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RowBody.Builder RowBodyTrCls(string rowBodyTrCls)
            {
                this.ToComponent().RowBodyTrCls = rowBodyTrCls;
                return this as RowBody.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RowBody.Builder RowBodyTdCls(string rowBodyTdCls)
            {
                this.ToComponent().RowBodyTdCls = rowBodyTdCls;
                return this as RowBody.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RowBody.Builder RowBodyDivCls(string rowBodyDivCls)
            {
                this.ToComponent().RowBodyDivCls = rowBodyDivCls;
                return this as RowBody.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RowBody.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RowBody(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RowBody.Builder RowBody()
        {
            return this.RowBody(new RowBody());
        }

        /// <summary>
        /// 
        /// </summary>
        public RowBody.Builder RowBody(RowBody component)
        {
            return new RowBody.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RowBody.Builder RowBody(RowBody.Config config)
        {
            return new RowBody.Builder(new RowBody(config));
        }
    }
}
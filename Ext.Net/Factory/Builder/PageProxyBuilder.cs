/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class PageProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DataProxy.Builder<PageProxy, PageProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new PageProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PageProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PageProxy.Config config) : base(new PageProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(PageProxy component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual PageProxy.Builder Total(int total)
            {
                this.ToComponent().Total = total;
                return this as PageProxy.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public PageProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.PageProxy(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public PageProxy.Builder PageProxy()
        {
            return this.PageProxy(new PageProxy());
        }

        /// <summary>
        /// 
        /// </summary>
        public PageProxy.Builder PageProxy(PageProxy component)
        {
            return new PageProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public PageProxy.Builder PageProxy(PageProxy.Config config)
        {
            return new PageProxy.Builder(new PageProxy(config));
        }
    }
}
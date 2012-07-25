/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class CRUDMethods
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<CRUDMethods, CRUDMethods.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CRUDMethods()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CRUDMethods component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CRUDMethods.Config config) : base(new CRUDMethods(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CRUDMethods component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual CRUDMethods.Builder Create(HttpMethod create)
            {
                this.ToComponent().Create = create;
                return this as CRUDMethods.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual CRUDMethods.Builder Read(HttpMethod read)
            {
                this.ToComponent().Read = read;
                return this as CRUDMethods.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual CRUDMethods.Builder Update(HttpMethod update)
            {
                this.ToComponent().Update = update;
                return this as CRUDMethods.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual CRUDMethods.Builder Destroy(HttpMethod destroy)
            {
                this.ToComponent().Destroy = destroy;
                return this as CRUDMethods.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CRUDMethods.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CRUDMethods(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CRUDMethods.Builder CRUDMethods()
        {
            return this.CRUDMethods(new CRUDMethods());
        }

        /// <summary>
        /// 
        /// </summary>
        public CRUDMethods.Builder CRUDMethods(CRUDMethods component)
        {
            return new CRUDMethods.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CRUDMethods.Builder CRUDMethods(CRUDMethods.Config config)
        {
            return new CRUDMethods.Builder(new CRUDMethods(config));
        }
    }
}
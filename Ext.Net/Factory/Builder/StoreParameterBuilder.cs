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
    public partial class StoreParameter
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Parameter.Builder<StoreParameter, StoreParameter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new StoreParameter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(StoreParameter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(StoreParameter.Config config) : base(new StoreParameter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(StoreParameter component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual StoreParameter.Builder ApplyMode(ApplyMode applyMode)
            {
                this.ToComponent().ApplyMode = applyMode;
                return this as StoreParameter.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual StoreParameter.Builder Action(StoreAction? action)
            {
                this.ToComponent().Action = action;
                return this as StoreParameter.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public StoreParameter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.StoreParameter(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public StoreParameter.Builder StoreParameter()
        {
            return this.StoreParameter(new StoreParameter());
        }

        /// <summary>
        /// 
        /// </summary>
        public StoreParameter.Builder StoreParameter(StoreParameter component)
        {
            return new StoreParameter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public StoreParameter.Builder StoreParameter(StoreParameter.Config config)
        {
            return new StoreParameter.Builder(new StoreParameter(config));
        }
    }
}
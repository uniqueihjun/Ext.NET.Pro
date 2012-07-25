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
    public partial class LengthValidation
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractValidation.Builder<LengthValidation, LengthValidation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new LengthValidation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LengthValidation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LengthValidation.Config config) : base(new LengthValidation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(LengthValidation component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Maximum value length allowed.
			/// </summary>
            public virtual LengthValidation.Builder Max(int max)
            {
                this.ToComponent().Max = max;
                return this as LengthValidation.Builder;
            }
             
 			/// <summary>
			/// Minimum value length allowed.
			/// </summary>
            public virtual LengthValidation.Builder Min(int min)
            {
                this.ToComponent().Min = min;
                return this as LengthValidation.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public LengthValidation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.LengthValidation(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public LengthValidation.Builder LengthValidation()
        {
            return this.LengthValidation(new LengthValidation());
        }

        /// <summary>
        /// 
        /// </summary>
        public LengthValidation.Builder LengthValidation(LengthValidation component)
        {
            return new LengthValidation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public LengthValidation.Builder LengthValidation(LengthValidation.Config config)
        {
            return new LengthValidation.Builder(new LengthValidation(config));
        }
    }
}
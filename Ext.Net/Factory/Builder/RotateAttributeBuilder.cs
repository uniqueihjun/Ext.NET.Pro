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
    public partial class RotateAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TranslateAttribute.Builder<RotateAttribute, RotateAttribute.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RotateAttribute()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RotateAttribute component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RotateAttribute.Config config) : base(new RotateAttribute(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RotateAttribute component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual RotateAttribute.Builder Degrees(int? degrees)
            {
                this.ToComponent().Degrees = degrees;
                return this as RotateAttribute.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RotateAttribute.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RotateAttribute(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RotateAttribute.Builder RotateAttribute()
        {
            return this.RotateAttribute(new RotateAttribute());
        }

        /// <summary>
        /// 
        /// </summary>
        public RotateAttribute.Builder RotateAttribute(RotateAttribute component)
        {
            return new RotateAttribute.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RotateAttribute.Builder RotateAttribute(RotateAttribute.Config config)
        {
            return new RotateAttribute.Builder(new RotateAttribute(config));
        }
    }
}
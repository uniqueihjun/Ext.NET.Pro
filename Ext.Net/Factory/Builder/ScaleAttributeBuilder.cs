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
    public partial class ScaleAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TranslateAttribute.Builder<ScaleAttribute, ScaleAttribute.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ScaleAttribute()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ScaleAttribute component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ScaleAttribute.Config config) : base(new ScaleAttribute(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ScaleAttribute component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual ScaleAttribute.Builder CX(double? cX)
            {
                this.ToComponent().CX = cX;
                return this as ScaleAttribute.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ScaleAttribute.Builder CY(double? cY)
            {
                this.ToComponent().CY = cY;
                return this as ScaleAttribute.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ScaleAttribute.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ScaleAttribute(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ScaleAttribute.Builder ScaleAttribute()
        {
            return this.ScaleAttribute(new ScaleAttribute());
        }

        /// <summary>
        /// 
        /// </summary>
        public ScaleAttribute.Builder ScaleAttribute(ScaleAttribute component)
        {
            return new ScaleAttribute.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ScaleAttribute.Builder ScaleAttribute(ScaleAttribute.Config config)
        {
            return new ScaleAttribute.Builder(new ScaleAttribute(config));
        }
    }
}
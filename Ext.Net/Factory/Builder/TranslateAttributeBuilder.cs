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
    public partial class TranslateAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<TranslateAttribute, TranslateAttribute.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TranslateAttribute()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TranslateAttribute component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TranslateAttribute.Config config) : base(new TranslateAttribute(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TranslateAttribute component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TranslateAttribute.Builder X(double? x)
            {
                this.ToComponent().X = x;
                return this as TranslateAttribute.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TranslateAttribute.Builder Y(double? y)
            {
                this.ToComponent().Y = y;
                return this as TranslateAttribute.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TranslateAttribute.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TranslateAttribute(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TranslateAttribute.Builder TranslateAttribute()
        {
            return this.TranslateAttribute(new TranslateAttribute());
        }

        /// <summary>
        /// 
        /// </summary>
        public TranslateAttribute.Builder TranslateAttribute(TranslateAttribute component)
        {
            return new TranslateAttribute.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TranslateAttribute.Builder TranslateAttribute(TranslateAttribute.Config config)
        {
            return new TranslateAttribute.Builder(new TranslateAttribute(config));
        }
    }
}
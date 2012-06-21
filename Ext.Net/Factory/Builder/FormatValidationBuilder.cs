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
    public partial class FormatValidation
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractValidation.Builder<FormatValidation, FormatValidation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FormatValidation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FormatValidation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FormatValidation.Config config) : base(new FormatValidation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FormatValidation component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A JavaScript RegExp object to be tested against the value
			/// </summary>
            public virtual FormatValidation.Builder Regex(string regex)
            {
                this.ToComponent().Regex = regex;
                return this as FormatValidation.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public FormatValidation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FormatValidation(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FormatValidation.Builder FormatValidation()
        {
            return this.FormatValidation(new FormatValidation());
        }

        /// <summary>
        /// 
        /// </summary>
        public FormatValidation.Builder FormatValidation(FormatValidation component)
        {
            return new FormatValidation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FormatValidation.Builder FormatValidation(FormatValidation.Config config)
        {
            return new FormatValidation.Builder(new FormatValidation(config));
        }
    }
}
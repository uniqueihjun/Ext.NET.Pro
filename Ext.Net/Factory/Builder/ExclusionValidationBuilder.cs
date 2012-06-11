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
    public partial class ExclusionValidation
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractValidation.Builder<ExclusionValidation, ExclusionValidation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ExclusionValidation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ExclusionValidation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ExclusionValidation.Config config) : base(new ExclusionValidation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ExclusionValidation component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ExclusionValidation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ExclusionValidation(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ExclusionValidation.Builder ExclusionValidation()
        {
            return this.ExclusionValidation(new ExclusionValidation());
        }

        /// <summary>
        /// 
        /// </summary>
        public ExclusionValidation.Builder ExclusionValidation(ExclusionValidation component)
        {
            return new ExclusionValidation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ExclusionValidation.Builder ExclusionValidation(ExclusionValidation.Config config)
        {
            return new ExclusionValidation.Builder(new ExclusionValidation(config));
        }
    }
}
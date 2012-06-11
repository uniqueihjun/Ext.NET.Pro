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
    public partial class InclusionValidation
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractValidation.Builder<InclusionValidation, InclusionValidation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new InclusionValidation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(InclusionValidation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(InclusionValidation.Config config) : base(new InclusionValidation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(InclusionValidation component)
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
        public InclusionValidation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.InclusionValidation(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public InclusionValidation.Builder InclusionValidation()
        {
            return this.InclusionValidation(new InclusionValidation());
        }

        /// <summary>
        /// 
        /// </summary>
        public InclusionValidation.Builder InclusionValidation(InclusionValidation component)
        {
            return new InclusionValidation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public InclusionValidation.Builder InclusionValidation(InclusionValidation.Config config)
        {
            return new InclusionValidation.Builder(new InclusionValidation(config));
        }
    }
}
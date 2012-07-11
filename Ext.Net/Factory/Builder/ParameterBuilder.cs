/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class Parameter
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseParameter.Builder<Parameter, Parameter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Parameter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Parameter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Parameter.Config config) : base(new Parameter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Parameter component)
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
        public Parameter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Parameter(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Parameter.Builder Parameter()
        {
            return this.Parameter(new Parameter());
        }

        /// <summary>
        /// 
        /// </summary>
        public Parameter.Builder Parameter(Parameter component)
        {
            return new Parameter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Parameter.Builder Parameter(Parameter.Config config)
        {
            return new Parameter.Builder(new Parameter(config));
        }
    }
}
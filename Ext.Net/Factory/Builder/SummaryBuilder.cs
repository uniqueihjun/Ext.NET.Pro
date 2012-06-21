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
    public partial class Summary
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractSummary.Builder<Summary, Summary.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Summary()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Summary component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Summary.Config config) : base(new Summary(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Summary component)
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
        public Summary.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Summary(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Summary.Builder Summary()
        {
            return this.Summary(new Summary());
        }

        /// <summary>
        /// 
        /// </summary>
        public Summary.Builder Summary(Summary component)
        {
            return new Summary.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Summary.Builder Summary(Summary.Config config)
        {
            return new Summary.Builder(new Summary(config));
        }
    }
}
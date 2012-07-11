/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class SequentialIdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ModelIdGenerator.Builder<SequentialIdGenerator, SequentialIdGenerator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SequentialIdGenerator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SequentialIdGenerator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SequentialIdGenerator.Config config) : base(new SequentialIdGenerator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SequentialIdGenerator component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The string to place in front of the sequential number for each generated id. The default is blank.
			/// </summary>
            public virtual SequentialIdGenerator.Builder Prefix(string prefix)
            {
                this.ToComponent().Prefix = prefix;
                return this as SequentialIdGenerator.Builder;
            }
             
 			/// <summary>
			/// The number at which to start generating sequential id's. The default is 1.
			/// </summary>
            public virtual SequentialIdGenerator.Builder Seed(int seed)
            {
                this.ToComponent().Seed = seed;
                return this as SequentialIdGenerator.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public SequentialIdGenerator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SequentialIdGenerator(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SequentialIdGenerator.Builder SequentialIdGenerator()
        {
            return this.SequentialIdGenerator(new SequentialIdGenerator());
        }

        /// <summary>
        /// 
        /// </summary>
        public SequentialIdGenerator.Builder SequentialIdGenerator(SequentialIdGenerator component)
        {
            return new SequentialIdGenerator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SequentialIdGenerator.Builder SequentialIdGenerator(SequentialIdGenerator.Config config)
        {
            return new SequentialIdGenerator.Builder(new SequentialIdGenerator(config));
        }
    }
}
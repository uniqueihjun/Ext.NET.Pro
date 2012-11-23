/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SequentialIdGenerator(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SequentialIdGenerator.Config Conversion to SequentialIdGenerator
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SequentialIdGenerator(SequentialIdGenerator.Config config)
        {
            return new SequentialIdGenerator(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ModelIdGenerator.Config 
        { 
			/*  Implicit SequentialIdGenerator.Config Conversion to SequentialIdGenerator.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SequentialIdGenerator.Builder(SequentialIdGenerator.Config config)
			{
				return new SequentialIdGenerator.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string prefix = "";

			/// <summary>
			/// The string to place in front of the sequential number for each generated id. The default is blank.
			/// </summary>
			[DefaultValue("")]
			public virtual string Prefix 
			{ 
				get
				{
					return this.prefix;
				}
				set
				{
					this.prefix = value;
				}
			}

			private int seed = 1;

			/// <summary>
			/// The number at which to start generating sequential id's. The default is 1.
			/// </summary>
			[DefaultValue(1)]
			public virtual int Seed 
			{ 
				get
				{
					return this.seed;
				}
				set
				{
					this.seed = value;
				}
			}

        }
    }
}
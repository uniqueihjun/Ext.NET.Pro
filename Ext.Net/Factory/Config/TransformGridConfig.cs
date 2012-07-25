/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class TransformGrid
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TransformGrid(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TransformGrid.Config Conversion to TransformGrid
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransformGrid(TransformGrid.Config config)
        {
            return new TransformGrid(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridPanel.Config 
        { 
			/*  Implicit TransformGrid.Config Conversion to TransformGrid.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TransformGrid.Builder(TransformGrid.Config config)
			{
				return new TransformGrid.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string table = "";

			/// <summary>
			/// The table element from which this grid will be created.
			/// </summary>
			[DefaultValue("")]
			public virtual string Table 
			{ 
				get
				{
					return this.table;
				}
				set
				{
					this.table = value;
				}
			}

        }
    }
}
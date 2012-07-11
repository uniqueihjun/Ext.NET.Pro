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
    public partial class BooleanColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public BooleanColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit BooleanColumn.Config Conversion to BooleanColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BooleanColumn(BooleanColumn.Config config)
        {
            return new BooleanColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Column.Config 
        { 
			/*  Implicit BooleanColumn.Config Conversion to BooleanColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator BooleanColumn.Builder(BooleanColumn.Config config)
			{
				return new BooleanColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}
/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class TemplateColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TemplateColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TemplateColumn.Config Conversion to TemplateColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplateColumn(TemplateColumn.Config config)
        {
            return new TemplateColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Column.Config 
        { 
			/*  Implicit TemplateColumn.Config Conversion to TemplateColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TemplateColumn.Builder(TemplateColumn.Config config)
			{
				return new TemplateColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}
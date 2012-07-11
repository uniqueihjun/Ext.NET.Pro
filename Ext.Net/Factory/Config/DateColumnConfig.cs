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
    public partial class DateColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DateColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DateColumn.Config Conversion to DateColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DateColumn(DateColumn.Config config)
        {
            return new DateColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Column.Config 
        { 
			/*  Implicit DateColumn.Config Conversion to DateColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DateColumn.Builder(DateColumn.Config config)
			{
				return new DateColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string format = "";

			/// <summary>
			/// A formatting string as used by Date.format to format a Date for this Column.
			/// </summary>
			[DefaultValue("")]
			public virtual string Format 
			{ 
				get
				{
					return this.format;
				}
				set
				{
					this.format = value;
				}
			}

        }
    }
}
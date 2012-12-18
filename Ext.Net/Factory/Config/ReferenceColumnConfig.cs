/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class ReferenceColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ReferenceColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ReferenceColumn.Config Conversion to ReferenceColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReferenceColumn(ReferenceColumn.Config config)
        {
            return new ReferenceColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ColumnBase.Config 
        { 
			/*  Implicit ReferenceColumn.Config Conversion to ReferenceColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ReferenceColumn.Builder(ReferenceColumn.Config config)
			{
				return new ReferenceColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string reference = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Reference 
			{ 
				get
				{
					return this.reference;
				}
				set
				{
					this.reference = value;
				}
			}

        }
    }
}
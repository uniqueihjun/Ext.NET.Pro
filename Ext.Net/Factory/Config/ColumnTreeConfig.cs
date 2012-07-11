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
    public partial class ColumnTree
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ColumnTree(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ColumnTree.Config Conversion to ColumnTree
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColumnTree(ColumnTree.Config config)
        {
            return new ColumnTree(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TreePanel.Config 
        { 
			/*  Implicit ColumnTree.Config Conversion to ColumnTree.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ColumnTree.Builder(ColumnTree.Config config)
			{
				return new ColumnTree.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ColumnTreeColumnCollection columns = null;

			/// <summary>
			/// An array of column configuration objects
			/// </summary>
			public ColumnTreeColumnCollection Columns
			{
				get
				{
					if (this.columns == null)
					{
						this.columns = new ColumnTreeColumnCollection();
					}
			
					return this.columns;
				}
			}
			
			private bool hideHeaders = false;

			/// <summary>
			/// True to hide the grid's header (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideHeaders 
			{ 
				get
				{
					return this.hideHeaders;
				}
				set
				{
					this.hideHeaders = value;
				}
			}

        }
    }
}
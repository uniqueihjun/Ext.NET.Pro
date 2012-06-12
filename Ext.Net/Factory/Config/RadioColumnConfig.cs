/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class RadioColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RadioColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RadioColumn.Config Conversion to RadioColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RadioColumn(RadioColumn.Config config)
        {
            return new RadioColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Radio.Config 
        { 
			/*  Implicit RadioColumn.Config Conversion to RadioColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RadioColumn.Builder(RadioColumn.Config config)
			{
				return new RadioColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ItemsCollection<Component> items = null;

			/// <summary>
			/// Items collection
			/// </summary>
			public ItemsCollection<Component> Items
			{
				get
				{
					if (this.items == null)
					{
						this.items = new ItemsCollection<Component>();
					}
			
					return this.items;
				}
			}
			
        }
    }
}
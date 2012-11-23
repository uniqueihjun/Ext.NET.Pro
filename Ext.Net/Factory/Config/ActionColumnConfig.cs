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
    public partial class ActionColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ActionColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ActionColumn.Config Conversion to ActionColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ActionColumn(ActionColumn.Config config)
        {
            return new ActionColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ColumnBase.Config 
        { 
			/*  Implicit ActionColumn.Config Conversion to ActionColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ActionColumn.Builder(ActionColumn.Config config)
			{
				return new ActionColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string altText = "";

			/// <summary>
			/// The alt text to use for the image element. Defaults to ''.
			/// </summary>
			[DefaultValue("")]
			public virtual string AltText 
			{ 
				get
				{
					return this.altText;
				}
				set
				{
					this.altText = value;
				}
			}

			private bool stopSelection = true;

			/// <summary>
			/// Defaults to true. Prevent grid row selection upon mousedown.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool StopSelection 
			{ 
				get
				{
					return this.stopSelection;
				}
				set
				{
					this.stopSelection = value;
				}
			}
        
			private ActionItemCollection items = null;

			/// <summary>
			/// 
			/// </summary>
			public ActionItemCollection Items
			{
				get
				{
					if (this.items == null)
					{
						this.items = new ActionItemCollection();
					}
			
					return this.items;
				}
			}
			
        }
    }
}
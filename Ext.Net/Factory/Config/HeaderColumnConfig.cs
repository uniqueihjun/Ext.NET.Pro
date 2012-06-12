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
    public partial class HeaderColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public HeaderColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit HeaderColumn.Config Conversion to HeaderColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HeaderColumn(HeaderColumn.Config config)
        {
            return new HeaderColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit HeaderColumn.Config Conversion to HeaderColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator HeaderColumn.Builder(HeaderColumn.Config config)
			{
				return new HeaderColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string target = "";

			/// <summary>
			/// The target element which will be placed to the header.
			/// </summary>
			[DefaultValue("")]
			public virtual string Target 
			{ 
				get
				{
					return this.target;
				}
				set
				{
					this.target = value;
				}
			}

			private bool autoWidthElement = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool AutoWidthElement 
			{ 
				get
				{
					return this.autoWidthElement;
				}
				set
				{
					this.autoWidthElement = value;
				}
			}

			private int autoWidthCorrection = 3;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(3)]
			public virtual int AutoWidthCorrection 
			{ 
				get
				{
					return this.autoWidthCorrection;
				}
				set
				{
					this.autoWidthCorrection = value;
				}
			}

			private string cls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Cls 
			{ 
				get
				{
					return this.cls;
				}
				set
				{
					this.cls = value;
				}
			}
        
			private ItemsCollection<Component> component = null;

			/// <summary>
			/// 
			/// </summary>
			public ItemsCollection<Component> Component
			{
				get
				{
					if (this.component == null)
					{
						this.component = new ItemsCollection<Component>();
					}
			
					return this.component;
				}
			}
			
        }
    }
}
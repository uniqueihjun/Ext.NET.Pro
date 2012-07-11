/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class ChildElement
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ChildElement(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ChildElement.Config Conversion to ChildElement
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildElement(ChildElement.Config config)
        {
            return new ChildElement(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit ChildElement.Config Conversion to ChildElement.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ChildElement.Builder(ChildElement.Config config)
			{
				return new ChildElement.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string name = "";

			/// <summary>
			/// The property name on the Component for the child element.
			/// </summary>
			[DefaultValue("")]
			public virtual string Name 
			{ 
				get
				{
					return this.name;
				}
				set
				{
					this.name = value;
				}
			}

			private string itemID = "";

			/// <summary>
			/// The id to combine with the Component's id that is the id of the child element.
			/// </summary>
			[DefaultValue("")]
			public virtual string ItemID 
			{ 
				get
				{
					return this.itemID;
				}
				set
				{
					this.itemID = value;
				}
			}

			private string iD = "";

			/// <summary>
			/// The id of the child element.
			/// </summary>
			[DefaultValue("")]
			public virtual string ID 
			{ 
				get
				{
					return this.iD;
				}
				set
				{
					this.iD = value;
				}
			}

        }
    }
}
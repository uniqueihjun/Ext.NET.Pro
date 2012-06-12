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
    public partial class Anchor
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Anchor(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Anchor.Config Conversion to Anchor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Anchor(Anchor.Config config)
        {
            return new Anchor(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : LayoutItem.Config 
        { 
			/*  Implicit Anchor.Config Conversion to Anchor.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Anchor.Builder(Anchor.Config config)
			{
				return new Anchor.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool isFormField = false;

			/// <summary>
			/// True if component should be rendered as a Form Field with a Field Label and Label separator (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool IsFormField 
			{ 
				get
				{
					return this.isFormField;
				}
				set
				{
					this.isFormField = value;
				}
			}

			private string horizontal = "";

			/// <summary>
			/// Horizontal Anchor value. Can be a Percentage (1-100%), an Offset (Any positive or negative integer value), a Sides value (Valid values are 'right' (or 'r') and 'bottom' (or 'b').).
			/// </summary>
			[DefaultValue("")]
			public virtual string Horizontal 
			{ 
				get
				{
					return this.horizontal;
				}
				set
				{
					this.horizontal = value;
				}
			}

			private string vertical = "";

			/// <summary>
			/// Vertical Anchor value. Can be a Percentage (1-100%), an Offset (Any positive or negative integer value), a Sides value (Valid values are 'right' (or 'r') and 'bottom' (or 'b').).
			/// </summary>
			[DefaultValue("")]
			public virtual string Vertical 
			{ 
				get
				{
					return this.vertical;
				}
				set
				{
					this.vertical = value;
				}
			}

        }
    }
}
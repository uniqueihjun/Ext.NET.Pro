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
    public partial class DrawText
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DrawText(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DrawText.Config Conversion to DrawText
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DrawText(DrawText.Config config)
        {
            return new DrawText(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DrawComponent.Config 
        { 
			/*  Implicit DrawText.Config Conversion to DrawText.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DrawText.Builder(DrawText.Config config)
			{
				return new DrawText.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool autoSize = true;

			/// <summary>
			/// Turn on autoSize support which will set the bounding div's size to the natural size of the contents. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public override bool AutoSize 
			{ 
				get
				{
					return this.autoSize;
				}
				set
				{
					this.autoSize = value;
				}
			}

			private int degrees = 0;

			/// <summary>
			/// The angle by which to initially rotate the text clockwise. Defaults to zero.
			/// </summary>
			[DefaultValue(0)]
			public virtual int Degrees 
			{ 
				get
				{
					return this.degrees;
				}
				set
				{
					this.degrees = value;
				}
			}

			private string styleSelector = "";

			/// <summary>
			/// A CSS selector string which matches a style rule in the document stylesheet from which the text's font properties are read.
			/// </summary>
			[DefaultValue("")]
			public virtual string StyleSelector 
			{ 
				get
				{
					return this.styleSelector;
				}
				set
				{
					this.styleSelector = value;
				}
			}

			private string text = "";

			/// <summary>
			/// The text to display (html tags are not accepted)
			/// </summary>
			[DefaultValue("")]
			public virtual string Text 
			{ 
				get
				{
					return this.text;
				}
				set
				{
					this.text = value;
				}
			}

			private SpriteAttributes textStyle = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual SpriteAttributes TextStyle 
			{ 
				get
				{
					return this.textStyle;
				}
				set
				{
					this.textStyle = value;
				}
			}

        }
    }
}
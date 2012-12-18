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
    public abstract partial class AbstractDrawComponent
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : ComponentBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool autoSize = false;

			/// <summary>
			/// Turn on autoSize support which will set the bounding div's size to the natural size of the contents. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AutoSize 
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

			private string[] enginePriority = null;

			/// <summary>
			/// Defines the priority order for which Surface implementation to use. The first one supported by the current environment will be used. Defaults to: [\"Svg\", \"Vml\"]
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] EnginePriority 
			{ 
				get
				{
					return this.enginePriority;
				}
				set
				{
					this.enginePriority = value;
				}
			}
        
			private Gradients gradients = null;

			/// <summary>
			/// Define a set of gradients that can be used as fill property in sprites.
			/// </summary>
			public Gradients Gradients
			{
				get
				{
					if (this.gradients == null)
					{
						this.gradients = new Gradients();
					}
			
					return this.gradients;
				}
			}
			
			private bool viewBox = true;

			/// <summary>
			/// Turn on view box support which will scale and position items in the draw component to fit to the component while maintaining aspect ratio. Note that this scaling can override other sizing settings on yor items. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ViewBox 
			{ 
				get
				{
					return this.viewBox;
				}
				set
				{
					this.viewBox = value;
				}
			}

			private DrawBackground background = null;

			/// <summary>
			/// The chart background. This can be a gradient object, image, or color. Defaults to false for no background.
			/// </summary>
			[DefaultValue(null)]
			public virtual DrawBackground Background 
			{ 
				get
				{
					return this.background;
				}
				set
				{
					this.background = value;
				}
			}
        
			private SpriteCollection items = null;

			/// <summary>
			/// 
			/// </summary>
			public SpriteCollection Items
			{
				get
				{
					if (this.items == null)
					{
						this.items = new SpriteCollection();
					}
			
					return this.items;
				}
			}
			
        }
    }
}
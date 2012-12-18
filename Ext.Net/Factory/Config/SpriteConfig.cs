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
    public partial class Sprite
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Sprite(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Sprite.Config Conversion to Sprite
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Sprite(Sprite.Config config)
        {
            return new Sprite(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : SpriteAttributes.Config 
        { 
			/*  Implicit Sprite.Config Conversion to Sprite.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Sprite.Builder(Sprite.Config config)
			{
				return new Sprite.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string spriteID = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string SpriteID 
			{ 
				get
				{
					return this.spriteID;
				}
				set
				{
					this.spriteID = value;
				}
			}

			private bool draggable = false;

			/// <summary>
			/// True to make the sprite draggable.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Draggable 
			{ 
				get
				{
					return this.draggable;
				}
				set
				{
					this.draggable = value;
				}
			}

			private DragSource draggableConfig = null;

			/// <summary>
			/// Drag config object.
			/// </summary>
			[DefaultValue(null)]
			public virtual DragSource DraggableConfig 
			{ 
				get
				{
					return this.draggableConfig;
				}
				set
				{
					this.draggableConfig = value;
				}
			}

			private string[] group = null;

			/// <summary>
			/// The group that this sprite belongs to, or an array of groups. Only relevant when added to a Ext.draw.Surface
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] Group 
			{ 
				get
				{
					return this.group;
				}
				set
				{
					this.group = value;
				}
			}
        
			private SpriteListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public SpriteListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new SpriteListeners();
					}
			
					return this.listeners;
				}
			}
			
        }
    }
}
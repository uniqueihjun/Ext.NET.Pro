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
    public abstract partial class ImageBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : BoxComponentBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private Unit height = Unit.Empty;

			/// <summary>
			/// The height of this component in pixels (defaults to auto).
			/// </summary>
			[DefaultValue(typeof(Unit), "")]
			public override Unit Height 
			{ 
				get
				{
					return this.height;
				}
				set
				{
					this.height = value;
				}
			}

			private Unit width = Unit.Empty;

			/// <summary>
			/// The width of this component in pixels (defaults to auto).
			/// </summary>
			[DefaultValue(typeof(Unit), "")]
			public override Unit Width 
			{ 
				get
				{
					return this.width;
				}
				set
				{
					this.width = value;
				}
			}

			private string imageUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string ImageUrl 
			{ 
				get
				{
					return this.imageUrl;
				}
				set
				{
					this.imageUrl = value;
				}
			}

			private string alternateText = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string AlternateText 
			{ 
				get
				{
					return this.alternateText;
				}
				set
				{
					this.alternateText = value;
				}
			}

			private ImageAlign align = ImageAlign.NotSet;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(ImageAlign.NotSet)]
			public virtual ImageAlign Align 
			{ 
				get
				{
					return this.align;
				}
				set
				{
					this.align = value;
				}
			}

			private bool lazyLoad = false;

			/// <summary>
			/// true to load image after rendering only
			/// </summary>
			[DefaultValue(false)]
			public virtual bool LazyLoad 
			{ 
				get
				{
					return this.lazyLoad;
				}
				set
				{
					this.lazyLoad = value;
				}
			}

			private bool monitorComplete = true;

			/// <summary>
			/// true to monitor complete state and fire Complete event
			/// </summary>
			[DefaultValue(true)]
			public virtual bool MonitorComplete 
			{ 
				get
				{
					return this.monitorComplete;
				}
				set
				{
					this.monitorComplete = value;
				}
			}

			private bool allowPan = false;

			/// <summary>
			/// true to allow scroll the image by mouse dragging
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AllowPan 
			{ 
				get
				{
					return this.allowPan;
				}
				set
				{
					this.allowPan = value;
				}
			}

			private bool resizable = false;

			/// <summary>
			/// true to allow resize the image
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Resizable 
			{ 
				get
				{
					return this.resizable;
				}
				set
				{
					this.resizable = value;
				}
			}

			private int monitorPoll = 200;

			/// <summary>
			/// The milliseconds to poll complete state, ignored if MonitorComplete is not true (defaults to 200)
			/// </summary>
			[DefaultValue(200)]
			public virtual int MonitorPoll 
			{ 
				get
				{
					return this.monitorPoll;
				}
				set
				{
					this.monitorPoll = value;
				}
			}
        
			private Resizable resizeConfig = null;

			/// <summary>
			/// Resize object config
			/// </summary>
			public Resizable ResizeConfig
			{
				get
				{
					if (this.resizeConfig == null)
					{
						this.resizeConfig = new Resizable();
					}
			
					return this.resizeConfig;
				}
			}
			
			private int xDelta = 0;

			/// <summary>
			/// X offset
			/// </summary>
			[DefaultValue(0)]
			public virtual int XDelta 
			{ 
				get
				{
					return this.xDelta;
				}
				set
				{
					this.xDelta = value;
				}
			}

			private int yDelta = 0;

			/// <summary>
			/// Y offset
			/// </summary>
			[DefaultValue(0)]
			public virtual int YDelta 
			{ 
				get
				{
					return this.yDelta;
				}
				set
				{
					this.yDelta = value;
				}
			}
        
			private LoadMask loadMask = null;

			/// <summary>
			/// 
			/// </summary>
			public LoadMask LoadMask
			{
				get
				{
					if (this.loadMask == null)
					{
						this.loadMask = new LoadMask();
					}
			
					return this.loadMask;
				}
			}
			
        }
    }
}
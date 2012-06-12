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
    public abstract partial class Tip
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : PanelBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool autoHeight = true;

			/// <summary>
			/// True to use height:'auto', false to use fixed height (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public override bool AutoHeight 
			{ 
				get
				{
					return this.autoHeight;
				}
				set
				{
					this.autoHeight = value;
				}
			}

			private bool closable = false;

			/// <summary>
			/// True to render a close tool button into the tooltip header (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public override bool Closable 
			{ 
				get
				{
					return this.closable;
				}
				set
				{
					this.closable = value;
				}
			}

			private bool constrainPosition = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ConstrainPosition 
			{ 
				get
				{
					return this.constrainPosition;
				}
				set
				{
					this.constrainPosition = value;
				}
			}

			private string defaultAlign = "";

			/// <summary>
			/// Experimental. The default Ext.Element.alignTo anchor position value for this tip relative to its element of origin (defaults to 'tl-bl?').
			/// </summary>
			[DefaultValue("")]
			public virtual string DefaultAlign 
			{ 
				get
				{
					return this.defaultAlign;
				}
				set
				{
					this.defaultAlign = value;
				}
			}

			private Unit maxWidth = Unit.Pixel(300);

			/// <summary>
			/// The maximum width of the tip in pixels (defaults to 300). The maximum supported value is 500.
			/// </summary>
			[DefaultValue(typeof(Unit), "300")]
			public override Unit MaxWidth 
			{ 
				get
				{
					return this.maxWidth;
				}
				set
				{
					this.maxWidth = value;
				}
			}

			private Unit minWidth = Unit.Pixel(40);

			/// <summary>
			/// The minimum width of the tip in pixels (defaults to 40).
			/// </summary>
			[DefaultValue(typeof(Unit), "40")]
			public override Unit MinWidth 
			{ 
				get
				{
					return this.minWidth;
				}
				set
				{
					this.minWidth = value;
				}
			}

        }
    }
}
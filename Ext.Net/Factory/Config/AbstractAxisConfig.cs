/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public abstract partial class AbstractAxis
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : BaseItem.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string axisID = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string AxisID 
			{ 
				get
				{
					return this.axisID;
				}
				set
				{
					this.axisID = value;
				}
			}

			private SpriteAttributes labelTitle = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual SpriteAttributes LabelTitle 
			{ 
				get
				{
					return this.labelTitle;
				}
				set
				{
					this.labelTitle = value;
				}
			}

			private AxisLabel label = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual AxisLabel Label 
			{ 
				get
				{
					return this.label;
				}
				set
				{
					this.label = value;
				}
			}

			private bool hidden = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Hidden 
			{ 
				get
				{
					return this.hidden;
				}
				set
				{
					this.hidden = value;
				}
			}

        }
    }
}
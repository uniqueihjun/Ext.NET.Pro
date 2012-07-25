/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class DDProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DDProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DDProxy.Config Conversion to DDProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DDProxy(DDProxy.Config config)
        {
            return new DDProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DD.Config 
        { 
			/*  Implicit DDProxy.Config Conversion to DDProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DDProxy.Builder(DDProxy.Config config)
			{
				return new DDProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool centerFrame = false;

			/// <summary>
			/// By default the frame is positioned exactly where the drag element is, so we use the cursor offset provided by Ext.dd.DD. Another option that works only if you do not have constraints on the obj is to have the drag frame centered around the cursor. Set centerFrame to true for this effect. Defaults to: false
			/// </summary>
			[DefaultValue(false)]
			public virtual bool CenterFrame 
			{ 
				get
				{
					return this.centerFrame;
				}
				set
				{
					this.centerFrame = value;
				}
			}

			private bool resizeFrame = true;

			/// <summary>
			/// By default we resize the drag frame to be the same size as the element we want to drag (this is to get the frame effect). We can turn it off if we want a different behavior.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ResizeFrame 
			{ 
				get
				{
					return this.resizeFrame;
				}
				set
				{
					this.resizeFrame = value;
				}
			}
        
			private JFunction afterDrag = null;

			/// <summary>
			/// Abstract method runs on drag end
			/// </summary>
			public JFunction AfterDrag
			{
				get
				{
					if (this.afterDrag == null)
					{
						this.afterDrag = new JFunction();
					}
			
					return this.afterDrag;
				}
			}
			
        }
    }
}
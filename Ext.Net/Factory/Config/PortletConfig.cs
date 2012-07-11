/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class Portlet
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Portlet(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Portlet.Config Conversion to Portlet
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Portlet(Portlet.Config config)
        {
            return new Portlet(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Panel.Config 
        { 
			/*  Implicit Portlet.Config Conversion to Portlet.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Portlet.Builder(Portlet.Config config)
			{
				return new Portlet.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool collapsible = true;

			/// <summary>
			/// True to make the panel collapsible and have the expand/collapse toggle button automatically rendered into the header tool button area, false to keep the panel statically sized with no button (defaults to false).
			/// </summary>
			[DefaultValue(true)]
			public override bool Collapsible 
			{ 
				get
				{
					return this.collapsible;
				}
				set
				{
					this.collapsible = value;
				}
			}

			private bool draggable = true;

			/// <summary>
			/// True to enable dragging of this Panel (defaults to false).
			/// </summary>
			[DefaultValue(true)]
			public override bool Draggable 
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

        }
    }
}
/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class CardLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CardLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CardLayout.Config Conversion to CardLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CardLayout(CardLayout.Config config)
        {
            return new CardLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ContainerLayout.Config 
        { 
			/*  Implicit CardLayout.Config Conversion to CardLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CardLayout.Builder(CardLayout.Config config)
			{
				return new CardLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool deferredRender = false;

			/// <summary>
			/// True to render each contained items at the time it becomes active, false to render all contained items as soon as the layout is rendered (defaults to false). If there is a significant amount of content or a lot of heavy controls being rendered into panels that are not displayed by default, setting this to true might improve performance.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool DeferredRender 
			{ 
				get
				{
					return this.deferredRender;
				}
				set
				{
					this.deferredRender = value;
				}
			}

			private bool layoutOnCardChange = false;

			/// <summary>
			/// True to force a layout of the active item when the active card is changed. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool LayoutOnCardChange 
			{ 
				get
				{
					return this.layoutOnCardChange;
				}
				set
				{
					this.layoutOnCardChange = value;
				}
			}

        }
    }
}
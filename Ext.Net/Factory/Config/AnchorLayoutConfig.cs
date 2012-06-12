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
    public partial class AnchorLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public AnchorLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit AnchorLayout.Config Conversion to AnchorLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnchorLayout(AnchorLayout.Config config)
        {
            return new AnchorLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ContainerLayout.Config 
        { 
			/*  Implicit AnchorLayout.Config Conversion to AnchorLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator AnchorLayout.Builder(AnchorLayout.Config config)
			{
				return new AnchorLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private Unit height = Unit.Empty;

			/// <summary>
			/// The height of this Anchor in pixels (defaults to auto).
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
			/// The width of this Anchor in pixels (defaults to auto).
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
        
			private AnchorCollection anchors = null;

			/// <summary>
			/// Anchors collection
			/// </summary>
			public AnchorCollection Anchors
			{
				get
				{
					if (this.anchors == null)
					{
						this.anchors = new AnchorCollection();
					}
			
					return this.anchors;
				}
			}
			
        }
    }
}
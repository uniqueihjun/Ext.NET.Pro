/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class Spotlight
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Spotlight(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Spotlight.Config Conversion to Spotlight
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Spotlight(Spotlight.Config config)
        {
            return new Spotlight(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Observable.Config 
        { 
			/*  Implicit Spotlight.Config Conversion to Spotlight.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Spotlight.Builder(Spotlight.Config config)
			{
				return new Spotlight.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool animate = true;

			/// <summary>
			/// True to animate the spot (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool Animate 
			{ 
				get
				{
					return this.animate;
				}
				set
				{
					this.animate = value;
				}
			}

			private double duration = 0.25;

			/// <summary>
			/// Animation duration if animate = true (defaults to .25)
			/// </summary>
			[DefaultValue(0.25)]
			public virtual double Duration 
			{ 
				get
				{
					return this.duration;
				}
				set
				{
					this.duration = value;
				}
			}

			private Easing easing = Easing.EaseNone;

			/// <summary>
			/// Animation easing if animate = true (defaults to 'easeNone')
			/// </summary>
			[DefaultValue(Easing.EaseNone)]
			public virtual Easing Easing 
			{ 
				get
				{
					return this.easing;
				}
				set
				{
					this.easing = value;
				}
			}

        }
    }
}
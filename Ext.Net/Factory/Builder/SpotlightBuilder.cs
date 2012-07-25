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
    public partial class Spotlight
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<Spotlight, Spotlight.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Spotlight()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Spotlight component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Spotlight.Config config) : base(new Spotlight(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Spotlight component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to animate the spot (defaults to true).
			/// </summary>
            public virtual Spotlight.Builder Animate(bool animate)
            {
                this.ToComponent().Animate = animate;
                return this as Spotlight.Builder;
            }
             
 			/// <summary>
			/// Animation duration if animate = true (defaults to .25)
			/// </summary>
            public virtual Spotlight.Builder Duration(double duration)
            {
                this.ToComponent().Duration = duration;
                return this as Spotlight.Builder;
            }
             
 			/// <summary>
			/// Animation easing if animate = true (defaults to 'easeNone')
			/// </summary>
            public virtual Spotlight.Builder Easing(Easing easing)
            {
                this.ToComponent().Easing = easing;
                return this as Spotlight.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual Spotlight.Builder Show(string id)
            {
                this.ToComponent().Show(id);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual Spotlight.Builder Show(BaseControl control)
            {
                this.ToComponent().Show(control);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual Spotlight.Builder Hide()
            {
                this.ToComponent().Hide();
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual Spotlight.Builder SyncSize()
            {
                this.ToComponent().SyncSize();
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public Spotlight.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Spotlight(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Spotlight.Builder Spotlight()
        {
            return this.Spotlight(new Spotlight());
        }

        /// <summary>
        /// 
        /// </summary>
        public Spotlight.Builder Spotlight(Spotlight component)
        {
            return new Spotlight.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Spotlight.Builder Spotlight(Spotlight.Config config)
        {
            return new Spotlight.Builder(new Spotlight(config));
        }
    }
}
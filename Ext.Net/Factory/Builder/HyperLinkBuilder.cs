/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class HyperLink
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : LabelBase.Builder<HyperLink, HyperLink.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HyperLink()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HyperLink component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HyperLink.Config config) : base(new HyperLink(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HyperLink component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of HyperLink.Builder</returns>
            public virtual HyperLink.Builder Listeners(Action<AbstractComponentListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as HyperLink.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of HyperLink.Builder</returns>
            public virtual HyperLink.Builder DirectEvents(Action<AbstractComponentDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as HyperLink.Builder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual HyperLink.Builder ImageUrl(string imageUrl)
            {
                this.ToComponent().ImageUrl = imageUrl;
                return this as HyperLink.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HyperLink.Builder NavigateUrl(string navigateUrl)
            {
                this.ToComponent().NavigateUrl = navigateUrl;
                return this as HyperLink.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HyperLink.Builder Target(string target)
            {
                this.ToComponent().Target = target;
                return this as HyperLink.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public HyperLink.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HyperLink(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public HyperLink.Builder HyperLink()
        {
            return this.HyperLink(new HyperLink());
        }

        /// <summary>
        /// 
        /// </summary>
        public HyperLink.Builder HyperLink(HyperLink component)
        {
            return new HyperLink.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HyperLink.Builder HyperLink(HyperLink.Config config)
        {
            return new HyperLink.Builder(new HyperLink(config));
        }
    }
}
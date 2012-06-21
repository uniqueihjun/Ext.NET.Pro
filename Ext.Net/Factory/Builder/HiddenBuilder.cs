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
    public partial class Hidden
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Field.Builder<Hidden, Hidden.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Hidden()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Hidden component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Hidden.Config config) : base(new Hidden(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Hidden component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The Text value to initialize this field with.
			/// </summary>
            public virtual Hidden.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as Hidden.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Hidden.Builder</returns>
            public virtual Hidden.Builder Listeners(Action<FieldListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Hidden.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Hidden.Builder</returns>
            public virtual Hidden.Builder DirectEvents(Action<FieldDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Hidden.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Hidden.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Hidden(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Hidden.Builder Hidden()
        {
            return this.Hidden(new Hidden());
        }

        /// <summary>
        /// 
        /// </summary>
        public Hidden.Builder Hidden(Hidden component)
        {
            return new Hidden.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Hidden.Builder Hidden(Hidden.Config config)
        {
            return new Hidden.Builder(new Hidden(config));
        }
    }
}
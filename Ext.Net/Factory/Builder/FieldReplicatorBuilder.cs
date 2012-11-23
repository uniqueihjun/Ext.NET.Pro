/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class FieldReplicator
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TFieldReplicator, TBuilder> : Plugin.Builder<TFieldReplicator, TBuilder>
            where TFieldReplicator : FieldReplicator
            where TBuilder : Builder<TFieldReplicator, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TFieldReplicator component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : FieldReplicator.Builder<FieldReplicator, FieldReplicator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FieldReplicator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldReplicator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldReplicator.Config config) : base(new FieldReplicator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FieldReplicator component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldReplicator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FieldReplicator(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FieldReplicator.Builder FieldReplicator()
        {
#if MVC
			return this.FieldReplicator(new FieldReplicator { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.FieldReplicator(new FieldReplicator());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldReplicator.Builder FieldReplicator(FieldReplicator component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new FieldReplicator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldReplicator.Builder FieldReplicator(FieldReplicator.Config config)
        {
#if MVC
			return new FieldReplicator.Builder(new FieldReplicator(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new FieldReplicator.Builder(new FieldReplicator(config));
#endif			
        }
    }
}
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
    public partial class GenericPlugin
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TGenericPlugin, TBuilder> : Plugin.Builder<TGenericPlugin, TBuilder>
            where TGenericPlugin : GenericPlugin
            where TBuilder : Builder<TGenericPlugin, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TGenericPlugin component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The JavaScript class name. Used to create a 'new' instance of the object.
			/// </summary>
            public virtual TBuilder InstanceName(string instanceName)
            {
                this.ToComponent().InstanceName = instanceName;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The file path to the required JavaScript file.
			/// </summary>
            public virtual TBuilder Path(string path)
            {
                this.ToComponent().Path = path;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : GenericPlugin.Builder<GenericPlugin, GenericPlugin.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GenericPlugin()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GenericPlugin component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GenericPlugin.Config config) : base(new GenericPlugin(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GenericPlugin component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public GenericPlugin.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GenericPlugin(this);
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
        public GenericPlugin.Builder GenericPlugin()
        {
#if MVC
			return this.GenericPlugin(new GenericPlugin { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.GenericPlugin(new GenericPlugin());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public GenericPlugin.Builder GenericPlugin(GenericPlugin component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new GenericPlugin.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GenericPlugin.Builder GenericPlugin(GenericPlugin.Config config)
        {
#if MVC
			return new GenericPlugin.Builder(new GenericPlugin(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new GenericPlugin.Builder(new GenericPlugin(config));
#endif			
        }
    }
}
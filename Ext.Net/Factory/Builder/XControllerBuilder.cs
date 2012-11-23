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
    public partial class XController
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TXController, TBuilder> : XControllerBase.Builder<TXController, TBuilder>
            where TXController : XController
            where TBuilder : Builder<TXController, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TXController component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : XController.Builder<XController, XController.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new XController()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XController component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XController.Config config) : base(new XController(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(XController component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public XController.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.XController(this);
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
        public XController.Builder XController()
        {
#if MVC
			return this.XController(new XController { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.XController(new XController());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public XController.Builder XController(XController component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new XController.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public XController.Builder XController(XController.Config config)
        {
#if MVC
			return new XController.Builder(new XController(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new XController.Builder(new XController(config));
#endif			
        }
    }
}
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
    public partial class XScript
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TXScript, TBuilder> : BaseControl.Builder<TXScript, TBuilder>
            where TXScript : XScript
            where TBuilder : Builder<TXScript, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TXScript component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Script text
			/// </summary>
            public virtual TBuilder ScriptBlock(string scriptBlock)
            {
                this.ToComponent().ScriptBlock = scriptBlock;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : XScript.Builder<XScript, XScript.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new XScript()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XScript component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XScript.Config config) : base(new XScript(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(XScript component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public XScript.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.XScript(this);
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
        public XScript.Builder XScript()
        {
#if MVC
			return this.XScript(new XScript { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.XScript(new XScript());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public XScript.Builder XScript(XScript component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new XScript.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public XScript.Builder XScript(XScript.Config config)
        {
#if MVC
			return new XScript.Builder(new XScript(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new XScript.Builder(new XScript(config));
#endif			
        }
    }
}
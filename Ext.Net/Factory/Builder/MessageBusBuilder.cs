/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class MessageBus
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TMessageBus, TBuilder> : LazyObservable.Builder<TMessageBus, TBuilder>
            where TMessageBus : MessageBus
            where TBuilder : Builder<TMessageBus, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TMessageBus component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : MessageBus.Builder<MessageBus, MessageBus.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MessageBus()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MessageBus component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MessageBus.Config config) : base(new MessageBus(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MessageBus component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageBus.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MessageBus(this);
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
        public MessageBus.Builder MessageBus()
        {
#if MVC
			return this.MessageBus(new MessageBus { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.MessageBus(new MessageBus());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageBus.Builder MessageBus(MessageBus component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new MessageBus.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageBus.Builder MessageBus(MessageBus.Config config)
        {
#if MVC
			return new MessageBus.Builder(new MessageBus(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new MessageBus.Builder(new MessageBus(config));
#endif			
        }
    }
}
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
    public partial class MessageBus
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : LazyObservable.Builder<MessageBus, MessageBus.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageBus.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MessageBus(this);
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
            return this.MessageBus(new MessageBus());
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageBus.Builder MessageBus(MessageBus component)
        {
            return new MessageBus.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageBus.Builder MessageBus(MessageBus.Config config)
        {
            return new MessageBus.Builder(new MessageBus(config));
        }
    }
}
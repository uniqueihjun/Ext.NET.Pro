/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class EventStore
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public EventStore(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit EventStore.Config Conversion to EventStore
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventStore(EventStore.Config config)
        {
            return new EventStore(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Store.Config 
        { 
			/*  Implicit EventStore.Config Conversion to EventStore.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator EventStore.Builder(EventStore.Config config)
			{
				return new EventStore.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private EventModelCollection events = null;

			/// <summary>
			/// 
			/// </summary>
			public EventModelCollection Events
			{
				get
				{
					if (this.events == null)
					{
						this.events = new EventModelCollection();
					}
			
					return this.events;
				}
			}
			
			private bool noMappings = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool NoMappings 
			{ 
				get
				{
					return this.noMappings;
				}
				set
				{
					this.noMappings = value;
				}
			}
        
			private ModelFieldCollection mappings = null;

			/// <summary>
			/// 
			/// </summary>
			public ModelFieldCollection Mappings
			{
				get
				{
					if (this.mappings == null)
					{
						this.mappings = new ModelFieldCollection();
					}
			
					return this.mappings;
				}
			}
			
        }
    }
}
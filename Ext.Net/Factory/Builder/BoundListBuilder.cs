/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class BoundList
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BoundListBase.Builder<BoundList, BoundList.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new BoundList()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BoundList component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BoundList.Config config) : base(new BoundList(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(BoundList component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of BoundList.Builder</returns>
            public virtual BoundList.Builder Listeners(Action<DataViewListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as BoundList.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of BoundList.Builder</returns>
            public virtual BoundList.Builder DirectEvents(Action<DataViewDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as BoundList.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public BoundList.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.BoundList(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public BoundList.Builder BoundList()
        {
            return this.BoundList(new BoundList());
        }

        /// <summary>
        /// 
        /// </summary>
        public BoundList.Builder BoundList(BoundList component)
        {
            return new BoundList.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public BoundList.Builder BoundList(BoundList.Config config)
        {
            return new BoundList.Builder(new BoundList(config));
        }
    }
}
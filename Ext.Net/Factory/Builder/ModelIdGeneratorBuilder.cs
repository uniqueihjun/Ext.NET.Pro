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
    public abstract partial class ModelIdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TModelIdGenerator, TBuilder> : BaseItem.Builder<TModelIdGenerator, TBuilder>
            where TModelIdGenerator : ModelIdGenerator
            where TBuilder : Builder<TModelIdGenerator, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TModelIdGenerator component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The id by which to register a new instance. This instance can be found using the get static method.
			/// </summary>
            public virtual TBuilder ID(string iD)
            {
                this.ToComponent().ID = iD;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GetRecId(Action<JFunction> action)
            {
                action(this.ToComponent().GetRecId);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}
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
    public partial class MvcItem
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public MvcItem(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit MvcItem.Config Conversion to MvcItem
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MvcItem(MvcItem.Config config)
        {
            return new MvcItem(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractComponent.Config 
        { 
			/*  Implicit MvcItem.Config Conversion to MvcItem.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator MvcItem.Builder(MvcItem.Config config)
			{
				return new MvcItem.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private Func<System.Web.IHtmlString> expression = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual Func<System.Web.IHtmlString> Expression 
			{ 
				get
				{
					return this.expression;
				}
				set
				{
					this.expression = value;
				}
			}

        }
    }
}
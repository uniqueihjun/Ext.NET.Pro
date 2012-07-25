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
    public partial class XTemplate
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public XTemplate(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit XTemplate.Config Conversion to XTemplate
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator XTemplate(XTemplate.Config config)
        {
            return new XTemplate(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : LazyObservable.Config 
        { 
			/*  Implicit XTemplate.Config Conversion to XTemplate.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator XTemplate.Builder(XTemplate.Config config)
			{
				return new XTemplate.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private List<JFunction> functions = null;

			/// <summary>
			/// Inline functions
			/// </summary>
			public List<JFunction> Functions
			{
				get
				{
					if (this.functions == null)
					{
						this.functions = new List<JFunction>();
					}
			
					return this.functions;
				}
			}
			
			private string html = "";

			/// <summary>
			/// Template text
			/// </summary>
			[DefaultValue("")]
			public virtual string Html 
			{ 
				get
				{
					return this.html;
				}
				set
				{
					this.html = value;
				}
			}

        }
    }
}
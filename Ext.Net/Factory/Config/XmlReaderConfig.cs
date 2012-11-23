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
    public partial class XmlReader
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public XmlReader(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit XmlReader.Config Conversion to XmlReader
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator XmlReader(XmlReader.Config config)
        {
            return new XmlReader(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractReader.Config 
        { 
			/*  Implicit XmlReader.Config Conversion to XmlReader.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator XmlReader.Builder(XmlReader.Config config)
			{
				return new XmlReader.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string record = "";

			/// <summary>
			/// The DomQuery path to the repeated element which contains record information.
			/// </summary>
			[DefaultValue("")]
			public virtual string Record 
			{ 
				get
				{
					return this.record;
				}
				set
				{
					this.record = value;
				}
			}

        }
    }
}
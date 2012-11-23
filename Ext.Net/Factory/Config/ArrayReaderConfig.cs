/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class ArrayReader
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ArrayReader(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ArrayReader.Config Conversion to ArrayReader
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArrayReader(ArrayReader.Config config)
        {
            return new ArrayReader(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : JsonReader.Config 
        { 
			/*  Implicit ArrayReader.Config Conversion to ArrayReader.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ArrayReader.Builder(ArrayReader.Config config)
			{
				return new ArrayReader.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string iDProperty = "";

			/// <summary>
			/// [id] Name of the property within a row object that contains a record identifier value. Defaults to id
			/// </summary>
			[DefaultValue("")]
			public override string IDProperty 
			{ 
				get
				{
					return this.iDProperty;
				}
				set
				{
					this.iDProperty = value;
				}
			}

			private int iDIndex = -1;

			/// <summary>
			/// The subscript within row Array that provides an ID for the Record.
			/// </summary>
			[DefaultValue(-1)]
			public virtual int IDIndex 
			{ 
				get
				{
					return this.iDIndex;
				}
				set
				{
					this.iDIndex = value;
				}
			}

        }
    }
}
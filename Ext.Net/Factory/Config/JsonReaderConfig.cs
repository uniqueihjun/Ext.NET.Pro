/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class JsonReader
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public JsonReader(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit JsonReader.Config Conversion to JsonReader
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonReader(JsonReader.Config config)
        {
            return new JsonReader(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DataReader.Config 
        { 
			/*  Implicit JsonReader.Config Conversion to JsonReader.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator JsonReader.Builder(JsonReader.Config config)
			{
				return new JsonReader.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string iDProperty = "";

			/// <summary>
			/// [id] Name of the property within a row object that contains a record identifier value. Defaults to id
			/// </summary>
			[DefaultValue("")]
			public virtual string IDProperty 
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

			private string root = "";

			/// <summary>
			/// Name of the property which contains the Array of row objects.
			/// </summary>
			[DefaultValue("")]
			public virtual string Root 
			{ 
				get
				{
					return this.root;
				}
				set
				{
					this.root = value;
				}
			}

			private string successProperty = "";

			/// <summary>
			/// Name of the property from which to retrieve the success attribute used by forms.
			/// </summary>
			[DefaultValue("")]
			public virtual string SuccessProperty 
			{ 
				get
				{
					return this.successProperty;
				}
				set
				{
					this.successProperty = value;
				}
			}

			private string totalProperty = "";

			/// <summary>
			/// The DomQuery path from which to retrieve the total number of records in the dataset. This is only needed if the whole dataset is not passed in one go, but is being paged from the remote server.
			/// </summary>
			[DefaultValue("")]
			public virtual string TotalProperty 
			{ 
				get
				{
					return this.totalProperty;
				}
				set
				{
					this.totalProperty = value;
				}
			}

        }
    }
}
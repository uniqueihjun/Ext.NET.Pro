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
    public abstract partial class AbstractReader
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : BaseItem.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string iDProperty = "";

			/// <summary>
			/// Name of the property within a row object that contains a record identifier value. Defaults to The id of the model. If an idProperty is explicitly specified it will override that of the one specified on the model
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

			private bool implicitIncludes = true;

			/// <summary>
			/// True to automatically parse models nested within other models in a response object. See the Ext.data.reader.Reader intro docs for full explanation. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ImplicitIncludes 
			{ 
				get
				{
					return this.implicitIncludes;
				}
				set
				{
					this.implicitIncludes = value;
				}
			}

			private bool readRecordsOnFailure = true;

			/// <summary>
			/// True to read extract the records from a data packet even if the success property returns false. Defaults to: true
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ReadRecordsOnFailure 
			{ 
				get
				{
					return this.readRecordsOnFailure;
				}
				set
				{
					this.readRecordsOnFailure = value;
				}
			}

			private string root = "";

			/// <summary>
			/// The name of the property which contains the Array of row objects. For JSON reader it's dot-separated list of property names. For XML reader it's a CSS selector. For array reader it's not applicable.
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
			/// Name of the property from which to retrieve the success attribute. Defaults to success. See Ext.data.proxy.Proxy.exception for additional information.
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
			/// Name of the property from which to retrieve the total number of records in the dataset. This is only needed if the whole dataset is not passed in one go, but is being paged from the remote server. Defaults to total.
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

			private string messageProperty = "";

			/// <summary>
			/// The name of the property which contains a response message. This property is optional.
			/// </summary>
			[DefaultValue("")]
			public virtual string MessageProperty 
			{ 
				get
				{
					return this.messageProperty;
				}
				set
				{
					this.messageProperty = value;
				}
			}

			private string modelName = null;

			/// <summary>
			/// The Ext.data.Model associated with this reader
			/// </summary>
			[DefaultValue(null)]
			public virtual string ModelName 
			{ 
				get
				{
					return this.modelName;
				}
				set
				{
					this.modelName = value;
				}
			}

        }
    }
}
/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
        public abstract partial class Builder<TAbstractReader, TBuilder> : BaseItem.Builder<TAbstractReader, TBuilder>
            where TAbstractReader : AbstractReader
            where TBuilder : Builder<TAbstractReader, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAbstractReader component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Name of the property within a row object that contains a record identifier value. Defaults to The id of the model. If an idProperty is explicitly specified it will override that of the one specified on the model
			/// </summary>
            public virtual TBuilder IDProperty(string iDProperty)
            {
                this.ToComponent().IDProperty = iDProperty;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to automatically parse models nested within other models in a response object. See the Ext.data.reader.Reader intro docs for full explanation. Defaults to true.
			/// </summary>
            public virtual TBuilder ImplicitIncludes(bool implicitIncludes)
            {
                this.ToComponent().ImplicitIncludes = implicitIncludes;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to read extract the records from a data packet even if the success property returns false. Defaults to: true
			/// </summary>
            public virtual TBuilder ReadRecordsOnFailure(bool readRecordsOnFailure)
            {
                this.ToComponent().ReadRecordsOnFailure = readRecordsOnFailure;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The name of the property which contains the Array of row objects. For JSON reader it's dot-separated list of property names. For XML reader it's a CSS selector. For array reader it's not applicable.
			/// </summary>
            public virtual TBuilder Root(string root)
            {
                this.ToComponent().Root = root;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Name of the property from which to retrieve the success attribute. Defaults to success. See Ext.data.proxy.Proxy.exception for additional information.
			/// </summary>
            public virtual TBuilder SuccessProperty(string successProperty)
            {
                this.ToComponent().SuccessProperty = successProperty;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Name of the property from which to retrieve the total number of records in the dataset. This is only needed if the whole dataset is not passed in one go, but is being paged from the remote server. Defaults to total.
			/// </summary>
            public virtual TBuilder TotalProperty(string totalProperty)
            {
                this.ToComponent().TotalProperty = totalProperty;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The name of the property which contains a response message. This property is optional.
			/// </summary>
            public virtual TBuilder MessageProperty(string messageProperty)
            {
                this.ToComponent().MessageProperty = messageProperty;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The Ext.data.Model associated with this reader
			/// </summary>
            public virtual TBuilder ModelName(string modelName)
            {
                this.ToComponent().ModelName = modelName;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}
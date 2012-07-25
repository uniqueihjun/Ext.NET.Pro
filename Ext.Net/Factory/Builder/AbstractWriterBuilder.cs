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
    public abstract partial class AbstractWriter
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TAbstractWriter, TBuilder> : BaseItem.Builder<TAbstractWriter, TBuilder>
            where TAbstractWriter : AbstractWriter
            where TBuilder : Builder<TAbstractWriter, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAbstractWriter component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// This property is used to read the key for each value that will be sent to the server.
			/// </summary>
            public virtual TBuilder NameProperty(string nameProperty)
            {
                this.ToComponent().NameProperty = nameProperty;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to write all fields from the record to the server. If set to false it will only send the fields that were modified. Defaults to true.
			/// </summary>
            public virtual TBuilder WriteAllFields(bool writeAllFields)
            {
                this.ToComponent().WriteAllFields = writeAllFields;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Formats the data for each record before sending it to the server. This method should be overridden to format the data in a way that differs from the default.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GetRecordData(Action<JFunction> action)
            {
                action(this.ToComponent().GetRecordData);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder FilterRecord(Action<JFunction> action)
            {
                action(this.ToComponent().FilterRecord);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder FilterField(Action<JFunction> action)
            {
                action(this.ToComponent().FilterField);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Prepare(Action<JFunction> action)
            {
                action(this.ToComponent().Prepare);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ExcludeId(bool excludeId)
            {
                this.ToComponent().ExcludeId = excludeId;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SkipIdForPhantomRecords(bool skipIdForPhantomRecords)
            {
                this.ToComponent().SkipIdForPhantomRecords = skipIdForPhantomRecords;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SkipPhantomId(bool skipPhantomId)
            {
                this.ToComponent().SkipPhantomId = skipPhantomId;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}
/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class RecordField
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<RecordField, RecordField.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RecordField()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RecordField component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RecordField.Config config) : base(new RecordField(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RecordField component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Used for validating a record, defaults to true. An empty value here will cause Ext.data.Record.isValid to evaluate to false.
			/// </summary>
            public virtual RecordField.Builder AllowBlank(bool allowBlank)
            {
                this.ToComponent().AllowBlank = allowBlank;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// The name by which the field is referenced within the Record. This is referenced by, for example the DataIndex property in column definition objects passed to ColumnModel
			/// </summary>
            public virtual RecordField.Builder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// (Optional) A path specification for use by the Reader implementation that is creating the Record to access the data value from the data object. If an JsonReader is being used, then this is a string containing the javascript expression to reference the data relative to the Record item's root. If an XmlReader is being used, this is an Ext.DomQuery path to the data item relative to the Record element. If the mapping expression is the same as the field name, this may be omitted.
			/// </summary>
            public virtual RecordField.Builder Mapping(string mapping)
            {
                this.ToComponent().Mapping = mapping;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RecordField.Builder ServerMapping(string serverMapping)
            {
                this.ToComponent().ServerMapping = serverMapping;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// The data type for conversion to displayable value
			/// </summary>
            public virtual RecordField.Builder Type(RecordFieldType type)
            {
                this.ToComponent().Type = type;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// Sort method
			/// </summary>
            public virtual RecordField.Builder SortType(SortTypeMethod sortType)
            {
                this.ToComponent().SortType = sortType;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// (Optional) Initial direction to sort
			/// </summary>
            public virtual RecordField.Builder SortDir(SortDirection sortDir)
            {
                this.ToComponent().SortDir = sortDir;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// Empty value representation during submit (default value as Undedefined)
			/// </summary>
            public virtual RecordField.Builder SubmitEmptyValue(EmptyValue submitEmptyValue)
            {
                this.ToComponent().SubmitEmptyValue = submitEmptyValue;
                return this as RecordField.Builder;
            }
             
 			// /// <summary>
			// /// A function which converts a Field's value to a comparable value in order to ensure correct sort ordering.
			// /// </summary>
            // public virtual TBuilder CustomSortType(JFunction customSortType)
            // {
            //    this.ToComponent().CustomSortType = customSortType;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// (Optional) A function which converts the value provided by the Reader into an object that will be stored in the Record.
			// /// </summary>
            // public virtual TBuilder Convert(JFunction convert)
            // {
            //    this.ToComponent().Convert = convert;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// (Optional) A format String for the Date.parseDate function
			/// </summary>
            public virtual RecordField.Builder DateFormat(string dateFormat)
            {
                this.ToComponent().DateFormat = dateFormat;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// (Optional) The default value passed to the Reader when the field does not exist in the data object
			/// </summary>
            public virtual RecordField.Builder DefaultValue(string defaultValue)
            {
                this.ToComponent().DefaultValue = defaultValue;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// True to render this property as complex object
			/// </summary>
            public virtual RecordField.Builder IsComplex(bool isComplex)
            {
                this.ToComponent().IsComplex = isComplex;
                return this as RecordField.Builder;
            }
             
 			/// <summary>
			/// (Optional) Use when converting received data into a Number type (either int or float). If the value cannot be parsed, null will be used if useNull is true, otherwise the value will be 0. Defaults to false
			/// </summary>
            public virtual RecordField.Builder UseNull(bool useNull)
            {
                this.ToComponent().UseNull = useNull;
                return this as RecordField.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RecordField.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RecordField(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RecordField.Builder RecordField()
        {
            return this.RecordField(new RecordField());
        }

        /// <summary>
        /// 
        /// </summary>
        public RecordField.Builder RecordField(RecordField component)
        {
            return new RecordField.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RecordField.Builder RecordField(RecordField.Config config)
        {
            return new RecordField.Builder(new RecordField(config));
        }
    }
}
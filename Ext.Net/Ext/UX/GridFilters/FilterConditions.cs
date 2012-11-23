/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;

using Ext.Net.Utilities;
using System.ComponentModel;
using Newtonsoft.Json.Linq;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class FilterConditions
    {
        private string filtersStr;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public FilterConditions(string filtersStr)
        {
            this.filtersStr = filtersStr;
            this.ParseConditions();
        }

        private void ParseConditions()
        {
            JArray filters = JArray.Parse(this.filtersStr);           
           
            this.conditions = new FilterConditionCollection();
            
            foreach (JObject filter in filters)
            {
                JObject jObject = filter;
                FilterCondition condition = new FilterCondition();
                condition.Field = jObject.Value<string>("field");

                JToken data = jObject["data"];
                if (data != null)
                {
                    jObject = (JObject)data;
                }

                string value = jObject.Value<string>("type");
                if (value.IsNotEmpty())
                {
                    condition.Type = (FilterType)Enum.Parse(typeof(FilterType), value, true);
                }

                value = jObject.Value<string>("comparison");
                if (value.IsNotEmpty())
                {
                    condition.Comparison = (Comparison)Enum.Parse(typeof(Comparison), value, true);
                }
                
                condition.Property = jObject.Property("value");

                this.conditions.Add(condition);
            }
        }

        private FilterConditionCollection conditions;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ReadOnlyCollection<FilterCondition> Conditions
        {
            get
            {
                if (conditions == null)
                {
                    conditions = new FilterConditionCollection();
                }

                return conditions.AsReadOnly();
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class FilterConditionCollection : List<FilterCondition> { }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class FilterCondition
    {
        private Comparison comparison = Comparison.Eq;
        private JProperty property;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public JProperty Property
        {
            get
            {
                return this.property;
            }
            internal set
            {
                this.property = value;
                this.ValueType = this.property.Value.Type;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Field
        {
            get;
            internal set;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public FilterType Type
        {
            get;
            internal set;
        }

        /// <summary>
        /// 
        /// </summary>
        public JTokenType ValueType
        {
            get;
            private set;
        }

		/// <summary>
		/// 
		/// </summary>
        public Comparison Comparison
        {
            get 
            { 
                return this.comparison; 
            }
            internal set 
            { 
                this.comparison = value; 
            }
        }

        public T Value<T>()
        {
            return this.Property.Value.Value<T>();
        }

		public List<string> List
        {
            get
            {
                if (this.Type != FilterType.List)
                {
                    throw new Exception("Filter condition value is not a list");
                }

                return new List<string>(((JArray)this.Property.Value).Values<string>());
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public enum Comparison
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,

        /// <summary>
        /// 
        /// </summary>
        Gt,

        /// <summary>
        /// 
        /// </summary>
        Lt
    }
    
}

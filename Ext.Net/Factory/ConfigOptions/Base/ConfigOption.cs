/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public class ConfigOptionsCollection : Dictionary<string, ConfigOption>
    {
        private SortedDictionary<int, ConfigOption> priorityProperties = new SortedDictionary<int, ConfigOption>();

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SortedDictionary<int, ConfigOption> PriorityProperties
        {
            get
            {
                return this.priorityProperties;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        [Description("")]
        new public void Add(string key, ConfigOption value)
        {
            if(value.Serialization.Priority != 0)
            {
                if (this.priorityProperties.ContainsKey(value.Serialization.Priority))
                {
                    this.priorityProperties.Remove(value.Serialization.Priority);
                }

                this.priorityProperties.Add(value.Serialization.Priority, value);
            }
            
            if (this.ContainsKey(key))
            {
                this.Remove(key);
            }

            if (value.Serialization.Priority == 0)
            {
                base.Add(key, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual void Add(string propertyName, object defaultValue, object value)
        {
            this.Add(propertyName, new ConfigOption(propertyName, null, defaultValue, value));
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public class ConfigOption
    {
        private readonly string propertyName;
        private SerializationOptions serialization;
        private readonly object defaultValue;
        private readonly object value;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfigOption(string propertyName, SerializationOptions serialization, object defaultValue, object value)
        {
            
            this.propertyName = propertyName;
            this.serialization = serialization;
            this.defaultValue = defaultValue;
            this.value = value;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string PropertyName
        {
            get 
            { 
                return propertyName; 
            }
        }

        private static readonly SerializationOptions defaultSerialization = new SerializationOptions();

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions Serialization
        {
            get 
            {
                return serialization ?? defaultSerialization; 
            }
            internal set
            {
                serialization = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public object DefaultValue
        {
            get 
            { 
                return defaultValue; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Name
        {
            get
            {
                if (this.Serialization != null)
                {
                    if (this.Serialization.Name.IsNotEmpty())
                    {
                        return this.Serialization.Name;
                    }
                }

                return this.PropertyName;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public object Value
        {
            get
            {
                return this.value;
            }
        }
    }
}
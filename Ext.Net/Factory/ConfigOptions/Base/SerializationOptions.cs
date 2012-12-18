/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class SerializationOptions
    {
        private readonly JsonMode mode = JsonMode.Value;
        private readonly string name = "";
        private readonly Type jsonConverter;
        private readonly int priority;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(string name)
        {
            this.name = name;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(string name, int priority)
        {
            this.name = name;
            this.priority = priority;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(JsonMode mode)
        {
            this.mode = mode;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(JsonMode mode, int priority)
        {
            this.mode = mode;
            this.priority = priority;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(string name, JsonMode mode)
        {
            this.name = name;
            this.mode = mode;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(string name, JsonMode mode, int priority)
        {
            this.name = name;
            this.mode = mode;
            this.priority = priority;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(Type jsonConverter)
        {
            this.name = "";

            if (!jsonConverter.IsSubclassOf(typeof(ExtJsonConverter)))
            {
                throw new ArgumentException("Parameter must be subclass of ExtJsonConverter", "jsonConverter");
            }

            this.jsonConverter = jsonConverter;
            this.mode = JsonMode.Custom;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(Type jsonConverter, int priority) : this(jsonConverter)
        {
            this.priority = priority;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(string name, Type jsonConverter)
        {
            this.name = name;

            if (!jsonConverter.IsSubclassOf(typeof(ExtJsonConverter)))
            {
                throw new ArgumentException("Parameter must be subclass of ExtJsonConverter", "jsonConverter");
            }

            this.jsonConverter = jsonConverter;
            this.mode = JsonMode.Custom;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SerializationOptions(string name, Type jsonConverter, int priority) : this(jsonConverter)
        {
            this.priority = priority;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Type JsonConverter
        {
            get { return jsonConverter; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JsonMode Mode
        {
            get { return this.mode; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Name
        {
            get { return this.name; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int Priority
        {
            get
            {
                return priority;
            }
        }
    }
}
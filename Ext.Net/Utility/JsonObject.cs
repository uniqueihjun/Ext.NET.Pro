/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [ToolboxItem(false)]
    [Description("")]
    public partial class JsonObject : Dictionary<string, object> 
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string ToJsonString()
        {
            return JSON.Serialize(this);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string ToJsonString(List<JsonConverter> converters)
        {
            return this.ToJsonString(converters, true);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string ToJsonString(List<JsonConverter> converters, bool quoteName)
        {
            return JSON.Serialize(this, converters, quoteName, null);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string ToJsonString(List<JsonConverter> converters, bool quoteName, IContractResolver resolver)
        {
            return JSON.Serialize(this, converters, quoteName, resolver);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            return JSON.Serialize(this);
        }
    }
}
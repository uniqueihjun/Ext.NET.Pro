/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    /// This is the Record specification for calendar items used by the
    /// CalendarPanel's calendar store. If your model fields 
    /// are named differently you should update the mapping configs accordingly.
    /// The only required fields when creating a new calendar record instance are CalendarId and
    /// Title.  All other fields are either optional or will be defaulted if blank.
    /// </summary>
    public partial class CalendarModel
    {        
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        [Newtonsoft.Json.JsonProperty(Required = Required.Always, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual int? CalendarId 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        [Newtonsoft.Json.JsonProperty(Required = Required.Always, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string Title 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        [Newtonsoft.Json.JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual string Description
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        [Newtonsoft.Json.JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual bool? IsHidden
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class CalendarMappingsContractResolver : DefaultContractResolver
    {
        Dictionary<string, string> mappings = new Dictionary<string, string>(5);

        public CalendarMappingsContractResolver()
        {            
            mappings["CalendarId"] = "id";            
            mappings["Title"] = "title";
            mappings["Description"] = "desc";
            mappings["IsHidden"] = "hidden";
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            return this.mappings.ContainsKey(propertyName) ? this.mappings[propertyName] : propertyName;
        }        
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class CalendarModelCollection : List<CalendarModel> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Serialize(bool mapping)
        {
            return JSON.Serialize(this, mapping ? new CalendarMappingsContractResolver() : null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static CalendarModelCollection Deserialize(string json)
        {
            return CalendarModelCollection.Deserialize(json, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <param name="mapping"></param>
        /// <returns></returns>
        public static CalendarModelCollection Deserialize(string json, bool mapping)
        {
            return JSON.Deserialize<CalendarModelCollection>(json, mapping ? new CalendarMappingsContractResolver() : null);
        }
    }
}
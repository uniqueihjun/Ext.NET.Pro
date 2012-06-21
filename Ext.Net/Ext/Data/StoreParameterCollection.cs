/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class StoreParameterCollection : BaseItemCollection<StoreParameter>
    {
        /// <summary>
        /// 
        /// </summary>
        public StoreParameterCollection()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public StoreParameter GetParameter(string name)
        {
            foreach (StoreParameter parameter in this)
            {
                if (parameter.Name == name)
                {
                    return parameter;
                }
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string this[string name]
        {
            get
            {
                foreach (StoreParameter parameter in this)
                {
                    if (parameter.Name == name)
                    {
                        return parameter.Value;
                    }
                }

                return null;
            }
            set
            {
                foreach (StoreParameter parameter in this)
                {
                    if (parameter.Name == name)
                    {
                        parameter.Value = value;
                        return;
                    }
                }

                this.Add(new StoreParameter(name, value));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wrapByFunction"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        public virtual string Serialize(bool wrapByFunction, bool group)
        {
            return group ? this.SerializeWithActions(wrapByFunction) : this.SerializeWithoutActions(wrapByFunction);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wrapByFunction"></param>
        /// <returns></returns>
        public virtual string SerializeWithoutActions(bool wrapByFunction)
        {
            if (this.Count == 0)
            {
                return "{}";
            }

            var prms = new Dictionary<string, ParameterCollection>(2)
               {
                   {
                       "apply",
                       new ParameterCollection()
                   },
                   {
                       "applyIf",
                       new ParameterCollection()
                   }
               };

            foreach (StoreParameter parameter in this)
            {
                prms[parameter.ApplyMode == ApplyMode.Always ? "apply" : "applyIf"].Add(parameter);
            }

            var sb = new StringBuilder(256);
            sb.Append("{");

            foreach (var dict in prms)
            {
                if (dict.Value.Count > 0)
                {
                    sb.Append(dict.Key);
                    sb.Append(":");
                    sb.Append(dict.Value.ToJson());
                    sb.Append(",");
                }
            }

            sb.Remove(sb.Length - 1, 1);

            sb.Append("}");

            return wrapByFunction ? "function(operation){{return {0};}}".FormatWith(sb.ToString()) : sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string SerializeWithActions(bool wrapByFunction)
        {
            if (this.Count == 0)
            {
                return "{}";
            }

            var prms = new Dictionary<string, Dictionary<string, ParameterCollection>>(2)
               {
                   {
                       "apply",
                       new Dictionary <string, ParameterCollection>(5)
                           {
                               {
                                  "all",
                                  new ParameterCollection()
                               },    
                               
                               {
                                  StoreAction.Create.ToString().ToLowerInvariant(),
                                  new ParameterCollection()
                               },

                               {
                                  StoreAction.Read.ToString().ToLowerInvariant(),
                                  new ParameterCollection()
                               },

                               {
                                  StoreAction.Update.ToString().ToLowerInvariant(),
                                  new ParameterCollection()
                               },

                               {
                                  StoreAction.Destroy.ToString().ToLowerInvariant(),
                                  new ParameterCollection()
                               }
                           }
                   },
                   {
                       "applyIf",
                       new Dictionary <string, ParameterCollection>(5)
                           {
                               {
                                  "all",
                                  new ParameterCollection()
                               },    
                               
                               {
                                  StoreAction.Create.ToString().ToLowerInvariant(),
                                  new ParameterCollection()
                               },

                               {
                                  StoreAction.Read.ToString().ToLowerInvariant(),
                                  new ParameterCollection()
                               },

                               {
                                  StoreAction.Update.ToString().ToLowerInvariant(),
                                  new ParameterCollection()
                               },

                               {
                                  StoreAction.Destroy.ToString().ToLowerInvariant(),
                                  new ParameterCollection()
                               } 
                           }
                   }
               };

            foreach (StoreParameter parameter in this)
            {
                prms[parameter.ApplyMode == ApplyMode.Always ? "apply" : "applyIf"][parameter.Action.HasValue ? parameter.Action.Value.ToString().ToLowerInvariant() : "all"].Add(parameter);
            }

            var sb = new StringBuilder(256);
            sb.Append("{");

            foreach (var dict in prms)
            {
                if (dict.Value.Any(paramsCollection => paramsCollection.Value.Count > 0))
                {
                    this.SerializeDictionary(sb, dict.Value, dict.Key);
                    sb.Append(",");
                }
            }

            sb.Remove(sb.Length - 1, 1);

            sb.Append("}");

            return wrapByFunction ? "function(operation){{return {0};}}".FormatWith(sb.ToString()) : sb.ToString();
        }

        private void SerializeDictionary(StringBuilder sb, Dictionary<string, ParameterCollection> dict, string name)
        {
            sb.Append(name);
            sb.Append(":{");

            foreach (var paramsCollection in dict.Where(paramsCollection => paramsCollection.Value.Count > 0))
            {
                sb.Append(paramsCollection.Key);
                sb.Append(":");
                sb.Append(paramsCollection.Value.ToJson());
                sb.Append(",");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("}");
        }
    }
}

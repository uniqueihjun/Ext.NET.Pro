/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    class ViewStateProcessor
    {
        private static readonly Dictionary<string, List<PropertyInfo>> propertiesCache = new Dictionary<string, List<PropertyInfo>>();
        private static readonly object syncObj = new object();

        private static List<PropertyInfo> GetProperties(object obj)
        {
            
            string fullName = obj.GetType().FullName;

            if (propertiesCache.ContainsKey(fullName))
            {
                return propertiesCache[fullName];
            }

            lock (syncObj)
            {
                if (propertiesCache.ContainsKey(fullName))
                {
                    return propertiesCache[fullName];
                }

                List<PropertyInfo> list = new List<PropertyInfo>();
                PropertyInfo[] result = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                foreach (PropertyInfo property in result)
                {
                    if (property.GetCustomAttributes(typeof(ViewStateMemberAttribute), true).Length == 1)
                    {
                        list.Add(property);
                    }
                }

                propertiesCache.Add(fullName, list);

                return list;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static object SaveViewState(object obj)
        {
            List<PropertyInfo> result = GetProperties(obj);
            List<object> states = new List<object>();
            
            foreach (PropertyInfo property in result)
            {
                try
                {
                    object value = property.GetValue(obj, null);
                   
                    if (value == null)
                    {
                        continue;
                    }

                    IStateManager sm = value as IStateManager;
                    if (sm == null)
                    {
                        throw new InvalidOperationException("The property ".ConcatWith(property, " in the class ", obj.GetType().Name, " is not IStateManager but marked as ViewStateMember"));
                    }

                    object propertyState = ((IStateManager)value).SaveViewState();

                    if (propertyState != null)
                    {
                        states.Add(new Pair(property.Name, propertyState));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error during SaveViewState initialization. "
                                        + property.Name
                                        + " - "
                                        + ex.Message, ex);
                }
            }

            return states.Count == 0 ? null : states.ToArray();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static void LoadViewState(object obj, object state)
        {
            object[] states = state as object[];

            if (states != null)
            {
                foreach (Pair pair in states)
                {
                    string propertyName = (string)pair.First;
                    object propertyState = pair.Second;

                    PropertyInfo property = obj.GetType().GetProperty(propertyName);

                    if (property == null)
                    {
                        throw new InvalidOperationException("Can't find the property '{0}' in class '{1}'".FormatWith(propertyName, obj.GetType().Name));
                    }

                    object value = property.GetValue(obj, null);
                   
                    IStateManager stateProperty = (IStateManager)value;
                    if (stateProperty != null)
                    {
                        stateProperty.LoadViewState(propertyState);
                    }
                }
            }
        }
    }
}

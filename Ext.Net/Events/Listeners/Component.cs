/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [ToolboxItem(false)]
    [TypeConverter(typeof(ListenersConverter))]
    [Description("")]
    public abstract partial class ComponentListeners : BaseItem
    {
        private static readonly Dictionary<string, List<ListenerPropertyInfo>> propertiesCache = new Dictionary<string, List<ListenerPropertyInfo>>();
        private static readonly object syncObj = new object();

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual void ClearListeners()
        {
            foreach (ListenerTriplet listener in this.Listeners)
            {
                listener.Listener.Clear();
            }
        }

        private List<ListenerPropertyInfo> ListenerProperties
        {
            get
            {
                string fullName = this.GetType().FullName;

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

                    List<ListenerPropertyInfo> list = new List<ListenerPropertyInfo>();
                    PropertyInfo[] result = this.GetType().GetProperties();

                    foreach (PropertyInfo property in result)
                    {
                        if (property.PropertyType == typeof(ComponentListener))
                        {
                            ConfigOptionAttribute config = ClientConfig.GetClientConfigAttribute(property);
                            list.Add(new ListenerPropertyInfo(property, config));
                        }
                    }

                    propertiesCache.Add(fullName, list);

                    return list;
                }
            }
        }

        private List<ListenerTriplet> listeners;

        private List<ListenerTriplet> Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new List<ListenerTriplet>();

                    foreach (ListenerPropertyInfo property in this.ListenerProperties)
                    {
                        ComponentListener value =  property.PropertyInfo.GetValue(this, null) as ComponentListener;

                        if (value != null)
                        {
                            this.listeners.Add(new ListenerTriplet(property.PropertyInfo.Name, value, property.Attribute));    
                        }
                    }
                }

                return this.listeners;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ListenerTriplet
    {
        private readonly string name;
        private readonly ComponentListener listener;
        private readonly ConfigOptionAttribute attribute;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ListenerTriplet(string name, ComponentListener listener, ConfigOptionAttribute attribute)
        {
            this.name = name;
            this.listener = listener;
            this.attribute = attribute;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Name
        {
            get { return name; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ComponentListener Listener
        {
            get { return listener; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfigOptionAttribute Attribute
        {
            get { return attribute; }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ListenerPropertyInfo
    {
        private readonly PropertyInfo propertyInfo;
        private readonly ConfigOptionAttribute attribute;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ListenerPropertyInfo(PropertyInfo propertyInfo, ConfigOptionAttribute attribute)
        {
            this.propertyInfo = propertyInfo;
            this.attribute = attribute;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public PropertyInfo PropertyInfo
        {
            get { return propertyInfo; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfigOptionAttribute Attribute
        {
            get { return attribute; }
        }
    }
}
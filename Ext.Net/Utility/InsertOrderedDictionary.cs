/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public class InsertOrderedDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public new void Add(TKey key, TValue value)
        {
            base.Add(key, value);
            this.insertList.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public new void Clear()
        {
            base.Clear();
            this.insertList.Clear();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public new bool Remove(TKey key)
        {
            bool result = base.Remove(key);

            if (result)
            {
                foreach (KeyValuePair<TKey, TValue> pair in this.insertList)
                {
                    if (pair.Key.Equals(key))
                    {
                        this.insertList.Remove(pair);
                        break;
                    }
                }
            }

            return result;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public new List<KeyValuePair<TKey, TValue>>.Enumerator GetEnumerator()
        {
            return this.insertList.GetEnumerator();
        }

        private readonly List<KeyValuePair<TKey, TValue>> insertList = new List<KeyValuePair<TKey, TValue>>();

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ReadOnlyCollection<KeyValuePair<TKey, TValue>> InsertList
        {
            get
            {
                return this.insertList.AsReadOnly();
            }
        }
    }
}

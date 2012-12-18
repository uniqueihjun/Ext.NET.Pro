/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
#if NET40
using System.Dynamic;
#endif
using System.Collections.Generic;

namespace Ext.Net
{
#if NET40
    public partial class DynamicConfigDictionary : DynamicObject
    {
        private Dictionary<string, object> config;

        public DynamicConfigDictionary()
        {
        }

        private Dictionary<string, object> Config
        {
            get
            {                
                return this.config ?? (this.config = new Dictionary<string, object>());
            }
        }

        // Implementing this function improves the debugging experience as it provides the debugger with the list of all
        // the properties currently defined on the object
        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return this.Config.Keys;
        }

        public virtual object GetDynamicValue(string key)
        {
            return this.Config[key];
        }

        public virtual void SetDynamicValue(string key, object value)
        {
            this.Config[key] = value;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (this.Config.ContainsKey(binder.Name))
            {
                result = this.Config[binder.Name];
            }
            else
            {
                result = null;
            }

            return true;            
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            this.Config[binder.Name] = value;
            return true;
        }

    }
#else
    public partial class DynamicConfigDictionary 
    { 
    }
#endif
}
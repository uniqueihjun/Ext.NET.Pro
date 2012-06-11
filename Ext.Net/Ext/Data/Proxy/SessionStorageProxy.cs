/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Proxy which uses HTML5 session storage as its data storage/retrieval mechanism. If this proxy is used in a browser where session storage is not supported, the constructor will throw an error. A session storage proxy requires a unique ID which is used as a key in which all record data are stored in the session storage object.
    /// 
    /// It's important to supply this unique ID as it cannot be reliably determined otherwise. If no id is provided but the attached store has a storeId, the storeId will be used. If neither option is presented the proxy will throw an error.
    /// 
    /// Proxies are almost always used with a store:
    /// 
    /// new Ext.data.Store({
    ///     proxy: {
    ///         type: 'sessionstorage',
    ///         id  : 'myProxyKey'
    ///     }
    /// });
    /// Alternatively you can instantiate the Proxy directly:
    /// 
    /// new Ext.data.proxy.SessionStorage({
    ///     id  : 'myOtherProxyKey'
    /// });
    ///  
    /// Note that session storage is different to local storage (see Ext.data.proxy.LocalStorage) - if a browser session is ended (e.g. by closing the browser) then all data in a SessionStorageProxy are lost. Browser restarts don't affect the Ext.data.proxy.LocalStorage - the data are preserved.
    /// </summary>
    [Meta]
    public partial class SessionStorageProxy : WebStorageProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public SessionStorageProxy()
        {
        }

        /// <summary>
        /// Alias
        /// </summary>
        [ConfigOption]
        [DefaultValue(null)]
        protected override string Type
        {
            get
            {
                return "sessionstorage";
            }
        }
    }
}

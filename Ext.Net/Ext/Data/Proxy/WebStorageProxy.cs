/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// WebStorageProxy is simply a superclass for the localStorage and sessionStorage proxies. It uses the new HTML5 key/value client-side storage objects to save model instances for offline use.
    /// Proxy throws an client side error if local storage is not supported in the current browser
    /// </summary>
    [Meta]
    public abstract partial class WebStorageProxy : AbstractProxy
    {
        /// <summary>
        /// The unique ID used as the key in which all record data are stored in the local storage object
        /// </summary>
        [Meta]
        [ConfigOption("id")]
        [Category("3. WebStorage")]
        [DefaultValue("")]
        [Description("The unique ID used as the key in which all record data are stored in the local storage object")]
        public virtual string StorageID
        {
            get
            {
                return (string)this.ViewState["StorageID"]??"";
            }
            set
            {
                this.State.Set("StorageID", value);
            }
        }

        /// <summary>
        /// Destroys all records stored in the proxy and removes all keys and values used to support the proxy from the storage object
        /// </summary>
        public virtual void Clear()
        {
            this.Call("clear");
        }

        /// <summary>
        /// Saves the given record in the Proxy. Runs each field's encode function (if present) to encode the data
        /// </summary>
        /// <param name="record">The model instance</param>
        /// <param name="id">The id to save the record under (defaults to the value of the record's getId() function)</param>
        public virtual void SetRecord(object record, string id)
        {
            this.Call("setRecord", record, id);
        }
    }
}

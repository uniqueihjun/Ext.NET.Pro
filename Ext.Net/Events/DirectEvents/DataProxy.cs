/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    [TypeConverter(typeof(DirectEventsConverter))]
    public partial class DataProxyDirectEvents : ComponentDirectEvents
    {
        public DataProxyDirectEvents() { }

        public DataProxyDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforeLoad;

        /// <summary>
        /// Fires before a network request is made to retrieve a data object.
        /// </summary>
        [ConfigOption("beforeload>Handler", JsonMode.Object)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
        [Description("Fires before a network request is made to retrieve a data object.")]
        public ComponentDirectEvent BeforeLoad
        {
            get
            {
                if (this.beforeLoad == null)
                {
                    this.beforeLoad = new ComponentDirectEvent(this);
                }

                return this.beforeLoad;
            }
        }

        private ComponentDirectEvent load;

        /// <summary>
        /// Fires before the load method's callback is called.
        /// </summary>
        [ConfigOption("load>Handler", JsonMode.Object)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
        [Description("Fires before the load method's callback is called.")]
        public ComponentDirectEvent Load
        {
            get
            {
                if (this.load == null)
                {
                    this.load = new ComponentDirectEvent(this);
                }

                return this.load;
            }
        }

        private ComponentDirectEvent loadException;

        /// <summary>
        /// Fires if an exception occurs in the Proxy during data loading. 
        /// This event can be fired for one of two reasons:
        ///     The load call timed out. This means the load callback did
        ///     not execute within the time limit specified by timeout.
        ///     In this case, this event will be raised and the fourth
        ///     parameter (read error) will be null.
        ///
        ///     The load succeeded but the reader could not read the response.
        ///     This means the server returned data, but the configured Reader
        ///     threw an error while reading the data. In this case, this event
        ///     will be raised and the caught error will be passed along as 
        ///     the fourth parameter of this event.
        /// 
        ///     Note that this event is also relayed through Store, so you
        ///     can listen for it directly on any Store instance.
        /// 
        ///     DirectEvents will be called with the following arguments:
        ///         this : Object
        ///         
        ///         options : Object
        ///             The loading options that were specified (see load for details).
        ///             If the load call timed out, this parameter will be null.
        ///         
        ///         arg : Object
        ///             The callback's arg object passed to the load function
        /// 
        ///         e : Error
        ///         The JavaScript Error object caught if the configured Reader
        ///         could not read the data. If the load call returned 
        ///         success: false, this parameter will be null.
        /// </summary>
        [ConfigOption("loadexception>Handler", JsonMode.Object)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
        [Description("Fires if an exception occurs in the Proxy during data loading")]
        public ComponentDirectEvent LoawdException
        {
            get
            {
                if (this.loadException == null)
                {
                    this.loadException = new ComponentDirectEvent(this);
                }

                return this.loadException;
            }
        }
    }
}
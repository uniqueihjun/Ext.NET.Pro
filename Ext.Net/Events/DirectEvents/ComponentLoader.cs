/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    ///<summary>
    ///</summary>
    public partial class ComponentLoaderDirectEvents : ComponentDirectEvents
    {
        public ComponentLoaderDirectEvents() { }

        public ComponentLoaderDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforeLoad;

        /// <summary>
        /// Fires before a load request is made to the server. Returning false from an event listener can prevent the load from occurring.
        /// Parameters
        ///   item : Ext.ComponentLoader
        ///   
        ///   options : Object
        ///   The options passed to the request
        /// </summary>
        [ListenerArgument(0, "item", typeof(ComponentLoader), "this")]
        [ListenerArgument(1, "options", typeof(object), "The options passed to the request")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeload", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a load request is made to the server. Returning false from an event listener can prevent the load from occurring.")]
        public virtual ComponentDirectEvent BeforeLoad
        {
            get
            {
                return this.beforeLoad ?? (this.beforeLoad = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent exception;

        /// <summary>
        /// Fires after an unsuccessful load.
        /// Parameters
        ///   item : Ext.ComponentLoader
        ///   
        ///   response : Object
        ///   The response from the server
        /// 
        ///   options : Object
        ///   The options passed to the request
        /// </summary>
        [ListenerArgument(0, "item", typeof(ComponentLoader), "this")]
        [ListenerArgument(1, "response", typeof(object), "The response from the server")]
        [ListenerArgument(2, "options", typeof(object), "The options passed to the request")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("exception", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after an unsuccessful load.")]
        public virtual ComponentDirectEvent Exception
        {
            get
            {
                return this.exception ?? (this.exception = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent load;

        /// <summary>
        /// Fires after a successful load.
        /// Parameters
        ///   item : Ext.ComponentLoader
        ///   
        ///   response : Object
        ///   The response from the server
        /// 
        ///   options : Object
        ///   The options passed to the request
        /// </summary>
        [ListenerArgument(0, "item", typeof(ComponentLoader), "this")]
        [ListenerArgument(1, "response", typeof(object), "The response from the server")]
        [ListenerArgument(2, "options", typeof(object), "The options passed to the request")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("load", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after a successful load.")]
        public virtual ComponentDirectEvent Load
        {
            get
            {
                return this.load ?? (this.load = new ComponentDirectEvent(this));
            }
        }
    }
}

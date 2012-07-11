/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [ToolboxItem(false)]
    [TypeConverter(typeof(ListenersConverter))]
    public partial class ProxyListeners : ComponentListeners
    {
        private ComponentListener exception;

        /// <summary>
        /// Fires when the server returns an exception
        /// Parameters
        /// proxy : Ext.data.proxy.Proxy
        /// response : Object
        ///   The response from the AJAX request
        /// operation : Ext.data.Operation
        ///    The operation that triggered request
        /// </summary>
        [ListenerArgument(0, "proxy", typeof(AbstractProxy), "The proxy for the request")]
        [ListenerArgument(1, "response", typeof(string), "The response from the AJAX request")]
        [ListenerArgument(2, "operation", typeof(string), "The operation that triggered request")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("exception", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the server returns an exception")]
        public virtual ComponentListener Exception
        {
            get
            {
                if (this.exception == null)
                {
                    this.exception = new ComponentListener();
                }

                return this.exception;
            }
        }
    }
}
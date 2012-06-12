/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
	[Description("")]
    public partial class TreeLoaderListeners : ComponentListeners
    {
        private ComponentListener beforeLoad;

        /// <summary>
        /// Fires before a network request is made to retrieve the Json text which specifies a node's children.
        /// </summary>
        [ListenerArgument(0, "loader", typeof(TreeLoader), "this")]
        [ListenerArgument(1, "node", typeof(Node))]
        [ListenerArgument(2, "callback")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeload", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a network request is made to retrieve the Json text which specifies a node's children.")]
        public virtual ComponentListener BeforeLoad
        {
            get
            {
                if (this.beforeLoad == null)
                {
                    this.beforeLoad = new ComponentListener();
                }

                return this.beforeLoad;
            }
        }

        private ComponentListener load;

        /// <summary>
        /// Fires when the node has been successfuly loaded.
        /// </summary>
        [ListenerArgument(0, "loader", typeof(TreeLoader), "this")]
        [ListenerArgument(1, "node", typeof(Node))]
        [ListenerArgument(2, "response")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("load", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the node has been successfuly loaded.")]
        public virtual ComponentListener Load
        {
            get
            {
                if (this.load == null)
                {
                    this.load = new ComponentListener();
                }

                return this.load;
            }
        }

        private ComponentListener loadException;

        /// <summary>
        /// Fires if the network request failed.
        /// </summary>
        [ListenerArgument(0, "loader", typeof(TreeLoader), "this")]
        [ListenerArgument(1, "node", typeof(Node))]
        [ListenerArgument(2, "response")]
        [ListenerArgument(3, "errorMessage")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("loadexception", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires if the network request failed.")]
        public virtual ComponentListener LoadException
        {
            get
            {
                if (this.loadException == null)
                {
                    this.loadException = new ComponentListener();
                }

                return this.loadException;
            }
        }
    }
}
/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public abstract partial class Node : StateManagedItem
    {
        private static readonly object idCounter = new object();
            
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected Node() { }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public int GetID()
        {
            lock (idCounter)
            {
                object obj = HttpContext.Current.Items["_uniqueTreeNodeID"];
                int id = 0;

                if (obj != null)
                {
                    id = (int)obj;
                    id++;
                }

                HttpContext.Current.Items["_uniqueTreeNodeID"] = id;

                return id;
            }
        }

        private readonly string autoID="";

        /// <summary>
        /// The id for this node. If one is not specified, one is generated.
        /// </summary>
        [ConfigOption("id")]
        [Category("2. Node")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The id for this node. If one is not specified, one is generated.")]
        public virtual string NodeID
        {
            get
            {
                return (string)this.ViewState["NodeID"] ?? this.autoID;
            }
            set 
            { 
                this.ViewState["NodeID"] = value; 
            }
        }

        /// <summary>
        /// True if this node is a leaf and does not have children
        /// </summary>
        [ConfigOption]
        [Category("2. Node")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True if this node is a leaf and does not have children")]
        public virtual bool Leaf
        {
            get
            {
                object obj = this.ViewState["Leaf"];
                return (obj == null) ? false : (bool) obj;
            }
            set 
            { 
                this.ViewState["Leaf"] = value; 
            }
        }
    }
}
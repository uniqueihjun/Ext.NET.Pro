/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class SubmittedNode
    {
        private string nodeID;
        private string clientID;
        private string text;
        private string path;
        private JsonObject attributes;
        private List<SubmittedNode> children;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SubmittedNode(string path, string text, string nodeID, JsonObject attributes, List<SubmittedNode> children)
        {
            this.path = path;
            this.nodeID = nodeID;
            this.text = text;
            this.attributes = attributes;
            this.children = children;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [JsonConstructor]
        public SubmittedNode(string path, string text, string nodeID, string clientID, JsonObject attributes, List<SubmittedNode> children)
            : this(path, text, nodeID, attributes, children)
        {
            this.clientID = clientID;
        }

        public TreePanelBase Tree 
        { 
            get; 
            set; 
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public List<SubmittedNode> Children
        {
            get
            {
                if (this.children == null)
                {
                    this.children = new List<SubmittedNode>();
                }

                return this.children;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string NodeID
        {
            get 
            { 
                return this.nodeID; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClientID
        {
            get 
            { 
                return this.clientID; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Text
        {
            get 
            { 
                return this.text; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Path
        {
            get 
            { 
                return this.path; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Checked
        {
            get
            {
                if (this.Attributes.Count > 0)
                {
                    if (this.Attributes.ContainsKey("checked"))
                    {
                        object value = this.Attributes["checked"];

                        return value != null ? (bool)value : false;
                    }
                }

                return false;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual JsonObject Attributes
        {
            get
            {
                if (this.attributes == null)
                {
                    this.attributes = new JsonObject();
                }

                return this.attributes;
            }
        }

        public NodeProxy ToProxyNode()
        {
            return this.Tree.GetNodeById(this.NodeID ?? this.ClientID);
        }

        public NodeProxy ToProxyNode(TreePanelBase tree)
        {
            return (tree ?? this.Tree).GetNodeById(this.NodeID ?? this.ClientID);
        }
    }
}
/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public class SubmittedNode
    {
        private string nodeID;
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
            get { return nodeID; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Text
        {
            get { return text; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Path
        {
            get { return path; }
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
                    foreach (KeyValuePair<string, object> attribute in this.Attributes)
                    {
                        if (attribute.Key == "checked")
                        {
                            return (bool)attribute.Value;
                        }
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
    }
}
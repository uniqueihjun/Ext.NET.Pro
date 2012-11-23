/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    [Description("")]
    public partial class TreeNode : TreeNodeBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public TreeNode() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        [Description("")]
        public TreeNode(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="icon"></param>
        [Description("")]
        public TreeNode(string text, Icon icon)
        {
            this.Text = text;
            this.Icon = icon;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="icon"></param>
        [Description("")]
        public TreeNode(string id, string text, Icon icon)
        {
            this.NodeID = id;
            this.Text = text;
            this.Icon = icon;
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.tree.TreeNode";
            }
        }

        private TreeNodeCollection nodes;

        /// <summary>
        /// The root node for the tree.
        /// </summary>
        [Category("3. TreeNode")]
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The root node for the tree.")]
        public virtual TreeNodeCollection Nodes
        {
            get
            {
                if (this.nodes == null)
                {
                    this.nodes = new TreeNodeCollection(false);
                    this.nodes.AfterItemAdd += Nodes_AfterItemAdd;
                }

                return this.nodes;
            }
        }

        void Nodes_AfterItemAdd(TreeNodeBase item)
        {
            item.ParentNode = this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [Description("")]
        protected virtual string NodeType
        {
            get
            {
                return this.EnforceNodeType ? "node" : "";
            }
        }

        private TreeNodeListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ViewStateMember]
        [Description("Client-side JavaScript Event Handlers")]
        public TreeNodeListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new TreeNodeListeners();
                }

                return this.listeners;
            }
        }
    }
}
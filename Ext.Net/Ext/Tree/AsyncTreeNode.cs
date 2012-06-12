/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class AsyncTreeNode : TreeNodeBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public AsyncTreeNode() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        [Description("")]
        public AsyncTreeNode(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        [Description("")]
        public AsyncTreeNode(string id, string text)
        {
            this.NodeID = id;
            this.Text = text;
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
                return "Ext.tree.AsyncTreeNode";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("")]
        public override bool EnforceNodeType
        {
            get
            {
                object obj = this.ViewState["EnforceNodeType"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["EnforceNodeType"] = value;
            }
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
                return this.EnforceNodeType ? "async" : "";
            }
        }

        private AsyncTreeNodeListeners listeners;

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
        public AsyncTreeNodeListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new AsyncTreeNodeListeners();
                }

                return this.listeners;
            }
        }

        private TreeLoaderCollection treeLoader;

        /// <summary>
        /// The root node for the tree.
        /// </summary>
        [ConfigOption("loader>Primary")]
        [Category("7. TreePanel")]
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The root node for the tree.")]
        public virtual TreeLoaderCollection Loader
        {
            get
            {
                if (this.treeLoader == null)
                {
                    this.treeLoader = new TreeLoaderCollection();
                    this.treeLoader.AfterItemAdd += TreeLoader_AfterItemAdd;
                }

                return this.treeLoader;
            }
        }

        void TreeLoader_AfterItemAdd(TreeLoaderBase item)
        {
            if (item is PageTreeLoader)
            {
                throw new Exception("PageTreeLoader cannot be a loader of AsyncTreeNode");
            }
        }
    }
}
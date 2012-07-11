/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Collections.Generic;

namespace Ext.Net
{
    /// <summary>
    /// Adds custom behavior for left/right keyboard navigation for use with a tree.
    /// Depends on the view having an expand and collapse method which accepts a record. 
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    public partial class TreeSelectionModel : RowSelectionModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public TreeSelectionModel() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.selection.TreeModel";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        [DefaultValue("")]
        [ConfigOption]
        public override string SelType
        {
            get
            {
                return "treemodel";
            }
        }

        /// <summary>
        /// Prune records when they are removed from the store from the selection. 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(false)]
        [Description("Prune records when they are removed from the store from the selection.")]
        public override bool PruneRemoved
        {
            get
            {
                return this.State.Get<bool>("PruneRemoved", false);
            }
            set
            {
                this.State.Set("PruneRemoved", value);
            }
        }

        private List<SubmittedNode> selectedNodes;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual List<SubmittedNode> SelectedNodes
        {
            get
            {
                return this.selectedNodes;
            }
            protected internal set
            {
                this.selectedNodes = value;
            }
        }
    }
}

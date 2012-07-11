/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Multi selection for a TreePanel.
    /// </summary>
    [ToolboxItem(false)]
    [Description("Multi selection for a TreePanel.")]
    public partial class MultiSelectionModel : AbstractTreeSelectionModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.tree.MultiSelectionModel";
            }
        }

        /// <summary>
        /// Selection mode
        /// </summary>
        [ConfigOption(JsonMode.ToLower)]
        [Category("3. MultiSelectionModel")]
        [DefaultValue(KeepSelectionMode.WithCtrlKey)]
        [Description("Selection mode")]
        public virtual KeepSelectionMode KeepSelectionOnClick
        {
            get
            {
                object obj = this.ViewState["KeepSelectionOnClick"];
                return (obj == null) ? KeepSelectionMode.WithCtrlKey : (KeepSelectionMode)obj;
            }
            set
            {
                this.ViewState["KeepSelectionOnClick"] = value;
            }
        }

        private MultiSelectionModelListeners listeners;

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
        public MultiSelectionModelListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new MultiSelectionModelListeners();
                }

                return this.listeners;
            }
        }


        private MultiSelectionModelDirectEvents directEvents;

        /// <summary>
        /// Server-side DirectEvent Handlers
        /// </summary>
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [ViewStateMember]
        [Description("Server-side DirectEventHandlers")]
        public MultiSelectionModelDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new MultiSelectionModelDirectEvents();
                }

                return this.directEvents;
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

        /// <summary>
        /// Clears all selections.
        /// </summary>
        [Description("Clears all selections.")]
        public virtual void ClearSelections()
        {
            this.Call("clearSelections");
        }

        /// <summary>
        /// Select a node.
        /// </summary>
        /// <param name="nodeId">The node to select</param>
        [Description("Select a node.")]
        public virtual void Select(string nodeId)
        {
            this.Call("select", new JRawValue(this.ClientID.ConcatWith(".getNodeById(", JSON.Serialize(nodeId), ")")));
        }

        /// <summary>
        /// Select a node.
        /// </summary>
        /// <param name="nodeId">The node to select</param>
        /// <param name="keepExisting">True to retain existing selections</param>
        [Description("Select a node.")]
        public virtual void Select(string nodeId, bool keepExisting)
        {
            this.Call("select", new JRawValue(this.ClientID.ConcatWith(".getNodeById(", JSON.Serialize(nodeId), ")")), null, keepExisting);
        }
        
        /// <summary>
        /// Deselect a node.
        /// </summary>
        /// <param name="nodeId">The node to unselect</param>
        [Description("Deselect a node.")]
        public virtual void Unselect(string nodeId)
        {
            this.Call("unselect", new JRawValue(this.ClientID.ConcatWith(".getNodeById(", JSON.Serialize(nodeId), ")")));
        }
    }
}
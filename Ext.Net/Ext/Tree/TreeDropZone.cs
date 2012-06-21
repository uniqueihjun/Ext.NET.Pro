/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class TreeDropZone : DropZone
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
                return "Ext.dd.TreeDropZone";
            }
        }

        private ConfigItemCollection dragOverData;

        /// <summary>
        /// Arbitrary data that can be associated with this tree and will be included in the event object that gets passed to any nodedragover event handler (defaults to {})
        /// </summary>
        [Category("7. TreeDropZone")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Arbitrary data that can be associated with this tree and will be included in the event object that gets passed to any nodedragover event handler (defaults to {})")]
        public virtual ConfigItemCollection DragOverData
        {
            get
            {
                if (this.dragOverData == null)
                {
                    this.dragOverData = new ConfigItemCollection();
                }

                return this.dragOverData;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("dragOverData", JsonMode.Raw)]
        [DefaultValue("{}")]
        [Description("")]
        protected internal virtual string DragOverDataProxy
        {
            get
            {
                return this.DragOverData.ToJson();
            }
        }

        /// <summary>
        /// True if drops on the tree container (outside of a specific tree node) are allowed (defaults to false)
        /// </summary>
        [ConfigOption]
        [Category("7. TreeDropZone")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True if drops on the tree container (outside of a specific tree node) are allowed (defaults to false)")]
        public virtual bool AllowContainerDrop
        {
            get
            {
                return this.State.Get<bool>("AllowContainerDrop", false);
            }
            set
            {
                this.State.Set("AllowContainerDrop", value);
            }
        }

        /// <summary>
        /// Allow inserting a dragged node between an expanded parent node and its first child that will become a sibling of the parent when dropped (defaults to false)
        /// </summary>
        [ConfigOption]
        [Category("7. TreeDropZone")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Allow inserting a dragged node between an expanded parent node and its first child that will become a sibling of the parent when dropped (defaults to false)")]
        public virtual bool AllowParentInsert
        {
            get
            {
                return this.State.Get<bool>("AllowParentInsert", false);
            }
            set
            {
                this.State.Set("AllowParentInsert", value);
            }
        }

        /// <summary>
        /// True if the tree should only allow append drops (use for trees which are sorted, defaults to false)
        /// </summary>
        [ConfigOption]
        [Category("7. TreeDropZone")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("True if the tree should only allow append drops (use for trees which are sorted, defaults to false)")]
        public virtual bool AppendOnly
        {
            get
            {
                return this.State.Get<bool>("AppendOnly", false);
            }
            set
            {
                this.State.Set("AppendOnly", value);
            }
        }

        /// <summary>
        /// The delay in milliseconds to wait before expanding a target tree node while dragging a droppable node over the target (defaults to 1000)
        /// </summary>
        [ConfigOption]
        [Category("7. TreeDropZone")]
        [DefaultValue(1000)]
        [NotifyParentProperty(true)]
        [Description("The delay in milliseconds to wait before expanding a target tree node while dragging a droppable node over the target (defaults to 1000)")]
        public virtual int ExpandDelay
        {
            get
            {
                return this.State.Get<int>("ExpandDelay", 1000);
            }
            set
            {
                this.State.Set("ExpandDelay", value);
            }
        }
    }
}
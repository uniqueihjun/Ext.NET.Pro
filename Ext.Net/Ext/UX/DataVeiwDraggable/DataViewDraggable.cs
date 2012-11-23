/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(DataViewDraggable), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:DataViewDraggable runat=\"server\" />")]
    [Description("")]
    public partial class DataViewDraggable : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public DataViewDraggable() { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                baseList.Add(new ClientScriptItem(typeof(DataViewDraggable), "Ext.Net.Build.Ext.Net.ux.view.Draggable.js", "/ux/view/Draggable.js"));

                return baseList;
            }
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
                return "Ext.ux.DataView.Draggable";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override System.Type RequiredOwnerType
        {
            get
            {
                return typeof(AbstractDataView);
            }
        }

        /// <summary>
        /// The CSS class added to the outermost element of the created ghost proxy
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The CSS class added to the outermost element of the created ghost proxy")]
        public virtual string GhostCls
        {
            get
            {
                return this.State.Get<string>("GhostCls", "");
            }
            set
            {
                this.State.Set("GhostCls", value);
            }
        }

        private XTemplate ghostTpl;

        /// <summary>
        /// The template used in the ghost DataView
        /// </summary>
        [Meta]
        [DefaultValue(null)]
        [ConfigOption("ghostTpl", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The template used in the ghost DataView")]
        public virtual XTemplate GhostTpl
        {
            get
            {
                return this.ghostTpl;
            }
            set
            {
                if (this.ghostTpl != null && this.PluginOwner != null)
                {
                    this.PluginOwner.Controls.Remove(this.ghostTpl);
                    this.PluginOwner.LazyItems.Remove(this.ghostTpl);
                }

                this.ghostTpl = value;

                if (this.ghostTpl != null && this.PluginOwner != null)
                {
                    this.ghostTpl.EnableViewState = this.DesignMode;
                    this.PluginOwner.Controls.Add(this.ghostTpl);
                    this.PluginOwner.LazyItems.Add(this.ghostTpl);
                }
            }
        }

        private DragZone ddConfig;

        /// <summary>
        /// Config object that is applied to the internally created DragZone
        /// </summary>
        [Meta]
        [DefaultValue(null)]
        [Description("Config object that is applied to the internally created DragZone")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public virtual DragZone DDConfig
        {
            get
            {
                return this.ddConfig;
            }
            set
            {
                if (value != null)
                {
                    value.EnableViewState = this.DesignMode;
                }
                this.ddConfig = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        [ConfigOption("ddConfig", JsonMode.Raw)]
        protected virtual string DDConfigProxy
        {
            get
            {
                if (this.DDConfig == null)
                {
                    return "";
                }
                string cfg = new ClientConfig().Serialize(this.DDConfig, true);
                return cfg != Const.EmptyObject ? cfg : "";
            }
        }

        protected internal override void PluginAdded()
        {
            base.PluginAdded();

            if (this.GhostTpl != null && this.PluginOwner != null)
            {
                this.GhostTpl.EnableViewState = this.DesignMode;
                this.PluginOwner.Controls.Add(this.GhostTpl);
                this.PluginOwner.LazyItems.Add(this.GhostTpl);
            }
        }

        protected internal override void PluginRemoved()
        {
            base.PluginRemoved();

            if (this.GhostTpl != null && this.PluginOwner != null)
            {
                this.PluginOwner.Controls.Remove(this.GhostTpl);
                this.PluginOwner.LazyItems.Remove(this.GhostTpl);
            }
        }
    }
}
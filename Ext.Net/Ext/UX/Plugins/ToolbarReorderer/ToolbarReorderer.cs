/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Plugin which can be attached to any Ext.Toolbar instance. Provides ability to reorder toolbar items with drag and drop.
    /// </summary>
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(ToolbarReorderer), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:ToolbarReorderer runat=\"server\" />")]
    [Description("Plugin which can be attached to any Ext.Toolbar instance. Provides ability to reorder toolbar items with drag and drop.")]
    public partial class ToolbarReorderer : Plugin
    {
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

                baseList.Add(new ClientScriptItem(typeof(ToolbarReorderer), "Ext.Net.Build.Ext.Net.ux.plugins.toolbarreorderer.toolbarreorderer.js", "/ux/plugins/toolbarreorderer/toolbarreorderer.js"));

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
                return "Ext.ux.ToolbarReorderer";
            }
        }
        
        /// <summary>
        /// If set to true, the rearranging of the toolbar items is animated
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. ToolbarReorderer")]
        [DefaultValue(true)]
        [Description("If set to true, the rearranging of the toolbar items is animated")]
        public virtual bool Animate
        {
            get
            {
                object obj = this.ViewState["Animate"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["Animate"] = value;
            }
        }

        /// <summary>
        /// The duration of the animation used to move other toolbar items out of the way
        /// </summary>
        [Meta]
        [Category("3. ToolbarReorderer")]
        [DefaultValue(0.2)]
        [Description("The duration of the animation used to move other toolbar items out of the way")]
        public virtual double AnimationDuration
        {
            get
            {
                object obj = this.ViewState["AnimationDuration"];
                return (obj == null) ? 0.2 : (double)obj;
            }
            set
            {
                this.ViewState["AnimationDuration"] = value;
            }
        }

        /// <summary>
        /// True to make every toolbar draggable unless reorderable is specifically set to false. This defaults to false
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. ToolbarReorderer")]
        [DefaultValue(false)]
        [Description("True to make every toolbar draggable unless reorderable is specifically set to false. This defaults to false")]
        public virtual bool DefaultReorderable
        {
            get
            {
                object obj = this.ViewState["DefaultReorderable"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["DefaultReorderable"] = value;
            }
        }

        private ToolbarReordererListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ViewStateMember]
        [Description("Client-side JavaScript Event Handlers")]
        public ToolbarReordererListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new ToolbarReordererListeners();
                }

                return this.listeners;
            }
        }


        private ToolbarReordererDirectEvents directEvents;

        /// <summary>
        /// Server-side DirectEvent Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [ViewStateMember]
        [Description("Server-side DirectEventHandlers")]
        public ToolbarReordererDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new ToolbarReordererDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}
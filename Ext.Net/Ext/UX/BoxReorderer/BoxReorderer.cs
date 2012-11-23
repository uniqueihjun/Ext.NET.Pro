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
using System.Drawing.Design;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Plugin which can be attached to any container instance with VBox/HBox layout. Provides ability to reorder container items with drag and drop.
    /// </summary>
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(BoxReorderer), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:BoxReorderer runat=\"server\" />")]
    [Description("Plugin which can be attached to any container instance with VBox/HBox layout. Provides ability to reorder container items with drag and drop.")]
    public partial class BoxReorderer : Plugin
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

                baseList.Add(new ClientScriptItem(typeof(BoxReorderer), "Ext.Net.Build.Ext.Net.ux.boxreorderer.boxreorderer.js", "/ux/boxreorderer/boxreorderer.js"));

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
                return this.Parent is AbstractTabPanel ? "Ext.ux.TabReorderer" : "Ext.ux.BoxReorderer";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override System.Type RequiredOwnerType
        {
            get
            {
                return typeof(AbstractContainer);
            }
        }
        
        /// <summary>
        /// The duration of the animation in milliseconds
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. BoxReorderer")]
        [DefaultValue(100)]
        [Description("The duration of the animation in milliseconds")]
        public virtual int Animate
        {
            get
            {
                return this.State.Get<int>("Animate", 100);
            }
            set
            {
                this.State.Set("Animate", value);
            }
        }

        /// <summary>
        /// A selector which identifies the encapsulating elements of child Components which participate in reordering.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. BoxReorderer")]
        [DefaultValue(".x-box-item")]
        [Description("A selector which identifies the encapsulating elements of child Components which participate in reordering.")]
        public virtual string ItemSelector
        {
            get
            {
                return this.State.Get<string>("ItemSelector", ".x-box-item");
            }
            set
            {
                this.State.Set("ItemSelector", value);
            }
        }

        private BoxReordererListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]        
        [Description("Client-side JavaScript Event Handlers")]
        public BoxReordererListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new BoxReordererListeners();
                }

                return this.listeners;
            }
        }


        private BoxReordererDirectEvents directEvents;

        /// <summary>
        /// Server-side DirectEvent Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]        
        [Description("Server-side DirectEventHandlers")]
        public BoxReordererDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new BoxReordererDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}
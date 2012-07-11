/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Panel is a container that has specific functionality and structural components that make it the perfect building block for application-oriented user interfaces.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:Panel runat=\"server\" Title=\"Title\" Height=\"300\"><Items></Items></{0}:Panel>")]
    [ToolboxBitmap(typeof(Panel), "Build.ToolboxIcons.Panel.bmp")]
    [Designer(typeof(PanelDesigner))]
    [Description("Panel is a container that has specific functionality and structural components that make it the perfect building block for application-oriented user interfaces.")]
    public partial class Panel : PanelBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Panel() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        [Description("")]
        public Panel(string title) { this.Title = title; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        [Description("")]
        public Panel(string title, Icon icon) 
        {
            this.Title = title;
            this.Icon = icon;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override List<ResourceItem> Resources
        {
            get 
            {
                List<ResourceItem> baseList = base.Resources;
         
                if (this.RegisterAllResources || this.FormGroup)
                {
                    baseList.Capacity += 1;

                    baseList.Add(new ClientStyleItem(typeof(Panel), "Ext.Net.Build.Ext.Net.ux.extensions.formgroup.css.formgroup-embedded.css", "/ux/extensions/formgroup/css/formgroup.css"));
                }

                return baseList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        [Description("")]
        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

            if (this.FormGroup)
            {
                this.Collapsible = true;
                this.AnimCollapse = false;
                this.TitleCollapse = true;
                this.HideCollapseTool = true;
                this.BaseCls = "x-form-group";
            }
        }

        private PanelListeners listeners;

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
        public PanelListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new PanelListeners();
                }

                return this.listeners;
            }
        }

        private PanelDirectEvents directEvents;

        /// <summary>
        /// Server-side Ajax Event Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [ViewStateMember]
        [Description("Server-side Ajax Event Handlers")]
        public PanelDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new PanelDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}
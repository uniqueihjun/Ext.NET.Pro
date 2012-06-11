/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A specialized panel intended for use as an application window. Windows are floated and draggable by default, and also provide specific behavior like the ability to maximize and restore (with an event for minimizing, since the minimize behavior is application-specific). Windows can also be linked to a Ext.WindowGroup or managed by the Ext.WindowManager to provide grouping, activation, to front/back and other application-specific behavior.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:Window runat=\"server\" Title=\"Title\" Collapsible=\"true\" Icon=\"Application\" Height=\"185\" Width=\"350\"><Items></Items></{0}:Window>")]
    [ToolboxBitmap(typeof(Window), "Build.ToolboxIcons.Window.bmp")]
    [Designer(typeof(WindowDesigner))]
    [Description("A specialized panel intended for use as an application window. Windows are floated and draggable by default, and also provide specific behavior like the ability to maximize and restore (with an event for minimizing, since the minimize behavior is application-specific). Windows can also be linked to a Ext.WindowGroup or managed by the Ext.WindowManager to provide grouping, activation, to front/back and other application-specific behavior.")]
    public partial class Window : WindowBase
    {
        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Window() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        [Description("")]
        public Window(string title) : this(title, Icon.None) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        [Description("")]
        public Window(string title, Icon icon)
        {
            this.Title = title;
            this.Icon = icon;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        /// <param name="html"></param>
        [Description("")]
        public Window(string title, Icon icon, string html)
        {
            this.Title = title;
            this.Icon = icon;
            this.Html = html;
            this.Padding = 5;
        }


        /*  Lifecycle
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        [Description("")]
        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

            if (this.LoadMask.ShowMask && !this.AutoLoad.IsDefault)
            {
                // Stomp on Show Listener if adding LoadMask.
                // Required because listener must be wired up during instantiation. 

                string loadMask = "el.loadMask=new Ext.LoadMask(el.body,".ConcatWith(new ClientConfig().Serialize(this.LoadMask), ");");
                
                this.Listeners.Show.Handler = this.Listeners.Show.Handler.EnsureSemiColon().ConcatWith(loadMask);
            }
        }


        /*  Client Events
            -----------------------------------------------------------------------------------------------*/

        private WindowListeners listeners;

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
        public WindowListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new WindowListeners();
                }

                return this.listeners;
            }
        }

        private WindowDirectEvents directEvents;

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
        public WindowDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new WindowDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}
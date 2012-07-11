/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Panel is a container that has specific functionality and structural components that make it the perfect building block for application-oriented user interfaces.
    /// 
    /// Panels are, by virtue of their inheritance from Ext.container.Container, capable of being configured with a layout, and containing child Components.
    /// 
    /// When either specifying child items of a Panel, or dynamically adding Components to a Panel, remember to consider how you wish the Panel to arrange those child elements, and whether those child elements need to be sized using one of Ext's built-in layout schemes. By default, Panels use the Auto scheme. This simply renders child components, appending them one after the other inside the Container, and does not apply any sizing at all.
    /// 
    /// A Panel may also contain bottom and top toolbars, along with separate header, footer and body sections (see frame for additional information).
    /// 
    /// Panel also provides built-in collapsible, expandable and closable behavior. Panels can be easily dropped into any Container or layout, and the layout and rendering pipeline is completely managed by the framework.
    /// 
    /// Note: By default, the close header tool destroys the Panel resulting in removal of the Panel and the destruction of any descendant Components. This makes the Panel object, and all its descendants unusable. To enable the close tool to simply hide a Panel for later re-use, configure the Panel with closeAction: 'hide'.
    /// 
    /// Usually, Panels are used as constituents within an application, in which case, they would be used as child items of Containers, and would themselves use Ext.Components as child items. 
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:Panel runat=\"server\" Title=\"Title\" Height=\"300\"><Items></Items></{0}:Panel>")]
    [ToolboxBitmap(typeof(Panel), "Build.ToolboxIcons.Panel.bmp")]
    [Description("Panel is a container that has specific functionality and structural components that make it the perfect building block for application-oriented user interfaces.")]
    public partial class Panel : AbstractPanel
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
        public Panel(string title)
        {
            this.Title = title;
        }

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
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.panel.Panel";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "panel";
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
        [Description("Client-side JavaScript Event Handlers")]
        public PanelListeners Listeners
        {
            get
            {
                return this.listeners ?? (this.listeners = new PanelListeners());
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
        [Description("Server-side Ajax Event Handlers")]
        public PanelDirectEvents DirectEvents
        {
            get
            {
                return this.directEvents ?? (this.directEvents = new PanelDirectEvents(this));
            }
        }
    }
}
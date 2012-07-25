/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Basic Toolbar class. Although the defaultType for Toolbar is button, Toolbar elements (child items for the Toolbar container) may be virtually any type of Component. Toolbar elements can be created explicitly via their constructors, or implicitly via their xtypes, and can be added dynamically.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:Toolbar runat=\"server\"><Items></Items></{0}:Toolbar>")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(Toolbar), "Build.ToolboxIcons.Toolbar.bmp")]
    [Description("Basic Toolbar class. Although the defaultType for Toolbar is button, Toolbar elements (child items for the Toolbar container) may be virtually any type of Component. Toolbar elements can be created explicitly via their constructors, or implicitly via their xtypes, and can be added dynamically.")]
    public partial class Toolbar : ToolbarBase 
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Toolbar() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "toolbar";
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
                return "Ext.toolbar.Toolbar";
            }
        }

        private ToolbarListeners listeners;

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
        public ToolbarListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new ToolbarListeners();
                }

                return this.listeners;
            }
        }

        private ToolbarDirectEvents directEvents;

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
        public ToolbarDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new ToolbarDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}

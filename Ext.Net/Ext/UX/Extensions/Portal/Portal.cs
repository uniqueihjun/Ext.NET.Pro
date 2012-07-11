/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(Portal), "Build.ToolboxIcons.Portal.bmp")]
    [ToolboxData("<{0}:Portal runat=\"server\" Title=\"Portal\" Layout=\"column\"><Items><{0}:PortalColumn runat=\"server\" StyleSpec=\"padding:10px 0 10px 10px\" ColumnWidth=\"0.33\" Layout=\"anchor\" DefaultAnchor=\"100%\"><Items><{0}:Portlet runat=\"server\" Title=\"Portlet 1\" Padding=\"5\" Html=\"Portlet 1\" /><{0}:Portlet runat=\"server\" Title=\"Portlet 2\" Padding=\"5\" Html=\"Portlet 2\" /></Items></{0}:PortalColumn><{0}:PortalColumn runat=\"server\" StyleSpec=\"padding:10px 0 10px 10px\" ColumnWidth=\"0.33\" Layout=\"anchor\" DefaultAnchor=\"100%\"><Items><{0}:Portlet runat=\"server\" Title=\"Portlet 3\" Padding=\"5\" Html=\"Portlet 3\" /></Items></{0}:PortalColumn><{0}:PortalColumn runat=\"server\" StyleSpec=\"padding:10px\" ColumnWidth=\"0.33\" Layout=\"anchor\" DefaultAnchor=\"100%\"><Items><{0}:Portlet Title=\"Portlet 4\" runat=\"server\" Padding=\"5\" Html=\"Portlet 4\" /></Items></{0}:PortalColumn></Items></{0}:Portal>")]
    [Description("")]
    public partial class Portal : PanelBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Portal() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 2;

                baseList.Add(new ClientStyleItem(typeof(Portal), "Ext.Net.Build.Ext.Net.ux.extensions.portal.css.portal-embedded.css", "/ux/extensions/portal/css/portal.css"));
                baseList.Add(new ClientScriptItem(typeof(Portal), "Ext.Net.Build.Ext.Net.ux.extensions.portal.portal.js", "/ux/extensions/portal/portal.js"));

                return baseList;
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
                return "portal";
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
                return "Ext.ux.Portal";
            }
        }

        private PortalListeners listeners;

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
        public PortalListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new PortalListeners();
                }

                return this.listeners;
            }
        }

        private PortalDirectEvents directEvents;

        /// <summary>
        /// Server-side DirectEvent Handlers
        /// </summary>
        [Meta]
        [ConfigOption("directEvents", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ViewStateMember]
        [Description("Server-side DirectEvent Handlers")]
        public PortalDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new PortalDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}
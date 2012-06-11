/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// The Draw Component is a surface in which sprites can be rendered. The Draw Component manages and holds a Surface instance: an interface that has an SVG or VML implementation depending on the browser capabilities and where Sprites can be appended.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:DrawComponent runat=\"server\"></{0}:DrawComponent>")]
    public partial class DrawComponent : AbstractDrawComponent
    {
        /// <summary>
        /// 
        /// </summary>
        public DrawComponent()
        {
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
                return "draw";
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
                return "Ext.draw.Component";
            }
        }

        private DrawComponentListeners listeners;

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
        public DrawComponentListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new DrawComponentListeners();
                }

                return this.listeners;
            }
        }

        private DrawComponentDirectEvents directEvents;

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
        public DrawComponentDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new DrawComponentDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}

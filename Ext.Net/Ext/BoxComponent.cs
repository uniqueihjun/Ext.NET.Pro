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

namespace Ext.Net
{
    /// <summary>
    /// Base Class for any visual Component that uses a box content Container.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:BoxComponent runat=\"server\" />")]
    [ToolboxBitmap(typeof(BoxComponent), "Build.ToolboxIcons.BoxComponent.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("Base Class for any visual Component that uses a box content Container.")]
    public partial class BoxComponent : BoxComponentBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BoxComponent() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "box";
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
                return "Ext.BoxComponent";
            }
        }

        private BoxComponentListeners listeners;

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
        public BoxComponentListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new BoxComponentListeners();
                }

                return this.listeners;
            }
        }


        private BoxComponentDirectEvents directEvents;

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
        public BoxComponentDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new BoxComponentDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}
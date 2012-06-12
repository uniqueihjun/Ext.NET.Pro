/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Base class for any Ext.BoxComponent that may contain other Components. Containers handle the basic behavior of containing items, namely adding, inserting and removing items.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:Container runat=\"server\"><Items></Items></{0}:Container>")]
    [ToolboxBitmap(typeof(Container), "Build.ToolboxIcons.Container.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("Base class for any Ext.BoxComponent that may contain other Components. Containers handle the basic behavior of containing items, namely adding, inserting and removing items.")]
    public partial class Container : ContainerBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Container() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "container";
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
                return "Ext.Container";
            }
        }

        private ContainerListeners listeners;

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
        public ContainerListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new ContainerListeners();
                }

                return this.listeners;
            }
        }

        private ContainerDirectEvents directEvents;

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
        public ContainerDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new ContainerDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}
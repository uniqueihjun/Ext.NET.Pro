/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary> 
    /// Base class for all Ext components. All subclasses of Component may participate in the automated Ext component lifecycle of creation, rendering and destruction which is provided by the Container class. Components may be added to a Container through the items config option at the time the Container is created, or they may be added dynamically via the add method.
    /// 
    /// The Component base class has built-in support for basic hide/show and enable/disable and size control behavior.
    /// 
    /// All Components are registered with the Ext.ComponentManager on construction so that they can be referenced at any time via Ext.getCmp, passing the id.
    /// 
    /// All user-developed visual widgets that are required to participate in automated lifecycle and size management should subclass Component.
    /// 
    /// See the Creating new UI controls chapter in [Component Guide][1] for details on how and to either extend or augment Ext JS base classes to create custom Components.
    /// 
    /// Every component has a specific xtype, which is its Ext-specific type name, along with methods for checking the xtype like getXType and isXType. See the [Component Guide][1] for more information on xtypes and the Component hierarchy.
    /// </summary>
    [Meta]
    [Description("Base Class for all Ext.Net Web Controls.")]
    public partial class Component : ComponentBase
    {
        /// <summary>
        /// 
        /// </summary>
        public Component() { }
        
        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "component";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string InstanceOf
        {
            get
            {
                return "Ext.Component";
            }
        }

        private AbstractComponentListeners listeners;

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
        public AbstractComponentListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new AbstractComponentListeners();
                }

                return this.listeners;
            }
        }


        private AbstractComponentDirectEvents directEvents;

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
        public AbstractComponentDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new AbstractComponentDirectEvents(this);
                }

                return this.directEvents;
            }
        }

        
    }
}
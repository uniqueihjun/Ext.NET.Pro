/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    /// 
    /// </summary>
    [Meta]
    [ToolboxBitmap(typeof(TriggerField), "Build.ToolboxIcons.TriggerField.bmp")]
    [DefaultProperty("Text")]
    [ValidationProperty("Text")]
    [ControlValueProperty("Text")]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [SupportsEventValidation]
    [Description("")]
    public partial class DropDownField : DropDownFieldBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DropDownField() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "netdropdown";
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
                return "Ext.net.DropDownField";
            }
        }

        private DropDownFieldListeners listeners;

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
        public DropDownFieldListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new DropDownFieldListeners();
                }

                return this.listeners;
            }
        }

        private DropDownFieldDirectEvents directEvents;

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
        public DropDownFieldDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new DropDownFieldDirectEvents();
                }

                return this.directEvents;
            }
        }
    }
}

/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Provides a convenient wrapper for TextFields that adds a clickable trigger button (looks like a combobox by default). The trigger has no default action, so you must assign a function to implement the trigger click handler by overriding onTriggerClick. You can create a Trigger field directly, as it renders exactly like a combobox for which you can provide a custom implementation.
    /// </summary>
    [Meta]
    [ToolboxBitmap(typeof(TriggerField), "Build.ToolboxIcons.TriggerField.bmp")]
    [DefaultProperty("Text")]
    [ValidationProperty("Text")]
    [ControlValueProperty("Text")]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [SupportsEventValidation]
    [Description("Provides a convenient wrapper for TextFields that adds a clickable trigger button (looks like a combobox by default).")]
    public partial class TriggerField : BaseTriggerField
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TriggerField() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "triggerfield";
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
                return "Ext.form.field.Trigger";
            }
        }
        
        private TriggerFieldListeners listeners;

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
        public TriggerFieldListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new TriggerFieldListeners();
                }

                return this.listeners;
            }
        }

        private TriggerFieldDirectEvents directEvents;

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
        public TriggerFieldDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new TriggerFieldDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}
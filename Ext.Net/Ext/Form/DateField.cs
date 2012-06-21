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
    /// Provides a date input field with a date picker dropdown and automatic date validation.
    ///
    /// This field recognizes and uses the JavaScript Date object as its main value type. In addition, it recognizes string values which are parsed according to the format and/or altFormats configs. These may be reconfigured to use date formats appropriate for the user's locale.
    ///
    /// The field may be limited to a certain range of dates by using the minValue, maxValue, disabledDays, and disabledDates config parameters. These configurations will be used both in the field's validation, and in the date picker dropdown by preventing invalid dates from being selected.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:DateField runat=\"server\" />")]
    [DefaultProperty("SelectedDate")]
    [DefaultEvent("SelectionChanged")]
    [ValidationProperty("SelectedDate")]
    [ControlValueProperty("SelectedDate")]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [SupportsEventValidation]
    [ToolboxBitmap(typeof(DateField), "Build.ToolboxIcons.DateField.bmp")]
    [Description("Provides a date input field with a DatePicker dropdown and automatic date validation.")]
    public partial class DateField : DateFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public DateField() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "datefield";
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
                return "Ext.form.field.Date";
            }
        }

        private DateFieldListeners listeners;

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
        public DateFieldListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new DateFieldListeners();
                }

                return this.listeners;
            }
        }

        private DateFieldDirectEvents directEvents;

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
        public DateFieldDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new DateFieldDirectEvents(this);
                }

                return this.directEvents;
            }
        }

        /// <summary>
        /// Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).
        /// </summary>
        [Description("Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).")]
        public event ComponentDirectEvent.DirectEventHandler DirectChange
        {
            add
            {
                this.DirectEvents.Change.Event += value;
            }
            remove
            {
                this.DirectEvents.Change.Event -= value;
            }
        }

        /// <summary>
        /// Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).
        /// </summary>
        [Description("Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).")]
        public event ComponentDirectEvent.DirectEventHandler DirectSelect
        {
            add
            {
                this.DirectEvents.Select.Event += value;
            }
            remove
            {
                this.DirectEvents.Select.Event -= value;
            }
        }
    }
}

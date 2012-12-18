/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A numeric text field that provides automatic keystroke filtering to disallow non-numeric characters, and numeric validation to limit the value to a range of valid numbers. The range of acceptable number values can be controlled by setting the minValue and maxValue configs, and fractional decimals can be disallowed by setting allowDecimals to false.
    ///
    /// By default, the number field is also rendered with a set of up/down spinner buttons and has up/down arrow key and mouse wheel event listeners attached for incrementing/decrementing the value by the step value. To hide the spinner buttons set hideTrigger:true; to disable the arrow key and mouse wheel handlers set keyNavEnabled:false and mouseWheelEnabled:false. 
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:NumberField runat=\"server\" />")]
    [DefaultProperty("Number")]
    [DefaultEvent("TextChanged")]
    [ValidationProperty("Number")]
    [ControlValueProperty("Number")]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [SupportsEventValidation]
    [ToolboxBitmap(typeof(NumberField), "Build.ToolboxIcons.NumberField.bmp")]
    [Description("A numeric text field that provides automatic keystroke filtering to disallow non-numeric characters, and numeric validation to limit the value to a range of valid numbers. The range of acceptable number values can be controlled by setting the minValue and maxValue configs, and fractional decimals can be disallowed by setting allowDecimals to false.")]
    public partial class NumberField : NumberFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        public NumberField() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "numberfield";
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
                return "Ext.form.field.Number";
            }
        }

        private NumberFieldListeners listeners;

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
        public NumberFieldListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new NumberFieldListeners();
                }

                return this.listeners;
            }
        }

        private NumberFieldDirectEvents directEvents;

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
        public NumberFieldDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new NumberFieldDirectEvents(this);
                }

                return this.directEvents;
            }
        }


        /*  DirectEvent Handler
            -----------------------------------------------------------------------------------------------*/
        
        static NumberField()
        {
            DirectEventChange = new object();
        }

        private static readonly object DirectEventChange;

        /// <summary>
        /// Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).
        /// </summary>
        [Description("Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).")]
        public event ComponentDirectEvent.DirectEventHandler DirectChange
        {
            add
            {
                this.CheckForceId();
				this.DirectEvents.Change.Event += value;
            }
            remove
            {
                this.DirectEvents.Change.Event -= value;
            }
        }
    }
}
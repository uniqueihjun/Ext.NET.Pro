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
    /// A basic text field. Can be used as a direct replacement for traditional text inputs, or as the base class for more sophisticated input controls (like Ext.form.field.TextArea and Ext.form.field.ComboBox). Has support for empty-field placeholder values (see emptyText).
    /// 
    /// Validation
    /// 
    /// The Text field has a useful set of validations built in:
    /// 
    /// allowBlank for making the field required
    /// minLength for requiring a minimum value length
    /// maxLength for setting a maximum value length (with enforceMaxLength to add it as the maxlength attribute on the input element)
    /// regex to specify a custom regular expression for validation
    /// In addition, custom validations may be added:
    /// 
    /// vtype specifies a virtual type implementation from Ext.form.field.VTypes which can contain custom validation logic
    /// validator allows a custom arbitrary function to be called during validation
    /// The details around how and when each of these validation options get used are described in the documentation for getErrors.
    /// 
    /// By default, the field value is checked for validity immediately while the user is typing in the field. This can be controlled with the validateOnChange, checkChangeEvents, and checkChangeBuffer configurations. Also see the details on Form Validation in the Ext.form.Panel class documentation.
    /// 
    /// Masking and Character Stripping
    /// 
    /// Text fields can be configured with custom regular expressions to be applied to entered values before validation: see maskRe and stripCharsRe for details.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:TextField runat=\"server\" />")]
    [DefaultProperty("Text")]
    [DefaultEvent("TextChanged")]
    [ValidationProperty("Text")]
    [ControlValueProperty("Text")]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [SupportsEventValidation]
    [ToolboxBitmap(typeof(TextField), "Build.ToolboxIcons.TextField.bmp")]
    [Description("Basic text field. Can be used as a direct replacement for traditional text inputs, or as the base class for more sophisticated input controls (like Ext.form.TextArea and Ext.form.ComboBox).")]
    public partial class TextField : TextFieldBase, IPostBackEventHandler 
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public TextField() { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public TextField(string text) 
        {
            this.Text = text;
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
                return "textfield";
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
                return "Ext.form.field.Text";
            }
        }

        private TextFieldListeners listeners;

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
        public TextFieldListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new TextFieldListeners();
                }

                return this.listeners;
            }
        }

        private TextFieldDirectEvents directEvents;

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
        public TextFieldDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new TextFieldDirectEvents(this);
                }

                return this.directEvents;
            }
        }


        /*  Lifecycle
            -----------------------------------------------------------------------------------------------*/

        void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
        {
            this.RaisePostDataChangedEvent();
        }


        /*  DirectEvent Handler
            -----------------------------------------------------------------------------------------------*/
        
        static TextField()
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
                this.DirectEvents.Change.Event += value;
            }
            remove
            {
                this.DirectEvents.Change.Event -= value;
            }
        }
    }
}
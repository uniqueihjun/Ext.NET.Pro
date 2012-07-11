/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// A field with a pair of up/down spinner buttons. This class is not normally instantiated directly, instead it is subclassed and the onSpinUp and onSpinDown methods are implemented to handle when the buttons are clicked. A good example of this is the Ext.form.field.Number field which uses the spinner to increment and decrement the field's value by its step config value.
    /// </summary>
    [Meta]
    public abstract partial class SpinnerFieldBase : TriggerFieldBase
    {
        /// <summary>
        /// Specifies whether the up and down arrow keys should trigger spinning up and down. Defaults to true.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. SpinnerField")]
        [DefaultValue(true)]
        [Description("Specifies whether the up and down arrow keys should trigger spinning up and down. Defaults to true.")]
        public virtual bool KeyNavEnabled
        {
            get
            {
                return this.State.Get<bool>("KeyNavEnabled", true);
            }
            set
            {
                this.State.Set("KeyNavEnabled", value);
            }
        }

        /// <summary>
        /// Specifies whether the mouse wheel should trigger spinning up and down while the field has focus. Defaults to true.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. SpinnerField")]
        [DefaultValue(true)]
        [Description("Specifies whether the mouse wheel should trigger spinning up and down while the field has focus. Defaults to true.")]
        public virtual bool MouseWheelEnabled
        {
            get
            {
                return this.State.Get<bool>("MouseWheelEnabled", true);
            }
            set
            {
                this.State.Set("MouseWheelEnabled", value);
            }
        }

        /// <summary>
        /// Whether a click repeater should be attached to the spinner buttons. Defaults to true.
        /// </summary>
        [ConfigOption]
        [Category("7. SpinnerField")]
        [DefaultValue(true)]
        [Description("Whether a click repeater should be attached to the spinner buttons. Defaults to true.")]
        public override bool RepeatTriggerClick
        {
            get
            {
                return this.State.Get<bool>("RepeatTriggerClick", true);
            }
            set
            {
                this.State.Set("RepeatTriggerClick", value);
            }
        }

        /// <summary>
        /// Specifies whether the down spinner button is enabled. Defaults to true. To change this after the component is created, use the setSpinDownEnabled method.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DirectEventUpdate(MethodName = "SetSpinDownEnabled")]
        [Category("7. SpinnerField")]
        [DefaultValue(true)]
        [Description("Specifies whether the down spinner button is enabled. Defaults to true. To change this after the component is created, use the setSpinDownEnabled method.")]
        public virtual bool SpinDownEnabled
        {
            get
            {
                return this.State.Get<bool>("SpinDownEnabled", true);
            }
            set
            {
                this.State.Set("SpinDownEnabled", value);
            }
        }

        /// <summary>
        /// Specifies whether the up spinner button is enabled. Defaults to true. To change this after the component is created, use the setSpinUpEnabled method.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DirectEventUpdate(MethodName = "SetSpinUpEnabled")]
        [Category("7. SpinnerField")]
        [DefaultValue(true)]
        [Description("Specifies whether the up spinner button is enabled. Defaults to true. To change this after the component is created, use the setSpinUpEnabled method.")]
        public virtual bool SpinUpEnabled
        {
            get
            {
                return this.State.Get<bool>("SpinUpEnabled", true);
            }
            set
            {
                this.State.Set("SpinUpEnabled", value);
            }
        }

        /// <summary>
        /// Sets whether the spinner down button is enabled.
        /// </summary>
        /// <param name="enabled">true to enable the button, false to disable it.</param>
        [Meta]
        public virtual void SetSpinDownEnabled(bool enabled)
        {
            this.Call("setSpinDownEnabled", enabled);
        }

        /// <summary>
        /// Sets whether the spinner up button is enabled.
        /// </summary>
        /// <param name="enabled">true to enable the button, false to disable it.</param>
        [Meta]
        public virtual void SetSpinUpEnabled(bool enabled)
        {
            this.Call("setSpinUpEnabled", enabled);
        }

        /// <summary>
        /// Triggers the spinner to step down; fires the spin and spindown events and calls the onSpinDown method. Does nothing if the field is disabled or if spinDownEnabled is false.
        /// </summary>
        [Meta]
        public virtual void SpinDown()
        {
            this.Call("spinDown");
        }

        /// <summary>
        /// Triggers the spinner to step up; fires the spin and spinup events and calls the onSpinUp method. Does nothing if the field is disabled or if spinUpEnabled is false.
        /// </summary>
        [Meta]
        public virtual void SpinUp()
        {
            this.Call("spinUp");
        }
    }
}

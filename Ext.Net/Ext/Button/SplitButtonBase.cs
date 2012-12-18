/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public abstract partial class SplitButtonBase : ButtonBase
    {
        /// <summary>
        /// A function called when the arrow button is clicked (can be used instead of click event).
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("6. SplitButton")]
        [DefaultValue("")]
        [DirectEventUpdate(MethodName="SetArrowHandler")]
        [Description("A function called when the arrow button is clicked (can be used instead of click event).")]
        public virtual string ArrowHandler
        {
            get
            {
                return this.State.Get<string>("ArrowHandler", "");
            }
            set
            {
                this.State.Set("ArrowHandler", value);
            }
        }

        /// <summary>
        /// The title attribute of the arrow.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Localizable(true)]
        [Category("6. SplitButton")]
        [DefaultValue("")]
        [Description("The title attribute of the arrow.")]
        public virtual string ArrowTooltip
        {
            get
            {
                return this.State.Get<string>("ArrowTooltip", "");
            }
            set
            {
                this.State.Set("ArrowTooltip", value);
            }
        }

        /// <summary>
        /// Sets this button's arrow click handler.
        /// </summary>
        /// <param name="function">The function to call when the arrow is clicked</param>
        protected virtual void SetArrowHandler(string function)
        {
            this.Call("setArrowHandler", new JRawValue(function));
        }

        /// <summary>
        /// Assigns this button's click handler
        /// </summary>
        /// <param name="function">The function to call when the arrow is clicked</param>
        /// <param name="scope">Scope for the function passed above</param>
        public virtual void SetArrowHandler(string function, string scope)
        {
            this.Call("setArrowHandler", new JRawValue(function), new JRawValue(scope));
        }

        /// <summary>
        /// Assigns this button's click handler
        /// </summary>
        /// <param name="function">The function to call when the arrow is clicked</param>
        /// <param name="scope">Scope for the function passed above</param>
        public virtual void SetArrowHandler(JFunction function, string scope)
        {
            this.Call("setArrowHandler", new JRawValue(function.ToScript()), new JRawValue(scope));
        }

        /// <summary>
        /// Assigns this button's click handler
        /// </summary>
        /// <param name="function">The function to call when the arrow is clicked</param>
        public virtual void SetArrowHandler(JFunction function)
        {
            this.Call("setArrowHandler", new JRawValue(function.ToScript()));
        }
    }
}
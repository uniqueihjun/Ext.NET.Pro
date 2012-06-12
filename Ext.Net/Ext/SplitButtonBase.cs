/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
        [Description("A function called when the arrow button is clicked (can be used instead of click event).")]
        public virtual string ArrowHandler
        {
            get
            {
                return (string)this.ViewState["ArrowHandler"] ?? "";
            }
            set
            {
                this.ViewState["ArrowHandler"] = value;
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
                return (string)this.ViewState["ArrowTooltip"] ?? "";
            }
            set
            {
                this.ViewState["ArrowTooltip"] = value;
            }
        }
    }
}
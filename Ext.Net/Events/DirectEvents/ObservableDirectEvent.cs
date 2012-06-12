/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>    
    public partial class ObservableDirectEvent : BaseDirectEvent
    {
        /// <summary>
        /// After handler with params: el, extraParams. Called immediately after DirectEvent has been requested.
        /// </summary>
        [ConfigOption(typeof(DirectEventHandlerJsonConverter))]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("After handler with params: el, extraParams. Called immediately after DirectEvent has been requested.")]
        public virtual string After
        {
            get
            {
                return (string)this.ViewState["After"] ?? "";
            }
            set
            {
                this.ViewState["After"] = value;
            }
        }

        /// <summary>
        /// Before handler with params: el, type, action, extraParams
        /// </summary>
        [ConfigOption(typeof(DirectEventHandlerJsonConverter))]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Before handler with params: el, type, action, extraParams")]
        public virtual string Before
        {
            get
            {
                return (string)this.ViewState["Before"] ?? "";
            }
            set
            {
                this.ViewState["Before"] = value;
            }
        }

        /// <summary>
        /// Success handler with params: response, result, control, type, action, extraParams
        /// </summary>
        [DefaultValue("")]
        [ConfigOption("userSuccess", typeof(DirectEventHandlerJsonConverter))]
        [NotifyParentProperty(true)]
        [Description("Success handler with params: response, result, el, type, action, extraParams")]
        public virtual string Success
        {
            get
            {
                return (string)this.ViewState["Success"] ?? "";
            }
            set
            {
                this.ViewState["Success"] = value;
            }
        }

        /// <summary>
        /// Failure handler with params: response, result, control, type, action, extraParams
        /// </summary>
        [DefaultValue("")]
        [ConfigOption("userFailure", typeof(DirectEventHandlerJsonConverter))]
        [NotifyParentProperty(true)]
        [Description("Failure handler with params: response, result, control, type, action, extraParams")]
        public virtual string Failure
        {
            get
            {
                return (string)this.ViewState["Failure"] ?? "";
            }
            set
            {
                this.ViewState["Failure"] = value;
            }
        }

        /// <summary>
        /// Failure handler with params: success, response, result, control, type, action, extraParams
        /// </summary>
        [DefaultValue("")]
        [ConfigOption("userComplete", typeof(DirectEventHandlerJsonConverter))]
        [NotifyParentProperty(true)]
        [Description("Failure handler with params: success, response, result, control, type, action, extraParams")]
        public virtual string Complete
        {
            get
            {
                return (string)this.ViewState["Complete"] ?? "";
            }
            set
            {
                this.ViewState["Complete"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual void Clear()
        {
            this.Before = this.Success = this.Failure = "";
            this.ShowWarningOnFailure = true;
        }
    }
}
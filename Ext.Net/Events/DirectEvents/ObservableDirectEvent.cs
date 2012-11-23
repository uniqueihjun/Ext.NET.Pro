/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>    
    public partial class ObservableDirectEvent : BaseDirectEvent
    {
        /// <summary>
        /// The .After handler is called immediately after the DirectEvent is fired and before the response is returned from the server.
        /// After handler is called with params: el, extraParams.
        /// </summary>
        [ConfigOption(typeof(DirectEventHandlerJsonConverter))]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("After handler with params: el, extraParams.")]
        public virtual string After
        {
            get
            {
                return this.State.Get<string>("After", "");
            }
            set
            {
                this.State.Set("After", value);
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
                return this.State.Get<string>("Before", "");
            }
            set
            {
                this.State.Set("Before", value);
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
                return this.State.Get<string>("Success", "");
            }
            set
            {
                this.State.Set("Success", value);
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
                return this.State.Get<string>("Failure", "");
            }
            set
            {
                this.State.Set("Failure", value);
            }
        }

        /// <summary>
        /// Complete handler with params: success, response, result, control, type, action, extraParams
        /// </summary>
        [DefaultValue("")]
        [ConfigOption("userComplete", typeof(DirectEventHandlerJsonConverter))]
        [NotifyParentProperty(true)]
        [Description("Complete handler with params: success, response, result, control, type, action, extraParams")]
        public virtual string Complete
        {
            get
            {
                return this.State.Get<string>("Complete", "");
            }
            set
            {
                this.State.Set("Complete", value);
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
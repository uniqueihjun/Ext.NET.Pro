/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(DirectEventConverter))]
    [ToolboxItem(false)]
    [Description("")]
    public partial class DirectEvent : ComponentDirectEvent
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DirectEvent() { }

        //target and handler are required properties, so must be initialized always
        private DirectEvent(string target, DirectEventHandler handler)
        {
            this.Target = target;
            this.Event += handler;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DirectEvent(string target, HtmlEvent htmlEvent, DirectEventHandler handler) : this(target, handler)
        {
            this.HtmlEvent = htmlEvent;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DirectEvent(string target, string eventName, DirectEventHandler handler) : this(target, handler)
        {
            this.EventName = eventName;
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
        public string EventID
        {
            get
            {
                return string.Concat(this.Target.GetHashCode(), "_", this.EventName.IsEmpty() ? "click" : this.EventName);
            }
        }

        /// <summary>
        /// The target to attach this DirectEvent to. The target can be an ID, an ID token (#{Button1}), or a Select token (${div.box}).
        /// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The target to attach this DirectEvent to. The target can be an ID, an ID token (#{Button1}), or a Select token (${div.box}).")]
        public string Target
        {
            get
            {
                return this.State.Get<string>("Target", "");
            }
            set
            {
                this.State.Set("Target", value);
            }
        }

        /// <summary>
        /// The name of the server-side Event to fire during the DirectEvent.
        /// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The name of the server-side Event to fire during the DirectEvent.")]
        public string EventName
        {
            get
            {
                string o = this.ViewState["EventName"] as string;

                if (o.IsEmpty() && HttpContext.Current != null)
                {
                    return this.HtmlEvent.ToString().ToLowerInvariant();
                }
                
                return o ?? "";
            }
            set
            {
                this.State.Set("EventName", value);
            }
        }

        /// <summary>
        /// The html event type to attach this DirectEvent to. Example 'click'.
        /// </summary>
        [DefaultValue(HtmlEvent.Click)]
        [NotifyParentProperty(true)]
        [Description("The html event type to attach this DirectEvent to. Example 'click'.")]
        public HtmlEvent HtmlEvent
        {
            get
            {
                object o = this.ViewState["HtmlEvent"];
                return o != null ? (HtmlEvent)o : HtmlEvent.Click;
            }
            set
            {
                this.State.Set("HtmlEvent", value);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class DirectEventCollection : BaseItemCollection<DirectEvent> { }
}

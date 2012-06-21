/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    [DefaultProperty("Handler")]
    [TypeConverter(typeof(ListenerConverter))]
    [ToolboxItem(false)]
    [Description("")]
    public partial class Listener : ComponentListener
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Listener() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Listener(string handler)
        {
            this.Handler = handler;
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
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
		/// 
		/// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
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
		/// 
		/// </summary>
        [DefaultValue(HtmlEvent.Click)]
        [NotifyParentProperty(true)]
		[Description("")]
        public HtmlEvent HtmlEvent
        {
            get
            {
                object o = this.ViewState["PredefinedEvent"];
                return o != null ? (HtmlEvent)o : HtmlEvent.Click;
            }
            set
            {
                this.State.Set("PredefinedEvent", value);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ListenerCollection : BaseItemCollection<Listener> { }
}
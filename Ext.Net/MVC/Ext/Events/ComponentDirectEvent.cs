/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.Mvc;
using System.Web.Routing;

using Ext.Net.Utilities;

namespace Ext.Net
{
    public partial class ComponentDirectEvent : ObservableDirectEvent
    {
        /// <summary>
        /// The default controller action to be used for requests to the server. (defaults to '')
        /// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The default controller action to be used for requests to the server. (defaults to '')")]
        public virtual string Action
        {
            get
            {
                return this.State.Get<string>("Action", "");
            }
            set
            {
                this.State.Set("Action", value);
                this.MarkAsDirty();
            }
        }

        /// <summary>
        /// The default URL to be used for requests to the server if DirectEventType.Request. (defaults to '')
        /// </summary>
        [NotifyParentProperty(true)]
        [DefaultValue("")]
        [Description("The default URL to be used for requests to the server if DirectEventType.Request. (defaults to '')")]
        protected override string UrlProxy
        {
            get
            {
                if (this.Action.IsNotEmpty() && this.Parent != null && this.Parent.Parent != null)
                {
                    ViewContext context = this.Parent.Parent.ViewContext ?? (ExtNet.Builder.HtmlHelper != null ? ExtNet.Builder.HtmlHelper.ViewContext : null);
                    string[] parts = this.Action.Split('|');
                    UrlHelper url = context != null ? new UrlHelper(context.RequestContext, RouteTable.Routes) : null;

                    return url != null ? (parts.Length > 1 ? url.Action(parts[0], parts[1]) : url.Action(parts[0])) : this.Action;
                }

                return base.UrlProxy;
            }
        }
    }
}

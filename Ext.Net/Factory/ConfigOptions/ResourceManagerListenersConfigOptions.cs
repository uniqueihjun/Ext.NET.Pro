/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    public partial class ResourceManagerListeners
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("windowUnload", new ConfigOption("windowUnload", new SerializationOptions("beforeunload", typeof(ListenerJsonConverter)), null, this.WindowUnload ));
                list.Add("windowScroll", new ConfigOption("windowScroll", new SerializationOptions("scroll", typeof(ListenerJsonConverter)), null, this.WindowScroll ));
                list.Add("beforeAjaxRequest", new ConfigOption("beforeAjaxRequest", new SerializationOptions("beforeajaxrequest", typeof(ListenerJsonConverter)), null, this.BeforeAjaxRequest ));
                list.Add("ajaxRequestComplete", new ConfigOption("ajaxRequestComplete", new SerializationOptions("ajaxrequestcomplete", typeof(ListenerJsonConverter)), null, this.AjaxRequestComplete ));
                list.Add("ajaxRequestException", new ConfigOption("ajaxRequestException", new SerializationOptions("ajaxrequestexception", typeof(ListenerJsonConverter)), null, this.AjaxRequestException ));

                return list;
            }
        }
    }
}
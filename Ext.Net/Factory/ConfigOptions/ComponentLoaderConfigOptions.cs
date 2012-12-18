/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    /// <summary>
    /// 
    /// </summary>
    public partial class ComponentLoader
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
                
                list.Add("disableCaching", new ConfigOption("disableCaching", null, true, this.DisableCaching ));
                list.Add("disableCachingParam", new ConfigOption("disableCachingParam", null, "_dc", this.DisableCachingParam ));
                list.Add("ajaxOptions", new ConfigOption("ajaxOptions", new SerializationOptions(JsonMode.Object), null, this.AjaxOptions ));
                list.Add("passParentSize", new ConfigOption("passParentSize", null, false, this.PassParentSize ));
                list.Add("triggerEvent", new ConfigOption("triggerEvent", null, "", this.TriggerEvent ));
                list.Add("triggerControl", new ConfigOption("triggerControl", null, "", this.TriggerControl ));
                list.Add("reloadOnEvent", new ConfigOption("reloadOnEvent", null, false, this.ReloadOnEvent ));
                list.Add("removeD", new ConfigOption("removeD", null, false, this.RemoveD ));
                list.Add("monitorComplete", new ConfigOption("monitorComplete", null, false, this.MonitorComplete ));
                list.Add("callbackProxy", new ConfigOption("callbackProxy", new SerializationOptions("callback", JsonMode.Raw), "", this.CallbackProxy ));
                list.Add("autoLoad", new ConfigOption("autoLoad", null, true, this.AutoLoad ));
                list.Add("baseParams", new ConfigOption("baseParams", new SerializationOptions(JsonMode.ArrayToObject), null, this.BaseParams ));
                list.Add("failureProxy", new ConfigOption("failureProxy", new SerializationOptions("failure", JsonMode.Raw), "", this.FailureProxy ));
                list.Add("loadMask", new ConfigOption("loadMask", new SerializationOptions("loadMask", typeof(LoadMaskJsonConverter)), null, this.LoadMask ));
                list.Add("paramsProxy", new ConfigOption("paramsProxy", new SerializationOptions("paramsFn",JsonMode.Raw), "", this.ParamsProxy ));
                list.Add("scripts", new ConfigOption("scripts", null, false, this.Scripts ));
                list.Add("removeAll", new ConfigOption("removeAll", null, false, this.RemoveAll ));
                list.Add("rendererProxy", new ConfigOption("rendererProxy", new SerializationOptions("renderer", JsonMode.Raw), "", this.RendererProxy ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "", this.Scope ));
                list.Add("successProxy", new ConfigOption("successProxy", new SerializationOptions("success", JsonMode.Raw), "", this.SuccessProxy ));
                list.Add("target", new ConfigOption("target", null, "", this.Target ));
                list.Add("url", new ConfigOption("url", new SerializationOptions(JsonMode.Url), "", this.Url ));
                list.Add("directMethod", new ConfigOption("directMethod", null, "", this.DirectMethod ));
                list.Add("showWarningOnFailure", new ConfigOption("showWarningOnFailure", null, true, this.ShowWarningOnFailure ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));

                return list;
            }
        }
    }
}
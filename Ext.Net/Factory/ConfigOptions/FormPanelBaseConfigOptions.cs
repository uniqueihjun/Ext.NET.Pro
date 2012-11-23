/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public abstract partial class FormPanelBase
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
                
                list.Add("formID", new ConfigOption("formID", new SerializationOptions("formId"), "", this.FormID ));
                list.Add("itemCls", new ConfigOption("itemCls", null, "", this.ItemCls ));
                list.Add("monitorPoll", new ConfigOption("monitorPoll", null, 200, this.MonitorPoll ));
                list.Add("monitorValid", new ConfigOption("monitorValid", null, false, this.MonitorValid ));
                list.Add("renderFormElement", new ConfigOption("renderFormElement", new SerializationOptions("renderFormElement"), true, this.RenderFormElement ));
                list.Add("errorReader", new ConfigOption("errorReader", new SerializationOptions("reader>Reader"), null, this.ErrorReader ));
                list.Add("fileUpload", new ConfigOption("fileUpload", null, false, this.FileUpload ));
                list.Add("methodProxy", new ConfigOption("methodProxy", new SerializationOptions("method"), HttpMethod.Default, this.MethodProxy ));
                list.Add("reader", new ConfigOption("reader", new SerializationOptions("reader>Reader"), null, this.Reader ));
                list.Add("standardSubmit", new ConfigOption("standardSubmit", null, false, this.StandardSubmit ));
                list.Add("timeout", new ConfigOption("timeout", null, 30, this.Timeout ));
                list.Add("trackResetOnLoad", new ConfigOption("trackResetOnLoad", null, false, this.TrackResetOnLoad ));
                list.Add("urlProxy", new ConfigOption("urlProxy", new SerializationOptions("url"), "", this.UrlProxy ));
                list.Add("trackLabels", new ConfigOption("trackLabels", null, true, this.TrackLabels ));
                list.Add("layoutConfigProxy", new ConfigOption("layoutConfigProxy", new SerializationOptions(JsonMode.Object), null, this.LayoutConfigProxy ));

                return list;
            }
        }
    }
}
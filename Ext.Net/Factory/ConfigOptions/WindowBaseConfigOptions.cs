/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public abstract partial class WindowBase
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
                
                list.Add("frame", new ConfigOption("frame", null, true, this.Frame ));
                list.Add("animateTarget", new ConfigOption("animateTarget", null, "", this.AnimateTarget ));
                list.Add("closable", new ConfigOption("closable", null, true, this.Closable ));
                list.Add("closeAction", new ConfigOption("closeAction", new SerializationOptions(JsonMode.ToLower), CloseAction.Hide, this.CloseAction ));
                list.Add("constrain", new ConfigOption("constrain", null, false, this.Constrain ));
                list.Add("constrainHeader", new ConfigOption("constrainHeader", null, false, this.ConstrainHeader ));
                list.Add("defaultButton", new ConfigOption("defaultButton", null, "", this.DefaultButton ));
                list.Add("defaultRenderTo", new ConfigOption("defaultRenderTo", new SerializationOptions(JsonMode.ToLower), DefaultRenderTo.Body, this.DefaultRenderTo ));
                list.Add("draggable", new ConfigOption("draggable", null, true, this.Draggable ));
                list.Add("expandOnShowProxy", new ConfigOption("expandOnShowProxy", new SerializationOptions("expandOnShow"), true, this.ExpandOnShowProxy ));
                list.Add("hiddenProxy", new ConfigOption("hiddenProxy", new SerializationOptions("hidden"), true, this.HiddenProxy ));
                list.Add("maximizable", new ConfigOption("maximizable", null, false, this.Maximizable ));
                list.Add("maximized", new ConfigOption("maximized", null, false, this.Maximized ));
                list.Add("height", new ConfigOption("height", null, Unit.Empty, this.Height ));
                list.Add("minHeight", new ConfigOption("minHeight", null, Unit.Pixel(100), this.MinHeight ));
                list.Add("width", new ConfigOption("width", null, Unit.Empty, this.Width ));
                list.Add("minWidth", new ConfigOption("minWidth", null, Unit.Pixel(200), this.MinWidth ));
                list.Add("minimizable", new ConfigOption("minimizable", null, false, this.Minimizable ));
                list.Add("modal", new ConfigOption("modal", null, false, this.Modal ));
                list.Add("onEsc", new ConfigOption("onEsc", new SerializationOptions(JsonMode.Raw), "Ext.emptyFn", this.OnEsc ));
                list.Add("plain", new ConfigOption("plain", null, false, this.Plain ));
                list.Add("resizable", new ConfigOption("resizable", null, true, this.Resizable ));
                list.Add("resizeHandles", new ConfigOption("resizeHandles", null, "all", this.ResizeHandles ));
                list.Add("initCenterProxy", new ConfigOption("initCenterProxy", new SerializationOptions("initCenter"), true, this.InitCenterProxy ));
                list.Add("renderToProxy", new ConfigOption("renderToProxy", new SerializationOptions("renderTo"), "", this.RenderToProxy ));

                return list;
            }
        }
    }
}
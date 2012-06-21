/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public abstract partial class AbstractWindow
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
                
                list.Add("animateTarget", new ConfigOption("animateTarget", null, "", this.AnimateTarget ));
                list.Add("closable", new ConfigOption("closable", null, true, this.Closable ));
                list.Add("closeAction", new ConfigOption("closeAction", new SerializationOptions(JsonMode.ToLower), CloseAction.Hide, this.CloseAction ));
                list.Add("constrain", new ConfigOption("constrain", null, false, this.Constrain ));
                list.Add("constrainHeader", new ConfigOption("constrainHeader", null, false, this.ConstrainHeader ));
                list.Add("constrainToElement", new ConfigOption("constrainToElement", new SerializationOptions("constrainTo"), "", this.ConstrainToElement ));
                list.Add("constrainToRegionProxy", new ConfigOption("constrainToRegionProxy", new SerializationOptions("constrainTo", JsonMode.Raw), null, this.ConstrainToRegionProxy ));
                list.Add("defaultFocusProxy", new ConfigOption("defaultFocusProxy", new SerializationOptions("defaultFocus", JsonMode.Raw), "", this.DefaultFocusProxy ));
                list.Add("defaultRenderTo", new ConfigOption("defaultRenderTo", new SerializationOptions(JsonMode.ToLower), DefaultRenderTo.Body, this.DefaultRenderTo ));
                list.Add("draggableProxy", new ConfigOption("draggableProxy", new SerializationOptions("draggable"), true, this.DraggableProxy ));
                list.Add("expandOnShowProxy", new ConfigOption("expandOnShowProxy", new SerializationOptions("expandOnShow"), true, this.ExpandOnShowProxy ));
                list.Add("hidden", new ConfigOption("hidden", null, true, this.Hidden ));
                list.Add("hideMode", new ConfigOption("hideMode", new SerializationOptions(JsonMode.ToLower), HideMode.Offsets, this.HideMode ));
                list.Add("maximizable", new ConfigOption("maximizable", null, null, this.Maximizable ));
                list.Add("maximized", new ConfigOption("maximized", null, false, this.Maximized ));
                list.Add("minimizable", new ConfigOption("minimizable", null, null, this.Minimizable ));
                list.Add("modal", new ConfigOption("modal", null, false, this.Modal ));
                list.Add("onEsc", new ConfigOption("onEsc", new SerializationOptions(JsonMode.Raw), "Ext.emptyFn", this.OnEsc ));
                list.Add("plain", new ConfigOption("plain", null, false, this.Plain ));
                list.Add("resizableProxy", new ConfigOption("resizableProxy", new SerializationOptions("resizable"), true, this.ResizableProxy ));
                list.Add("width", new ConfigOption("width", null, Unit.Empty, this.Width ));
                list.Add("height", new ConfigOption("height", null, Unit.Empty, this.Height ));
                list.Add("autoRender", new ConfigOption("autoRender", null, true, this.AutoRender ));
                list.Add("renderToProxy", new ConfigOption("renderToProxy", new SerializationOptions("renderTo"), "", this.RenderToProxy ));

                return list;
            }
        }
    }
}
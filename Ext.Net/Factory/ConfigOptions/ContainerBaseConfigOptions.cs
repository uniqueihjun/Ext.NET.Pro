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
    public abstract partial class ContainerBase
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
                
                list.Add("activeItem", new ConfigOption("activeItem", null, "", this.ActiveItem ));
                list.Add("activeIndex", new ConfigOption("activeIndex", new SerializationOptions("activeItem"), -1, this.ActiveIndex ));
                list.Add("autoDestroy", new ConfigOption("autoDestroy", null, true, this.AutoDestroy ));
                list.Add("autoDoLayout", new ConfigOption("autoDoLayout", null, false, this.AutoDoLayout ));
                list.Add("bufferResize", new ConfigOption("bufferResize", null, 50, this.BufferResize ));
                list.Add("defaultTypeProxy", new ConfigOption("defaultTypeProxy", new SerializationOptions("defaultType"), "panel", this.DefaultTypeProxy ));
                list.Add("defaults", new ConfigOption("defaults", new SerializationOptions(JsonMode.ArrayToObject), null, this.Defaults ));
                list.Add("hideBorders", new ConfigOption("hideBorders", null, false, this.HideBorders ));
                list.Add("monitorResize", new ConfigOption("monitorResize", null, false, this.MonitorResize ));
                list.Add("forceLayout", new ConfigOption("forceLayout", null, false, this.ForceLayout ));
                list.Add("itemsProxy", new ConfigOption("itemsProxy", new SerializationOptions("items", typeof(ItemCollectionJsonConverter)), null, this.ItemsProxy ));
                list.Add("layoutConfig", new ConfigOption("layoutConfig", new SerializationOptions("layoutConfig>Primary"), null, this.LayoutConfig ));
                list.Add("layoutProxy", new ConfigOption("layoutProxy", new SerializationOptions("layout"), "", this.LayoutProxy ));
                list.Add("layoutControl", new ConfigOption("layoutControl", new SerializationOptions(JsonMode.UnrollObject), null, this.LayoutControl ));

                return list;
            }
        }
    }
}
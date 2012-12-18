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
    public abstract partial class AbstractContainer
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
                
                list.Add("anchorSizeProxy", new ConfigOption("anchorSizeProxy", new SerializationOptions("anchorSize", JsonMode.Raw), "", this.AnchorSizeProxy ));
                list.Add("activeItem", new ConfigOption("activeItem", null, "", this.ActiveItem ));
                list.Add("activeIndex", new ConfigOption("activeIndex", new SerializationOptions("activeItem"), -1, this.ActiveIndex ));
                list.Add("autoDestroy", new ConfigOption("autoDestroy", null, true, this.AutoDestroy ));
                list.Add("autoDoLayout", new ConfigOption("autoDoLayout", null, false, this.AutoDoLayout ));
                list.Add("bubbleEvents", new ConfigOption("bubbleEvents", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.BubbleEvents ));
                list.Add("defaultType", new ConfigOption("defaultType", null, "panel", this.DefaultType ));
                list.Add("defaultButtonProxy", new ConfigOption("defaultButtonProxy", new SerializationOptions("defaultButton"), "", this.DefaultButtonProxy ));
                list.Add("defaults", new ConfigOption("defaults", new SerializationOptions(JsonMode.ArrayToObject), null, this.Defaults ));
                list.Add("detachOnRemove", new ConfigOption("detachOnRemove", null, true, this.DetachOnRemove ));
                list.Add("suspendLayout", new ConfigOption("suspendLayout", null, false, this.SuspendLayout ));
                list.Add("itemsProxy", new ConfigOption("itemsProxy", new SerializationOptions("items", typeof(ItemCollectionJsonConverter)), null, this.ItemsProxy ));
                list.Add("itemsToRenderProxy", new ConfigOption("itemsToRenderProxy", new SerializationOptions("items", JsonMode.Raw), "", this.ItemsToRenderProxy ));
                list.Add("tabMenu", new ConfigOption("tabMenu", new SerializationOptions("tabMenu", typeof(SingleItemCollectionJsonConverter)), null, this.TabMenu ));
                list.Add("tabMenuHidden", new ConfigOption("tabMenuHidden", null, false, this.TabMenuHidden ));
                list.Add("layoutConfig", new ConfigOption("layoutConfig", new SerializationOptions("layout>Primary"), null, this.LayoutConfig ));
                list.Add("layoutProxy", new ConfigOption("layoutProxy", new SerializationOptions("layout"), "", this.LayoutProxy ));

                return list;
            }
        }
    }
}
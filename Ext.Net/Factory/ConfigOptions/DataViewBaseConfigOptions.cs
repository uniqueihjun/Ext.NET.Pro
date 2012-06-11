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
    public abstract partial class DataViewBase
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
                
                list.Add("deferEmptyText", new ConfigOption("deferEmptyText", null, false, this.DeferEmptyText ));
                list.Add("emptyText", new ConfigOption("emptyText", null, "", this.EmptyText ));
                list.Add("itemSelector", new ConfigOption("itemSelector", null, "", this.ItemSelector ));
                list.Add("loadingText", new ConfigOption("loadingText", null, "", this.LoadingText ));
                list.Add("multiSelect", new ConfigOption("multiSelect", null, false, this.MultiSelect ));
                list.Add("overClass", new ConfigOption("overClass", null, "", this.OverClass ));
                list.Add("selectedClass", new ConfigOption("selectedClass", null, "x-view-selected", this.SelectedClass ));
                list.Add("simpleSelect", new ConfigOption("simpleSelect", null, false, this.SimpleSelect ));
                list.Add("singleSelect", new ConfigOption("singleSelect", null, false, this.SingleSelect ));
                list.Add("storeID", new ConfigOption("storeID", new SerializationOptions("store", JsonMode.ToClientID), "", this.StoreID ));
                list.Add("store", new ConfigOption("store", new SerializationOptions("store>Primary"), null, this.Store ));
                list.Add("template", new ConfigOption("template", new SerializationOptions("tpl", typeof(LazyControlJsonConverter)), null, this.Template ));
                list.Add("trackOver", new ConfigOption("trackOver", null, false, this.TrackOver ));
                list.Add("prepareData", new ConfigOption("prepareData", new SerializationOptions(JsonMode.Raw), null, this.PrepareData ));

                return list;
            }
        }
    }
}
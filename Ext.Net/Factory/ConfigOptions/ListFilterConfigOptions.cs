/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class ListFilter
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
                
                list.Add("type", new ConfigOption("type", new SerializationOptions(JsonMode.ToLower), null, this.Type ));
                list.Add("iDField", new ConfigOption("iDField", new SerializationOptions("idField"), "id", this.IDField ));
                list.Add("loadingText", new ConfigOption("loadingText", null, "Loading...", this.LoadingText ));
                list.Add("loadOnShow", new ConfigOption("loadOnShow", null, true, this.LoadOnShow ));
                list.Add("single", new ConfigOption("single", null, false, this.Single ));
                list.Add("value", new ConfigOption("value", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.Value ));
                list.Add("menuConfig", new ConfigOption("menuConfig", new SerializationOptions("menuConfig", typeof(LazyControlJsonConverter)), null, this.MenuConfig ));
                list.Add("optionsProxy", new ConfigOption("optionsProxy", new SerializationOptions("options", JsonMode.Raw), "", this.OptionsProxy ));
                list.Add("storeProxy", new ConfigOption("storeProxy", new SerializationOptions("store", JsonMode.Raw), "", this.StoreProxy ));
                list.Add("labelFieldProxy", new ConfigOption("labelFieldProxy", new SerializationOptions("labelField"), "text", this.LabelFieldProxy ));

                return list;
            }
        }
    }
}
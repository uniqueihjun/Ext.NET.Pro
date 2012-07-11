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
    public partial class CompositeField
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
                
                list.Add("layoutConfig", new ConfigOption("layoutConfig", new SerializationOptions(JsonMode.Object), null, this.LayoutConfig ));
                list.Add("autoDoLayout", new ConfigOption("autoDoLayout", null, false, this.AutoDoLayout ));
                list.Add("buildLabel", new ConfigOption("buildLabel", new SerializationOptions(JsonMode.Raw), null, this.BuildLabel ));
                list.Add("items", new ConfigOption("items", new SerializationOptions("items", typeof(ItemCollectionJsonConverter)), null, this.Items ));
                list.Add("defaultMargins", new ConfigOption("defaultMargins", null, "0 5 0 0", this.DefaultMargins ));
                list.Add("skipLastItemMargin", new ConfigOption("skipLastItemMargin", null, true, this.SkipLastItemMargin ));
                list.Add("combineErrors", new ConfigOption("combineErrors", null, true, this.CombineErrors ));
                list.Add("labelConnector", new ConfigOption("labelConnector", null, ", ", this.LabelConnector ));
                list.Add("defaults", new ConfigOption("defaults", new SerializationOptions(JsonMode.ArrayToObject), null, this.Defaults ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}
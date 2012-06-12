/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class GroupTab
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
                
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));
                list.Add("mainItem", new ConfigOption("mainItem", null, 0, this.MainItem ));
                list.Add("expanded", new ConfigOption("expanded", null, true, this.Expanded ));
                list.Add("deferredRender", new ConfigOption("deferredRender", null, true, this.DeferredRender ));
                list.Add("activeTabProxy", new ConfigOption("activeTabProxy", new SerializationOptions("activeTab", JsonMode.Raw), "", this.ActiveTabProxy ));
                list.Add("idDelimiter", new ConfigOption("idDelimiter", null, "__", this.IdDelimiter ));
                list.Add("headerAsText", new ConfigOption("headerAsText", null, false, this.HeaderAsText ));
                list.Add("frame", new ConfigOption("frame", null, false, this.Frame ));
                list.Add("hideBorders", new ConfigOption("hideBorders", null, true, this.HideBorders ));

                return list;
            }
        }
    }
}
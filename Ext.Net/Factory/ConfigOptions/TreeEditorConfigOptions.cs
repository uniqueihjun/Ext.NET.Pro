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
    public partial class TreeEditor
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
                
                list.Add("editDelay", new ConfigOption("editDelay", null, 350, this.EditDelay ));
                list.Add("autoEdit", new ConfigOption("autoEdit", null, true, this.AutoEdit ));
                list.Add("hideEl", new ConfigOption("hideEl", null, false, this.HideEl ));
                list.Add("maxWidth", new ConfigOption("maxWidth", null, 250, this.MaxWidth ));
                list.Add("shim", new ConfigOption("shim", null, false, this.Shim ));
                list.Add("treePanelID", new ConfigOption("treePanelID", new SerializationOptions("tree", JsonMode.ToClientID), "", this.TreePanelID ));
                list.Add("filter", new ConfigOption("filter", new SerializationOptions(JsonMode.Object), null, this.Filter ));
                list.Add("updateEl", new ConfigOption("updateEl", null, false, this.UpdateEl ));

                return list;
            }
        }
    }
}
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
    public partial class ComponentMenuItem
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
                
                list.Add("component", new ConfigOption("component", new SerializationOptions("component", typeof(ItemCollectionJsonConverter)), null, this.Component ));
                list.Add("componentElement", new ConfigOption("componentElement", new SerializationOptions(JsonMode.ToLower), TargetElement.Auto, this.ComponentElement ));
                list.Add("targetProxy", new ConfigOption("targetProxy", new SerializationOptions("target", JsonMode.Raw), "", this.TargetProxy ));
                list.Add("shift", new ConfigOption("shift", null, true, this.Shift ));
                list.Add("hideOnClick", new ConfigOption("hideOnClick", null, false, this.HideOnClick ));

                return list;
            }
        }
    }
}
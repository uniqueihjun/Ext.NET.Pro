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
    public partial class ButtonDirectEvents
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
                
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(DirectEventJsonConverter)), null, this.Click ));
                list.Add("menuHide", new ConfigOption("menuHide", new SerializationOptions("menuhide", typeof(DirectEventJsonConverter)), null, this.MenuHide ));
                list.Add("menuShow", new ConfigOption("menuShow", new SerializationOptions("menushow", typeof(DirectEventJsonConverter)), null, this.MenuShow ));
                list.Add("menuTriggerOut", new ConfigOption("menuTriggerOut", new SerializationOptions("menutriggerout", typeof(DirectEventJsonConverter)), null, this.MenuTriggerOut ));
                list.Add("menuTriggerOver", new ConfigOption("menuTriggerOver", new SerializationOptions("menutriggerover", typeof(DirectEventJsonConverter)), null, this.MenuTriggerOver ));
                list.Add("mouseOut", new ConfigOption("mouseOut", new SerializationOptions("mouseout", typeof(DirectEventJsonConverter)), null, this.MouseOut ));
                list.Add("mouseOver", new ConfigOption("mouseOver", new SerializationOptions("mouseover", typeof(DirectEventJsonConverter)), null, this.MouseOver ));
                list.Add("toggle", new ConfigOption("toggle", new SerializationOptions("toggle", typeof(DirectEventJsonConverter)), null, this.Toggle ));

                return list;
            }
        }
    }
}
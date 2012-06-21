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
    public partial class ButtonListeners
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
                
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(ListenerJsonConverter)), null, this.Click ));
                list.Add("menuHide", new ConfigOption("menuHide", new SerializationOptions("menuhide", typeof(ListenerJsonConverter)), null, this.MenuHide ));
                list.Add("menuShow", new ConfigOption("menuShow", new SerializationOptions("menushow", typeof(ListenerJsonConverter)), null, this.MenuShow ));
                list.Add("menuTriggerOut", new ConfigOption("menuTriggerOut", new SerializationOptions("menutriggerout", typeof(ListenerJsonConverter)), null, this.MenuTriggerOut ));
                list.Add("menuTriggerOver", new ConfigOption("menuTriggerOver", new SerializationOptions("menutriggerover", typeof(ListenerJsonConverter)), null, this.MenuTriggerOver ));
                list.Add("mouseOut", new ConfigOption("mouseOut", new SerializationOptions("mouseout", typeof(ListenerJsonConverter)), null, this.MouseOut ));
                list.Add("mouseOver", new ConfigOption("mouseOver", new SerializationOptions("mouseover", typeof(ListenerJsonConverter)), null, this.MouseOver ));
                list.Add("toggle", new ConfigOption("toggle", new SerializationOptions("toggle", typeof(ListenerJsonConverter)), null, this.Toggle ));

                return list;
            }
        }
    }
}
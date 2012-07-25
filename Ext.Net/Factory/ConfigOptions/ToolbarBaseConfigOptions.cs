/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public abstract partial class ToolbarBase
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
                
                list.Add("defaultType", new ConfigOption("defaultType", null, "button", this.DefaultType ));
                list.Add("flat", new ConfigOption("flat", null, false, this.Flat ));
                list.Add("classicButtonStyle", new ConfigOption("classicButtonStyle", null, false, this.ClassicButtonStyle ));
                list.Add("enableOverflow", new ConfigOption("enableOverflow", null, false, this.EnableOverflow ));
                list.Add("menuTriggerCls", new ConfigOption("menuTriggerCls", null, "", this.MenuTriggerCls ));
                list.Add("vertical", new ConfigOption("vertical", null, false, this.Vertical ));

                return list;
            }
        }
    }
}
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
    public abstract partial class MenuBase
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
                
                list.Add("allowOtherMenus", new ConfigOption("allowOtherMenus", null, false, this.AllowOtherMenus ));
                list.Add("defaultAlign", new ConfigOption("defaultAlign", null, "tl-bl?", this.DefaultAlign ));
                list.Add("defaultType", new ConfigOption("defaultType", null, "menuitem", this.DefaultType ));
                list.Add("floatingProxy", new ConfigOption("floatingProxy", new SerializationOptions("floating"), true, this.FloatingProxy ));
                list.Add("ignoreParentClicks", new ConfigOption("ignoreParentClicks", null, false, this.IgnoreParentClicks ));
                list.Add("plain", new ConfigOption("plain", null, false, this.Plain ));
                list.Add("showSeparator", new ConfigOption("showSeparator", null, true, this.ShowSeparator ));
                list.Add("enableKeyNav", new ConfigOption("enableKeyNav", null, true, this.EnableKeyNav ));
                list.Add("renderToForm", new ConfigOption("renderToForm", null, false, this.RenderToForm ));

                return list;
            }
        }
    }
}
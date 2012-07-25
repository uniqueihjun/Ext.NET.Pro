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
    public partial class CommandMenu
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
                
                list.Add("items", new ConfigOption("items", new SerializationOptions("items", JsonMode.AlwaysArray), null, this.Items ));
                list.Add("shared", new ConfigOption("shared", null, false, this.Shared ));
                list.Add("enableScrolling", new ConfigOption("enableScrolling", null, true, this.EnableScrolling ));
                list.Add("minWidth", new ConfigOption("minWidth", new SerializationOptions(JsonMode.Raw), 120, this.MinWidth ));
                list.Add("maxHeight", new ConfigOption("maxHeight", new SerializationOptions(JsonMode.Raw), 0, this.MaxHeight ));
                list.Add("scrollIncrement", new ConfigOption("scrollIncrement", new SerializationOptions(JsonMode.Raw), 24, this.ScrollIncrement ));
                list.Add("showSeparator", new ConfigOption("showSeparator", null, true, this.ShowSeparator ));
                list.Add("shadow", new ConfigOption("shadow", new SerializationOptions(typeof(ShadowJsonConverter)), ShadowMode.Sides, this.Shadow ));
                list.Add("ignoreParentClicks", new ConfigOption("ignoreParentClicks", null, false, this.IgnoreParentClicks ));

                return list;
            }
        }
    }
}
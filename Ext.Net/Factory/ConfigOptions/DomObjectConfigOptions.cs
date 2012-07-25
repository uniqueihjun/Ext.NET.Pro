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
    public partial class DomObject
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
                
                list.Add("tag", new ConfigOption("tag", new SerializationOptions(JsonMode.ToLower), HtmlTextWriterTag.Div, this.Tag ));
                list.Add("iD", new ConfigOption("iD", new SerializationOptions("id"), "", this.ID ));
                list.Add("cls", new ConfigOption("cls", null, "", this.Cls ));
                list.Add("html", new ConfigOption("html", null, "", this.Html ));
                list.Add("children", new ConfigOption("children", new SerializationOptions("cn", JsonMode.AlwaysArray), null, this.Children ));

                return list;
            }
        }
    }
}
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
    public partial class HtmlEditor
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
                list.Add("createLinkText", new ConfigOption("createLinkText", null, "", this.CreateLinkText ));
                list.Add("defaultFont", new ConfigOption("defaultFont", null, "", this.DefaultFont ));
                list.Add("defaultLinkValue", new ConfigOption("defaultLinkValue", null, "http://", this.DefaultLinkValue ));
                list.Add("enableAlignments", new ConfigOption("enableAlignments", null, true, this.EnableAlignments ));
                list.Add("enableColors", new ConfigOption("enableColors", null, true, this.EnableColors ));
                list.Add("enableFont", new ConfigOption("enableFont", null, true, this.EnableFont ));
                list.Add("enableFontSize", new ConfigOption("enableFontSize", null, true, this.EnableFontSize ));
                list.Add("enableFormat", new ConfigOption("enableFormat", null, true, this.EnableFormat ));
                list.Add("enableLinks", new ConfigOption("enableLinks", null, true, this.EnableLinks ));
                list.Add("enableLists", new ConfigOption("enableLists", null, true, this.EnableLists ));
                list.Add("enableSourceEdit", new ConfigOption("enableSourceEdit", null, true, this.EnableSourceEdit ));
                list.Add("escapeValue", new ConfigOption("escapeValue", null, true, this.EscapeValue ));
                list.Add("fontFamilies", new ConfigOption("fontFamilies", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.FontFamilies ));

                return list;
            }
        }
    }
}
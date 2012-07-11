/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class HtmlEditorButtonTips
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
                
                list.Add("bold", new ConfigOption("bold", new SerializationOptions(JsonMode.Object), null, this.Bold ));
                list.Add("italic", new ConfigOption("italic", new SerializationOptions(JsonMode.Object), null, this.Italic ));
                list.Add("underline", new ConfigOption("underline", new SerializationOptions(JsonMode.Object), null, this.Underline ));
                list.Add("increaseFontSize", new ConfigOption("increaseFontSize", new SerializationOptions("increasefontsize", JsonMode.Object), null, this.IncreaseFontSize ));
                list.Add("decreaseFontSize", new ConfigOption("decreaseFontSize", new SerializationOptions("decreasefontsize", JsonMode.Object), null, this.DecreaseFontSize ));
                list.Add("backColor", new ConfigOption("backColor", new SerializationOptions("backcolor", JsonMode.Object), null, this.BackColor ));
                list.Add("foreColor", new ConfigOption("foreColor", new SerializationOptions("forecolor", JsonMode.Object), null, this.ForeColor ));
                list.Add("justifyLeft", new ConfigOption("justifyLeft", new SerializationOptions("justifyleft", JsonMode.Object), null, this.JustifyLeft ));
                list.Add("justifyCenter", new ConfigOption("justifyCenter", new SerializationOptions("justifycenter", JsonMode.Object), null, this.JustifyCenter ));
                list.Add("justifyRight", new ConfigOption("justifyRight", new SerializationOptions("justifyright", JsonMode.Object), null, this.JustifyRight ));
                list.Add("insertUnorderedList", new ConfigOption("insertUnorderedList", new SerializationOptions("insertunorderedlist", JsonMode.Object), null, this.InsertUnorderedList ));
                list.Add("insertOrderedList", new ConfigOption("insertOrderedList", new SerializationOptions("insertorderedlist", JsonMode.Object), null, this.InsertOrderedList ));
                list.Add("createLink", new ConfigOption("createLink", new SerializationOptions("createlink", JsonMode.Object), null, this.CreateLink ));
                list.Add("sourceEdit", new ConfigOption("sourceEdit", new SerializationOptions("sourceedit", JsonMode.Object), null, this.SourceEdit ));

                return list;
            }
        }
    }
}
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
    public partial class ImageButton
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
                
                list.Add("imageUrl", new ConfigOption("imageUrl", new SerializationOptions(JsonMode.Ignore), "", this.ImageUrl ));
                list.Add("imageUrlProxy", new ConfigOption("imageUrlProxy", new SerializationOptions("imageUrl"), "", this.ImageUrlProxy ));
                list.Add("overImageUrl", new ConfigOption("overImageUrl", new SerializationOptions(JsonMode.Ignore), "", this.OverImageUrl ));
                list.Add("overImageUrlProxy", new ConfigOption("overImageUrlProxy", new SerializationOptions("overImageUrl"), "", this.OverImageUrlProxy ));
                list.Add("disabledImageUrl", new ConfigOption("disabledImageUrl", new SerializationOptions(JsonMode.Ignore), "", this.DisabledImageUrl ));
                list.Add("disabledImageUrlProxy", new ConfigOption("disabledImageUrlProxy", new SerializationOptions("disabledImageUrl"), "", this.DisabledImageUrlProxy ));
                list.Add("pressedImageUrl", new ConfigOption("pressedImageUrl", new SerializationOptions(JsonMode.Ignore), "", this.PressedImageUrl ));
                list.Add("pressedImageUrlProxy", new ConfigOption("pressedImageUrlProxy", new SerializationOptions("pressedImageUrl"), "", this.PressedImageUrlProxy ));
                list.Add("alternateText", new ConfigOption("alternateText", new SerializationOptions("altText"), "", this.AlternateText ));
                list.Add("align", new ConfigOption("align", new SerializationOptions(JsonMode.ToLower), ImageAlign.NotSet, this.Align ));

                return list;
            }
        }
    }
}
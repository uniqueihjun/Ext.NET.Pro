/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class Desktop
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
                
                list.Add("renderToProxy", new ConfigOption("renderToProxy", new SerializationOptions(JsonMode.Ignore), null, this.RenderToProxy ));
                list.Add("modulesProxy", new ConfigOption("modulesProxy", new SerializationOptions("getModules", JsonMode.Raw), null, this.ModulesProxy ));
                list.Add("startMenuProxy", new ConfigOption("startMenuProxy", new SerializationOptions("getStartConfig", JsonMode.Raw), null, this.StartMenuProxy ));
                list.Add("startButtonProxy", new ConfigOption("startButtonProxy", new SerializationOptions("getStartButtonConfig", JsonMode.Raw), null, this.StartButtonProxy ));
                list.Add("xTickSize", new ConfigOption("xTickSize", null, 1, this.XTickSize ));
                list.Add("yTickSize", new ConfigOption("yTickSize", null, 1, this.YTickSize ));
                list.Add("backgroundColor", new ConfigOption("backgroundColor", null, "", this.BackgroundColor ));
                list.Add("shortcutTextColor", new ConfigOption("shortcutTextColor", null, "", this.ShortcutTextColor ));
                list.Add("wallpaper", new ConfigOption("wallpaper", null, "", this.Wallpaper ));
                list.Add("textLengthToTruncate", new ConfigOption("textLengthToTruncate", null, 12, this.TextLengthToTruncate ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}
/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class GridEditorOptions
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
                list.Add("zIndex", new ConfigOption("zIndex", null, 0, this.ZIndex ));
                list.Add("alignment", new ConfigOption("alignment", null, "tl-tl", this.Alignment ));
                list.Add("autoSizeProxy", new ConfigOption("autoSizeProxy", new SerializationOptions("autoSize", JsonMode.Raw), "\"width\"", this.AutoSizeProxy ));
                list.Add("allowBlur", new ConfigOption("allowBlur", null, true, this.AllowBlur ));
                list.Add("cancelOnEsc", new ConfigOption("cancelOnEsc", null, true, this.CancelOnEsc ));
                list.Add("completeOnEnter", new ConfigOption("completeOnEnter", null, true, this.CompleteOnEnter ));
                list.Add("cancelOnBlur", new ConfigOption("cancelOnBlur", null, false, this.CancelOnBlur ));
                list.Add("ignoreNoChange", new ConfigOption("ignoreNoChange", null, false, this.IgnoreNoChange ));
                list.Add("revertInvalid", new ConfigOption("revertInvalid", null, true, this.RevertInvalid ));
                list.Add("shadow", new ConfigOption("shadow", new SerializationOptions(typeof(ShadowJsonConverter)), ShadowMode.None, this.Shadow ));
                list.Add("swallowKeys", new ConfigOption("swallowKeys", null, true, this.SwallowKeys ));
                list.Add("offsets", new ConfigOption("offsets", new SerializationOptions(JsonMode.AlwaysArray), null, this.Offsets ));

                return list;
            }
        }
    }
}
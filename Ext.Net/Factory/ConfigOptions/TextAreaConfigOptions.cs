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
    public partial class TextArea
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
                
                list.Add("cols", new ConfigOption("cols", null, 20, this.Cols ));
                list.Add("enterIsSpecial", new ConfigOption("enterIsSpecial", null, false, this.EnterIsSpecial ));
                list.Add("growAppend", new ConfigOption("growAppend", null, "", this.GrowAppend ));
                list.Add("growMax", new ConfigOption("growMax", null, Unit.Pixel(1000), this.GrowMax ));
                list.Add("growMin", new ConfigOption("growMin", null, Unit.Pixel(60), this.GrowMin ));
                list.Add("preventScrollbars", new ConfigOption("preventScrollbars", null, false, this.PreventScrollbars ));
                list.Add("rows", new ConfigOption("rows", null, 4, this.Rows ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}
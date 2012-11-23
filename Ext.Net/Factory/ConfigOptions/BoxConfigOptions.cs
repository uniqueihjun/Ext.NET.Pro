/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class Box
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
                
                list.Add("x", new ConfigOption("x", null, int.MinValue, this.X ));
                list.Add("y", new ConfigOption("y", null, int.MinValue, this.Y ));
                list.Add("width", new ConfigOption("width", null, int.MinValue, this.Width ));
                list.Add("height", new ConfigOption("height", null, int.MinValue, this.Height ));
                list.Add("strWidth", new ConfigOption("strWidth", new SerializationOptions("width"), int.MinValue, this.StrWidth ));
                list.Add("strHeight", new ConfigOption("strHeight", new SerializationOptions("height"), null, this.StrHeight ));

                return list;
            }
        }
    }
}
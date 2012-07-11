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
    public abstract partial class Tip
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
                
                list.Add("autoHeight", new ConfigOption("autoHeight", null, true, this.AutoHeight ));
                list.Add("closable", new ConfigOption("closable", null, false, this.Closable ));
                list.Add("constrainPosition", new ConfigOption("constrainPosition", null, false, this.ConstrainPosition ));
                list.Add("defaultAlign", new ConfigOption("defaultAlign", null, "", this.DefaultAlign ));
                list.Add("maxWidth", new ConfigOption("maxWidth", null, Unit.Pixel(300), this.MaxWidth ));
                list.Add("minWidth", new ConfigOption("minWidth", null, Unit.Pixel(40), this.MinWidth ));

                return list;
            }
        }
    }
}
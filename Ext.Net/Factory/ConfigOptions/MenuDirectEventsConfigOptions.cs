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
    public partial class MenuDirectEvents
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
                
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(DirectEventJsonConverter)), null, this.Click ));
                list.Add("itemClick", new ConfigOption("itemClick", new SerializationOptions("itemclick", typeof(DirectEventJsonConverter)), null, this.ItemClick ));
                list.Add("mouseOut", new ConfigOption("mouseOut", new SerializationOptions("mouseout", typeof(DirectEventJsonConverter)), null, this.MouseOut ));
                list.Add("mouseOver", new ConfigOption("mouseOver", new SerializationOptions("mouseover", typeof(DirectEventJsonConverter)), null, this.MouseOver ));

                return list;
            }
        }
    }
}
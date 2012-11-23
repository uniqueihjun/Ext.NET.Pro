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
    public partial class GroupTabDirectEvents
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
                
                list.Add("activate", new ConfigOption("activate", new SerializationOptions("activate", typeof(DirectEventJsonConverter)), null, this.Activate ));
                list.Add("deactivate", new ConfigOption("deactivate", new SerializationOptions("deactivate", typeof(DirectEventJsonConverter)), null, this.Deactivate ));
                list.Add("changeMainItem", new ConfigOption("changeMainItem", new SerializationOptions("changemainitem", typeof(DirectEventJsonConverter)), null, this.ChangeMainItem ));
                list.Add("beforeTabChange", new ConfigOption("beforeTabChange", new SerializationOptions("beforetabchange", typeof(DirectEventJsonConverter)), null, this.BeforeTabChange ));
                list.Add("tabChange", new ConfigOption("tabChange", new SerializationOptions("tabchange", typeof(DirectEventJsonConverter)), null, this.TabChange ));

                return list;
            }
        }
    }
}
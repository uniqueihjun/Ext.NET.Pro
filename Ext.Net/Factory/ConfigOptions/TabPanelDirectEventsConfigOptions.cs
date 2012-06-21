/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class TabPanelDirectEvents
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
                
                list.Add("beforeTabChange", new ConfigOption("beforeTabChange", new SerializationOptions("beforetabchange", typeof(DirectEventJsonConverter)), null, this.BeforeTabChange ));
                list.Add("tabChange", new ConfigOption("tabChange", new SerializationOptions("tabchange", typeof(DirectEventJsonConverter)), null, this.TabChange ));
                list.Add("beforeTabClose", new ConfigOption("beforeTabClose", new SerializationOptions("beforetabclose", typeof(DirectEventJsonConverter)), null, this.BeforeTabClose ));
                list.Add("beforeTabHide", new ConfigOption("beforeTabHide", new SerializationOptions("beforetabhide", typeof(DirectEventJsonConverter)), null, this.BeforeTabHide ));
                list.Add("tabClose", new ConfigOption("tabClose", new SerializationOptions("tabclose", typeof(DirectEventJsonConverter)), null, this.TabClose ));
                list.Add("beforeTabMenuShow", new ConfigOption("beforeTabMenuShow", new SerializationOptions("beforetabmenushow", typeof(DirectEventJsonConverter)), null, this.BeforeTabMenuShow ));

                return list;
            }
        }
    }
}
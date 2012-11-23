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
    public partial class TreeSorter
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
                
                list.Add("caseSensitive", new ConfigOption("caseSensitive", null, false, this.CaseSensitive ));
                list.Add("direction", new ConfigOption("direction", new SerializationOptions("dir", JsonMode.ToLower), SortDirection.Default, this.Direction ));
                list.Add("folderSort", new ConfigOption("folderSort", null, false, this.FolderSort ));
                list.Add("leafAttr", new ConfigOption("leafAttr", null, "leaf", this.LeafAttr ));
                list.Add("property", new ConfigOption("property", null, "text", this.Property ));
                list.Add("sortType", new ConfigOption("sortType", new SerializationOptions(JsonMode.Raw), null, this.SortType ));

                return list;
            }
        }
    }
}
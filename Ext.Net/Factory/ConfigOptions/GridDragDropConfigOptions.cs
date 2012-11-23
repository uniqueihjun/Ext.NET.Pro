/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class GridDragDrop
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
                
                list.Add("pType", new ConfigOption("pType", new SerializationOptions("ptype"), "", this.PType ));
                list.Add("dDGroup", new ConfigOption("dDGroup", new SerializationOptions("ddGroup"), "GridDD", this.DDGroup ));
                list.Add("dragText", new ConfigOption("dragText", null, "{0} selected row{1}", this.DragText ));
                list.Add("dragGroup", new ConfigOption("dragGroup", null, "", this.DragGroup ));
                list.Add("dropGroup", new ConfigOption("dropGroup", null, "", this.DropGroup ));
                list.Add("enableDrag", new ConfigOption("enableDrag", null, true, this.EnableDrag ));
                list.Add("containerScroll", new ConfigOption("containerScroll", null, false, this.ContainerScroll ));
                list.Add("enableDrop", new ConfigOption("enableDrop", null, true, this.EnableDrop ));

                return list;
            }
        }
    }
}
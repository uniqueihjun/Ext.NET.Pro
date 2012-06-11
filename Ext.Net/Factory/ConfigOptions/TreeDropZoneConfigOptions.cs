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
    public partial class TreeDropZone
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
                
                list.Add("dragOverDataProxy", new ConfigOption("dragOverDataProxy", new SerializationOptions("dragOverData", JsonMode.Raw), "{}", this.DragOverDataProxy ));
                list.Add("allowContainerDrop", new ConfigOption("allowContainerDrop", null, false, this.AllowContainerDrop ));
                list.Add("allowParentInsert", new ConfigOption("allowParentInsert", null, false, this.AllowParentInsert ));
                list.Add("appendOnly", new ConfigOption("appendOnly", null, false, this.AppendOnly ));
                list.Add("expandDelay", new ConfigOption("expandDelay", null, 1000, this.ExpandDelay ));

                return list;
            }
        }
    }
}
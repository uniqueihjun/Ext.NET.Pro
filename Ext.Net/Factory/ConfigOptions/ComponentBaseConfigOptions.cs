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
    public abstract partial class ComponentBase
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
                
                list.Add("autoScroll", new ConfigOption("autoScroll", null, false, this.AutoScroll ));
                list.Add("draggableProxy", new ConfigOption("draggableProxy", new SerializationOptions("draggable"), false, this.DraggableProxy ));
                list.Add("draggableConfigProxy", new ConfigOption("draggableConfigProxy", new SerializationOptions("draggable", JsonMode.Raw), "", this.DraggableConfigProxy ));
                list.Add("maintainFlex", new ConfigOption("maintainFlex", null, false, this.MaintainFlex ));
                list.Add("overflowX", new ConfigOption("overflowX", new SerializationOptions(JsonMode.ToLower), Overflow.Hidden, this.OverflowX ));
                list.Add("overflowY", new ConfigOption("overflowY", new SerializationOptions(JsonMode.ToLower), Overflow.Hidden, this.OverflowY ));
                list.Add("resizableProxy", new ConfigOption("resizableProxy", new SerializationOptions("resizable"), false, this.ResizableProxy ));
                list.Add("resizableConfigProxy", new ConfigOption("resizableConfigProxy", new SerializationOptions("resizable", JsonMode.Raw), "", this.ResizableConfigProxy ));

                return list;
            }
        }
    }
}
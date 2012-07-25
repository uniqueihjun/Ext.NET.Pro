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
    public abstract partial class CellCommandColumn
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
                
                list.Add("rightCommandAlign", new ConfigOption("rightCommandAlign", null, true, this.RightCommandAlign ));
                list.Add("commands", new ConfigOption("commands", new SerializationOptions("commands", JsonMode.AlwaysArray), null, this.Commands ));
                list.Add("isCellCommand", new ConfigOption("isCellCommand", null, false, this.IsCellCommand ));
                list.Add("prepareCommand", new ConfigOption("prepareCommand", new SerializationOptions(JsonMode.Raw), null, this.PrepareCommand ));
                list.Add("prepareCommands", new ConfigOption("prepareCommands", new SerializationOptions(JsonMode.Raw), null, this.PrepareCommands ));

                return list;
            }
        }
    }
}
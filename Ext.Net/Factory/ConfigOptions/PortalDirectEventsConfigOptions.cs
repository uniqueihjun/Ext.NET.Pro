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
    public partial class PortalDirectEvents
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
                
                list.Add("validateDrop", new ConfigOption("validateDrop", new SerializationOptions("validatedrop", typeof(DirectEventJsonConverter)), null, this.ValidateDrop ));
                list.Add("beforeDragOver", new ConfigOption("beforeDragOver", new SerializationOptions("beforedragover", typeof(DirectEventJsonConverter)), null, this.BeforeDragOver ));
                list.Add("dragOver", new ConfigOption("dragOver", new SerializationOptions("dragover", typeof(DirectEventJsonConverter)), null, this.DragOver ));
                list.Add("beforeDrop", new ConfigOption("beforeDrop", new SerializationOptions("beforedrop", typeof(DirectEventJsonConverter)), null, this.BeforeDrop ));
                list.Add("drop", new ConfigOption("drop", new SerializationOptions("drop", typeof(DirectEventJsonConverter)), null, this.Drop ));

                return list;
            }
        }
    }
}
/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class ContainerListeners
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
                
                list.Add("add", new ConfigOption("add", new SerializationOptions("add", typeof(ListenerJsonConverter)), null, this.Add ));
                list.Add("afterLayout", new ConfigOption("afterLayout", new SerializationOptions("afterlayout", typeof(ListenerJsonConverter)), null, this.AfterLayout ));
                list.Add("beforeAdd", new ConfigOption("beforeAdd", new SerializationOptions("beforeadd", typeof(ListenerJsonConverter)), null, this.BeforeAdd ));
                list.Add("beforeRemove", new ConfigOption("beforeRemove", new SerializationOptions("beforeremove", typeof(ListenerJsonConverter)), null, this.BeforeRemove ));
                list.Add("remove", new ConfigOption("remove", new SerializationOptions("remove", typeof(ListenerJsonConverter)), null, this.Remove ));

                return list;
            }
        }
    }
}
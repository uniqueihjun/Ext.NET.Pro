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
    public partial class RowEditorListeners
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
                
                list.Add("afterEdit", new ConfigOption("afterEdit", new SerializationOptions("afteredit", typeof(ListenerJsonConverter)), null, this.AfterEdit ));
                list.Add("beforeEdit", new ConfigOption("beforeEdit", new SerializationOptions("beforeedit", typeof(ListenerJsonConverter)), null, this.BeforeEdit ));
                list.Add("cancelEdit", new ConfigOption("cancelEdit", new SerializationOptions("canceledit", typeof(ListenerJsonConverter)), null, this.CancelEdit ));
                list.Add("validateEdit", new ConfigOption("validateEdit", new SerializationOptions("validateedit", typeof(ListenerJsonConverter)), null, this.ValidateEdit ));
                list.Add("preEdit", new ConfigOption("preEdit", new SerializationOptions("preedit", typeof(ListenerJsonConverter)), null, this.PreEdit ));

                return list;
            }
        }
    }
}
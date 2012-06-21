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
    public partial class DesktopListeners
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
                
                list.Add("shortcutMove", new ConfigOption("shortcutMove", new SerializationOptions("shortcutmove", typeof(ListenerJsonConverter)), null, this.ShortcutMove ));
                list.Add("shortcutNameEdit", new ConfigOption("shortcutNameEdit", new SerializationOptions("shortcutnameedit", typeof(ListenerJsonConverter)), null, this.ShortcutNameEdit ));
                list.Add("ready", new ConfigOption("ready", new SerializationOptions("ready", typeof(ListenerJsonConverter)), null, this.Ready ));
                list.Add("beforeUnload", new ConfigOption("beforeUnload", new SerializationOptions("beforeunload", typeof(ListenerJsonConverter)), null, this.BeforeUnload ));

                return list;
            }
        }
    }
}
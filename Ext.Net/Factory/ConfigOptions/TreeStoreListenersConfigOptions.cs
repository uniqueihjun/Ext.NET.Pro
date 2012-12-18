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
    public partial class TreeStoreListeners
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
                
                list.Add("append", new ConfigOption("append", new SerializationOptions("append", typeof(ListenerJsonConverter)), null, this.Append ));
                list.Add("beforeAppend", new ConfigOption("beforeAppend", new SerializationOptions("beforeappend", typeof(ListenerJsonConverter)), null, this.BeforeAppend ));
                list.Add("beforeCollapse", new ConfigOption("beforeCollapse", new SerializationOptions("beforecollapse", typeof(ListenerJsonConverter)), null, this.BeforeCollapse ));
                list.Add("beforeExpand", new ConfigOption("beforeExpand", new SerializationOptions("beforeexpand", typeof(ListenerJsonConverter)), null, this.BeforeExpand ));
                list.Add("beforeInsert", new ConfigOption("beforeInsert", new SerializationOptions("beforeinsert", typeof(ListenerJsonConverter)), null, this.BeforeInsert ));
                list.Add("beforeMove", new ConfigOption("beforeMove", new SerializationOptions("beforemove", typeof(ListenerJsonConverter)), null, this.BeforeMove ));
                list.Add("beforeRemove", new ConfigOption("beforeRemove", new SerializationOptions("beforeremove", typeof(ListenerJsonConverter)), null, this.BeforeRemove ));
                list.Add("collapse", new ConfigOption("collapse", new SerializationOptions("collapse", typeof(ListenerJsonConverter)), null, this.Collapse ));
                list.Add("expand", new ConfigOption("expand", new SerializationOptions("expand", typeof(ListenerJsonConverter)), null, this.Expand ));
                list.Add("insert", new ConfigOption("insert", new SerializationOptions("insert", typeof(ListenerJsonConverter)), null, this.Insert ));
                list.Add("load", new ConfigOption("load", new SerializationOptions("load", typeof(ListenerJsonConverter)), null, this.Load ));
                list.Add("move", new ConfigOption("move", new SerializationOptions("move", typeof(ListenerJsonConverter)), null, this.Move ));
                list.Add("remove", new ConfigOption("remove", new SerializationOptions("remove", typeof(ListenerJsonConverter)), null, this.Remove ));
                list.Add("rootChange", new ConfigOption("rootChange", new SerializationOptions("rootchange", typeof(ListenerJsonConverter)), null, this.RootChange ));
                list.Add("sort", new ConfigOption("sort", new SerializationOptions("sort", typeof(ListenerJsonConverter)), null, this.Sort ));

                return list;
            }
        }
    }
}
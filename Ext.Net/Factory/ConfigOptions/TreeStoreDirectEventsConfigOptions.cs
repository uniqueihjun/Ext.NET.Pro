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
    public partial class TreeStoreDirectEvents
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
                
                list.Add("append", new ConfigOption("append", new SerializationOptions("append", typeof(DirectEventJsonConverter)), null, this.Append ));
                list.Add("beforeAppend", new ConfigOption("beforeAppend", new SerializationOptions("beforeappend", typeof(DirectEventJsonConverter)), null, this.BeforeAppend ));
                list.Add("beforeCollapse", new ConfigOption("beforeCollapse", new SerializationOptions("beforecollapse", typeof(DirectEventJsonConverter)), null, this.BeforeCollapse ));
                list.Add("beforeExpand", new ConfigOption("beforeExpand", new SerializationOptions("beforeexpand", typeof(DirectEventJsonConverter)), null, this.BeforeExpand ));
                list.Add("beforeInsert", new ConfigOption("beforeInsert", new SerializationOptions("beforeinsert", typeof(DirectEventJsonConverter)), null, this.BeforeInsert ));
                list.Add("beforeMove", new ConfigOption("beforeMove", new SerializationOptions("beforemove", typeof(DirectEventJsonConverter)), null, this.BeforeMove ));
                list.Add("beforeRemove", new ConfigOption("beforeRemove", new SerializationOptions("beforeremove", typeof(DirectEventJsonConverter)), null, this.BeforeRemove ));
                list.Add("collapse", new ConfigOption("collapse", new SerializationOptions("collapse", typeof(DirectEventJsonConverter)), null, this.Collapse ));
                list.Add("expand", new ConfigOption("expand", new SerializationOptions("expand", typeof(DirectEventJsonConverter)), null, this.Expand ));
                list.Add("insert", new ConfigOption("insert", new SerializationOptions("insert", typeof(DirectEventJsonConverter)), null, this.Insert ));
                list.Add("load", new ConfigOption("load", new SerializationOptions("load", typeof(DirectEventJsonConverter)), null, this.Load ));
                list.Add("move", new ConfigOption("move", new SerializationOptions("move", typeof(DirectEventJsonConverter)), null, this.Move ));
                list.Add("remove", new ConfigOption("remove", new SerializationOptions("remove", typeof(DirectEventJsonConverter)), null, this.Remove ));
                list.Add("rootChange", new ConfigOption("rootChange", new SerializationOptions("rootchange", typeof(DirectEventJsonConverter)), null, this.RootChange ));
                list.Add("sort", new ConfigOption("sort", new SerializationOptions("sort", typeof(DirectEventJsonConverter)), null, this.Sort ));

                return list;
            }
        }
    }
}
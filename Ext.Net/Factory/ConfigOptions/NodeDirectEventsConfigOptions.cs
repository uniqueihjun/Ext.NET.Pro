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
    public partial class NodeDirectEvents
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
                list.Add("beforeInsert", new ConfigOption("beforeInsert", new SerializationOptions("beforeinsert", typeof(DirectEventJsonConverter)), null, this.BeforeInsert ));
                list.Add("beforeMove", new ConfigOption("beforeMove", new SerializationOptions("beforemove", typeof(DirectEventJsonConverter)), null, this.BeforeMove ));
                list.Add("beforeRemove", new ConfigOption("beforeRemove", new SerializationOptions("beforeremove", typeof(DirectEventJsonConverter)), null, this.BeforeRemove ));
                list.Add("insert", new ConfigOption("insert", new SerializationOptions("insert", typeof(DirectEventJsonConverter)), null, this.Insert ));
                list.Add("move", new ConfigOption("move", new SerializationOptions("move", typeof(DirectEventJsonConverter)), null, this.Move ));
                list.Add("remove", new ConfigOption("remove", new SerializationOptions("remove", typeof(DirectEventJsonConverter)), null, this.Remove ));

                return list;
            }
        }
    }
}
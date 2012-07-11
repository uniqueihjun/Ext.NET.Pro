/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public abstract partial class AbstractReader
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
                
                list.Add("type", new ConfigOption("type", null, null, this.Type ));
                list.Add("iDProperty", new ConfigOption("iDProperty", new SerializationOptions("idProperty"), "", this.IDProperty ));
                list.Add("implicitIncludes", new ConfigOption("implicitIncludes", null, true, this.ImplicitIncludes ));
                list.Add("readRecordsOnFailure", new ConfigOption("readRecordsOnFailure", null, true, this.ReadRecordsOnFailure ));
                list.Add("root", new ConfigOption("root", null, "", this.Root ));
                list.Add("successProperty", new ConfigOption("successProperty", null, "", this.SuccessProperty ));
                list.Add("totalProperty", new ConfigOption("totalProperty", null, "", this.TotalProperty ));
                list.Add("messageProperty", new ConfigOption("messageProperty", null, "", this.MessageProperty ));
                list.Add("modelName", new ConfigOption("modelName", new SerializationOptions("model"), null, this.ModelName ));

                return list;
            }
        }
    }
}
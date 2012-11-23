/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class HasManyAssociation
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
                list.Add("autoLoad", new ConfigOption("autoLoad", null, false, this.AutoLoad ));
                list.Add("filterProperty", new ConfigOption("filterProperty", null, null, this.FilterProperty ));
                list.Add("foreignKey", new ConfigOption("foreignKey", null, null, this.ForeignKey ));
                list.Add("name", new ConfigOption("name", null, null, this.Name ));
                list.Add("storeConfigProxy", new ConfigOption("storeConfigProxy", new SerializationOptions("storeConfig", JsonMode.Raw), null, this.StoreConfigProxy ));

                return list;
            }
        }
    }
}
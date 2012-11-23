/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class RowExpander
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
                
                list.Add("configIDProxy", new ConfigOption("configIDProxy", new SerializationOptions("proxyId"), null, this.ConfigIDProxy ));
                list.Add("template", new ConfigOption("template", new SerializationOptions("tpl", typeof(LazyControlJsonConverter)), null, this.Template ));
                list.Add("component", new ConfigOption("component", new SerializationOptions("component", typeof(ItemCollectionJsonConverter)), null, this.Component ));
                list.Add("recreateComponent", new ConfigOption("recreateComponent", null, false, this.RecreateComponent ));
                list.Add("swallowBodyEvents", new ConfigOption("swallowBodyEvents", null, false, this.SwallowBodyEvents ));
                list.Add("enableCaching", new ConfigOption("enableCaching", null, true, this.EnableCaching ));
                list.Add("expandOnEnter", new ConfigOption("expandOnEnter", null, true, this.ExpandOnEnter ));
                list.Add("expandOnDblClick", new ConfigOption("expandOnDblClick", null, true, this.ExpandOnDblClick ));
                list.Add("lazyRender", new ConfigOption("lazyRender", null, true, this.LazyRender ));
                list.Add("singleExpand", new ConfigOption("singleExpand", null, false, this.SingleExpand ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}
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
    public partial class BoxSplitter
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
                
                list.Add("collapseOnDblClick", new ConfigOption("collapseOnDblClick", null, true, this.CollapseOnDblClick ));
                list.Add("collapseTargetProxy", new ConfigOption("collapseTargetProxy", new SerializationOptions("collapseTarget"), "", this.CollapseTargetProxy ));
                list.Add("collapsedCls", new ConfigOption("collapsedCls", null, "", this.CollapsedCls ));
                list.Add("collapsible", new ConfigOption("collapsible", null, false, this.Collapsible ));
                list.Add("defaultSplitMax", new ConfigOption("defaultSplitMax", null, 1000, this.DefaultSplitMax ));
                list.Add("defaultSplitMin", new ConfigOption("defaultSplitMin", null, 40, this.DefaultSplitMin ));
                list.Add("performCollapse", new ConfigOption("performCollapse", null, true, this.PerformCollapse ));

                return list;
            }
        }
    }
}
/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class AccordionLayoutConfig
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
                
                list.Add("activeOnTop", new ConfigOption("activeOnTop", null, false, this.ActiveOnTop ));
                list.Add("originalHeader", new ConfigOption("originalHeader", null, false, this.OriginalHeader ));
                list.Add("animate", new ConfigOption("animate", null, false, this.Animate ));
                list.Add("autoWidth", new ConfigOption("autoWidth", null, true, this.AutoWidth ));
                list.Add("collapseFirst", new ConfigOption("collapseFirst", null, false, this.CollapseFirst ));
                list.Add("fill", new ConfigOption("fill", null, true, this.Fill ));
                list.Add("hideCollapseTool", new ConfigOption("hideCollapseTool", null, false, this.HideCollapseTool ));
                list.Add("sequence", new ConfigOption("sequence", null, false, this.Sequence ));
                list.Add("titleCollapse", new ConfigOption("titleCollapse", null, true, this.TitleCollapse ));

                return list;
            }
        }
    }
}
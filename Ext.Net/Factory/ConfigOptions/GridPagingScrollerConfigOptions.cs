/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class GridPagingScroller
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
                
                list.Add("scrollToLoadBuffer", new ConfigOption("scrollToLoadBuffer", null, 200, this.ScrollToLoadBuffer ));
                list.Add("numberFromEdge", new ConfigOption("numberFromEdge", new SerializationOptions("numFromEdge"), 2, this.NumberFromEdge ));
                list.Add("trailingBufferZone", new ConfigOption("trailingBufferZone", null, 5, this.TrailingBufferZone ));
                list.Add("leadingBufferZone", new ConfigOption("leadingBufferZone", null, 15, this.LeadingBufferZone ));
                list.Add("variableRowHeight", new ConfigOption("variableRowHeight", null, false, this.VariableRowHeight ));

                return list;
            }
        }
    }
}
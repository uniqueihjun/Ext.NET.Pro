/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class ImageDirectEvents
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
                
                list.Add("complete", new ConfigOption("complete", new SerializationOptions("complete", typeof(DirectEventJsonConverter)), null, this.Complete ));
                list.Add("beforeLoad", new ConfigOption("beforeLoad", new SerializationOptions("beforeload", typeof(DirectEventJsonConverter)), null, this.BeforeLoad ));
                list.Add("resizerResize", new ConfigOption("resizerResize", new SerializationOptions("resizerresize", typeof(DirectEventJsonConverter)), null, this.ResizerResize ));
                list.Add("resizerBeforeResize", new ConfigOption("resizerBeforeResize", new SerializationOptions("resizerbeforeresize", typeof(DirectEventJsonConverter)), null, this.ResizerBeforeResize ));
                list.Add("pan", new ConfigOption("pan", new SerializationOptions("pan", typeof(DirectEventJsonConverter)), null, this.Pan ));
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(DirectEventJsonConverter)), null, this.Click ));
                list.Add("dblClick", new ConfigOption("dblClick", new SerializationOptions("dblclick", typeof(DirectEventJsonConverter)), null, this.DblClick ));

                return list;
            }
        }
    }
}
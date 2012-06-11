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
    public partial class ImageListeners
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
                
                list.Add("complete", new ConfigOption("complete", new SerializationOptions("complete", typeof(ListenerJsonConverter)), null, this.Complete ));
                list.Add("beforeLoad", new ConfigOption("beforeLoad", new SerializationOptions("beforeload", typeof(ListenerJsonConverter)), null, this.BeforeLoad ));
                list.Add("resizerResize", new ConfigOption("resizerResize", new SerializationOptions("resizerresize", typeof(ListenerJsonConverter)), null, this.ResizerResize ));
                list.Add("resizerBeforeResize", new ConfigOption("resizerBeforeResize", new SerializationOptions("resizerbeforeresize", typeof(ListenerJsonConverter)), null, this.ResizerBeforeResize ));
                list.Add("pan", new ConfigOption("pan", new SerializationOptions("pan", typeof(ListenerJsonConverter)), null, this.Pan ));
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(ListenerJsonConverter)), null, this.Click ));
                list.Add("dblClick", new ConfigOption("dblClick", new SerializationOptions("dblclick", typeof(ListenerJsonConverter)), null, this.DblClick ));

                return list;
            }
        }
    }
}
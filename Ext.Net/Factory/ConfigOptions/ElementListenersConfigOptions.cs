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
    public partial class ElementListeners
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
                
                list.Add("dOMActivate", new ConfigOption("dOMActivate", new SerializationOptions("DOMActivate", typeof(ListenerJsonConverter)), null, this.DOMActivate ));
                list.Add("dOMAttrModified", new ConfigOption("dOMAttrModified", new SerializationOptions("DOMAttrModified", typeof(ListenerJsonConverter)), null, this.DOMAttrModified ));
                list.Add("dOMCharacterDataModified", new ConfigOption("dOMCharacterDataModified", new SerializationOptions("DOMCharacterDataModified", typeof(ListenerJsonConverter)), null, this.DOMCharacterDataModified ));
                list.Add("dOMFocusIn", new ConfigOption("dOMFocusIn", new SerializationOptions("DOMFocusIn", typeof(ListenerJsonConverter)), null, this.DOMFocusIn ));
                list.Add("dOMFocusOut", new ConfigOption("dOMFocusOut", new SerializationOptions("DOMFocusOut", typeof(ListenerJsonConverter)), null, this.DOMFocusOut ));
                list.Add("dOMNodeInserted", new ConfigOption("dOMNodeInserted", new SerializationOptions("DOMNodeInserted", typeof(ListenerJsonConverter)), null, this.DOMNodeInserted ));
                list.Add("dOMNodeInsertedIntoDocument", new ConfigOption("dOMNodeInsertedIntoDocument", new SerializationOptions("DOMNodeInsertedIntoDocument", typeof(ListenerJsonConverter)), null, this.DOMNodeInsertedIntoDocument ));
                list.Add("dOMNodeRemoved", new ConfigOption("dOMNodeRemoved", new SerializationOptions("DOMNodeRemoved", typeof(ListenerJsonConverter)), null, this.DOMNodeRemoved ));
                list.Add("dOMNodeRemovedFromDocument", new ConfigOption("dOMNodeRemovedFromDocument", new SerializationOptions("DOMNodeRemovedFromDocument", typeof(ListenerJsonConverter)), null, this.DOMNodeRemovedFromDocument ));
                list.Add("dOMSubtreeModified", new ConfigOption("dOMSubtreeModified", new SerializationOptions("DOMSubtreeModified", typeof(ListenerJsonConverter)), null, this.DOMSubtreeModified ));
                list.Add("abort", new ConfigOption("abort", new SerializationOptions("abort", typeof(ListenerJsonConverter)), null, this.Abort ));
                list.Add("blur", new ConfigOption("blur", new SerializationOptions("blur", typeof(ListenerJsonConverter)), null, this.Blur ));
                list.Add("change", new ConfigOption("change", new SerializationOptions("change", typeof(ListenerJsonConverter)), null, this.Change ));
                list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(ListenerJsonConverter)), null, this.Click ));
                list.Add("dblClick", new ConfigOption("dblClick", new SerializationOptions("dblclick", typeof(ListenerJsonConverter)), null, this.DblClick ));
                list.Add("error", new ConfigOption("error", new SerializationOptions("error", typeof(ListenerJsonConverter)), null, this.Error ));
                list.Add("focus", new ConfigOption("focus", new SerializationOptions("focus", typeof(ListenerJsonConverter)), null, this.Focus ));
                list.Add("keyDown", new ConfigOption("keyDown", new SerializationOptions("keydown", typeof(ListenerJsonConverter)), null, this.KeyDown ));
                list.Add("keyPress", new ConfigOption("keyPress", new SerializationOptions("keypress", typeof(ListenerJsonConverter)), null, this.KeyPress ));
                list.Add("keyUp", new ConfigOption("keyUp", new SerializationOptions("keyup", typeof(ListenerJsonConverter)), null, this.KeyUp ));
                list.Add("load", new ConfigOption("load", new SerializationOptions("load", typeof(ListenerJsonConverter)), null, this.Load ));
                list.Add("mouseDown", new ConfigOption("mouseDown", new SerializationOptions("mousedown", typeof(ListenerJsonConverter)), null, this.MouseDown ));
                list.Add("mouseEnter", new ConfigOption("mouseEnter", new SerializationOptions("mouseenter", typeof(ListenerJsonConverter)), null, this.MouseEnter ));
                list.Add("mouseLeave", new ConfigOption("mouseLeave", new SerializationOptions("mouseleave", typeof(ListenerJsonConverter)), null, this.MouseLeave ));
                list.Add("mouseMove", new ConfigOption("mouseMove", new SerializationOptions("mousemove", typeof(ListenerJsonConverter)), null, this.MouseMove ));
                list.Add("mouseOut", new ConfigOption("mouseOut", new SerializationOptions("mouseout", typeof(ListenerJsonConverter)), null, this.MouseOut ));
                list.Add("mouseOver", new ConfigOption("mouseOver", new SerializationOptions("mouseover", typeof(ListenerJsonConverter)), null, this.MouseOver ));
                list.Add("mouseUp", new ConfigOption("mouseUp", new SerializationOptions("mouseup", typeof(ListenerJsonConverter)), null, this.MouseUp ));
                list.Add("reset", new ConfigOption("reset", new SerializationOptions("reset", typeof(ListenerJsonConverter)), null, this.Reset ));
                list.Add("resize", new ConfigOption("resize", new SerializationOptions("resize", typeof(ListenerJsonConverter)), null, this.Resize ));
                list.Add("scroll", new ConfigOption("scroll", new SerializationOptions("scroll", typeof(ListenerJsonConverter)), null, this.Scroll ));
                list.Add("select", new ConfigOption("select", new SerializationOptions("select", typeof(ListenerJsonConverter)), null, this.Select ));
                list.Add("submit", new ConfigOption("submit", new SerializationOptions("submit", typeof(ListenerJsonConverter)), null, this.Submit ));
                list.Add("unload", new ConfigOption("unload", new SerializationOptions("unload", typeof(ListenerJsonConverter)), null, this.Unload ));

                return list;
            }
        }
    }
}
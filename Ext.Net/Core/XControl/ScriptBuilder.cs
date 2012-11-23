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
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;

using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class XControl
    {
        /*  ScriptBuilder
            -----------------------------------------------------------------------------------------------*/

        internal string GetClientConstructor()
        {
            return this.GetClientConstructor(false, null);
        }

        internal string GetClientConstructor(bool instanceOnly)
        {
            return this.GetClientConstructor(instanceOnly, null);
        }

        internal virtual string GetClientConstructor(bool instanceOnly, string body)
        {
            if (this is ICustomConfigSerialization)
            {
                Observable parent = this.ParentComponent;

                if (parent == null)
                {
                    parent = (Observable)ReflectionUtils.GetTypeOfParent(this, typeof(Observable));
                }

                return (this as ICustomConfigSerialization).ToScript(parent);
            }

            if (this.InstanceOf.IsNotEmpty())
            {
                string template = (instanceOnly) ? "new {1}({2})" : ((this is Component) ? "" : "this.{0}=").ConcatWith("new {1}({2});");

                return string.Format(template, this.ClientID, this.InstanceOf, body ?? this.InitialConfig);
            }

            return "";
        }

        internal string BuildInitScript()
        {
            return (this.IsLazy) ? this.clientInitScript : this.before.ConcatWith(this.clientInitScript, this.after);
        }

        string clientInitScript = "";

		/// <summary>
		/// 
		/// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Description("")]
        public virtual string ClientInitScript
        {
            get
            {
                return (!RequestManager.IsAjaxRequest) ? this.BuildInitScript() : "";
            }
        }
    }
}
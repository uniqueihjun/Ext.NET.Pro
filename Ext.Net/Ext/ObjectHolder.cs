/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing.Design;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Designer(typeof(EmptyDesigner))]
    [Description("")]
    public partial class ObjectHolder : Observable, ICustomConfigSerialization
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ObjectHolder() { }

        private JsonObject items;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Description("")]
        public virtual JsonObject Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new JsonObject();
                }

                return this.items;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string ToScript(Control owner)
        {
            if (this.Items.Count == 0)
            {
                return "";
            }

            return "window.".ConcatWith(this.ClientID, "=", JSON.Serialize(this.Items),";");
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Description("")]
        public void UpdateData()
        {
            RequestManager.EnsureDirectEvent();

            this.AddScript("{0}={1};", this.ClientID, JSON.Serialize(this.Items));
        }
    }
}
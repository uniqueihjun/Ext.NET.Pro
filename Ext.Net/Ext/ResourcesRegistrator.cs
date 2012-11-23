/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.ComponentModel;
using System.Web.UI;
using System.Collections.Generic;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [NonVisualControl]
    [ToolboxData("<{0}:ResourcesRegistrator runat=\"server\" />")]
    [Description("")]
    [ParseChildren(true, "ResourceItems")]
    public partial class ResourcesRegistrator : Observable, ICustomConfigSerialization, IVirtual
    {
        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ResourcesRegistrator() { }

        protected override System.Collections.Generic.List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> list = base.Resources;

                foreach (ClientResourceItem item in this.ResourceItems)
	            {
                    ResourceItem resItem = null;

                    if (!item.IsCss)
                    {
                        resItem = new ClientScriptItem(item.Type, item.PathEmbedded, item.Path);                        
                    }
                    else
                    {
                        resItem = new ClientStyleItem(item.Type, item.PathEmbedded, item.Path); 
                    }

                    resItem.IgnoreResourceMode = true;
                    list.Add(resItem);
	            }

                return list;
            }
        }        

        private List<ClientResourceItem> resources;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual List<ClientResourceItem> ResourceItems
        {
            get
            {
                if (this.resources == null)
                {
                    this.resources = new List<ClientResourceItem>();
                }

                return this.resources;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual string ToScript(Control owner)
        {
            return "";
        }

        public override void AddScript(string script)
        {
            // do not remove
        }
    }
}
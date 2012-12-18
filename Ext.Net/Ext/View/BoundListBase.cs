/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public abstract partial class BoundListBase : AbstractDataView
    {
        /// <summary>
        /// If greater than 0, a Ext.toolbar.Paging is displayed at the bottom of the list and store queries will execute with page start and limit parameters. Defaults to 0.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(0)]
        [NotifyParentProperty(true)]
        [Description("If greater than 0, a Ext.toolbar.Paging is displayed at the bottom of the list and store queries will execute with page start and limit parameters. Defaults to 0.")]
        public int PageSize
        {
            get
            {
                return this.State.Get<int>("PageSize", 0);
            }
            set
            {
                this.State.Set("PageSize", value);
            }
        }

        private XTemplate itemTpl;

        /// <summary>
        /// The inner portion of the item template to be rendered. Follows an XTemplate structure and will be placed inside of a tpl.
        /// </summary>
        [Meta]
        [Category("4. AbstractDataView")]
        [DefaultValue(null)]
        [ConfigOption(JsonMode.Ignore)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The inner portion of the item template to be rendered. Follows an XTemplate structure and will be placed inside of a tpl.")]
        public override XTemplate ItemTpl
        {
            get
            {
                return this.itemTpl;
            }
            set
            {
                if (value != null)
                {
                    value.EnableViewState = false;
                    value.Visible = false;
                }

                this.itemTpl = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("getInnerTpl", JsonMode.Raw)]
        [DefaultValue("")]
        protected virtual string ItemTplProxy
        {
            get
            {
                if (this.ItemTpl == null || this.ItemTpl.IsDefault)
                {
                    return "";
                }

                if (this.ItemTpl.Functions.Count > 0)
                {
                    throw new Exception(ServiceMessages.ITEMTEMPLATE_FUNCTIONS);
                }

                return string.Format("<!token>function(){{return {0};}}", JSON.Serialize(this.ItemTpl.TemplateString(false)));
            }
        }       
    }
}

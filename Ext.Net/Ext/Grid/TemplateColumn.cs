/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class TemplateColumn : Column
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TemplateColumn() { }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("xtype")]
        [DefaultValue("")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "templatecolumn";
            }
        }

        private XTemplate template;

        /// <summary>
        /// An XTemplate to use to process a Record's data to produce a column's rendered value.
        /// </summary>
        [Category("3. TemplateColumn")]
        [ConfigOption("tpl", typeof(LazyControlJsonConverter))]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(" An XTemplate to use to process a Record's data to produce a column's rendered value.")]
        public virtual XTemplate Template
        {
            get
            {
                if (this.IsSerialize)
                {
                    return null;
                }

                if (this.template == null)
                {
                    this.template = new XTemplate();

                    if (this.ParentGrid != null)
                    {
                        this.ParentGrid.Controls.Add(this.template);
                        this.ParentGrid.LazyItems.Add(this.template);
                    }
                }

                return this.template;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("tpl", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected virtual string TemplateSerializationProxy
        {
            get
            {
                if (!this.IsSerialize || this.template == null || this.template.Html.IsEmpty())
                {
                    return "";
                }

                return this.template.ToConfig(LazyMode.Instance);
            }
        }
    }
}
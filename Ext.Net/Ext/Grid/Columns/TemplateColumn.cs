/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A Column definition class which renders a value by processing a Model's data using a configured XTemplate.
    /// </summary>
    [Meta]
    [Description("")]
    public partial class TemplateColumn : CellCommandColumn
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TemplateColumn() { }

		/// <summary>
		/// 
		/// </summary>
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
        /// An XTemplate, or an XTemplate definition string to use to process a Model's data to produce a column's rendered value.
        /// </summary>
        [Meta]
        [Category("3. TemplateColumn")]
        [ConfigOption("tpl", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An XTemplate, or an XTemplate definition string to use to process a Model's data to produce a column's rendered value.")]
        public virtual XTemplate Template
        {
            get
            {
                if (this.template == null)
                {
                    this.template = new XTemplate();
                    this.template.EnableViewState = false;
                    this.Controls.Add(this.template);
                    this.LazyItems.Add(this.template);
                }

                return this.template;
            }
        }

        /// <summary>
        /// An XTemplate, or an XTemplate definition string to use to process a Model's data to produce a column's rendered value.
        /// </summary>
        [Meta]
        [ConfigOption("tpl")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("An XTemplate, or an XTemplate definition string to use to process a Model's data to produce a column's rendered value.")]
        public virtual string TemplateString
        {
            get
            {
                return this.State.Get<string>("TemplateString", "");
            }
            set
            {
                this.State.Set("TemplateString", value);
            }
        }
    }
}
/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class ColumnTreeColumn : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ColumnTreeColumn() { }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("1. ColumnTreeColumn")]
        [DefaultValue(null)]
        [Description("")]
        public virtual string DataIndex
        {
            get
            {
                object obj = this.ViewState["DataIndex"];
                return (obj == null) ? null : (string)obj;
            }
            set
            {
                this.ViewState["DataIndex"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("1. ColumnTreeColumn")]
        [DefaultValue("")]
        [Description("")]
        public virtual string Header
        {
            get
            {
                object obj = this.ViewState["Header"];
                return (obj == null) ? "" : (string)obj;
            }
            set
            {
                this.ViewState["Header"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("1. ColumnTreeColumn")]
        [DefaultValue("")]
        [Description("")]
        public virtual string Cls
        {
            get
            {
                object obj = this.ViewState["Cls"];
                return (obj == null) ? "" : (string)obj;
            }
            set
            {
                this.ViewState["Cls"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("1. ColumnTreeColumn")]
        [DefaultValue(0)]
        [Description("")]
        public virtual int Width
        {
            get
            {
                object obj = this.ViewState["Width"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["Width"] = value;
            }
        }

        private Renderer renderer;

        /// <summary>
        /// (optional) A function used to generate HTML markup for a node
        /// </summary>
        [Meta]
        [ConfigOption(typeof(RendererJsonConverter))]
        [Category("2. ColumnBase")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ViewStateMember]
        [Description("(optional) A function used to generate HTML markup for a node.")]
        public virtual Renderer Renderer
        {
            get
            {
                if (this.renderer == null)
                {
                    this.renderer = new Renderer();
                    if (!this.DesignMode)
                    {
                        this.renderer.Args = new string[] {"value", "node", "attrs"};
                    }
                }

                return this.renderer;
            }
            set
            {
                this.renderer = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ColumnTreeColumnCollection : StateManagedCollection<ColumnTreeColumn> { }
}
/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// Every layout is composed of one or more Ext.Container elements internally, and Layout provides the basic foundation for all other layout classes in Ext. It is a non-visual class that simply provides the base logic required for a Container to function as a layout.
    /// </summary>
    [Meta]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [Description("Every layout is composed of one or more Ext.Container elements internally, and Layout provides the basic foundation for all other layout classes in Ext. It is a non-visual class that simply provides the base logic required for a Container to function as a layout.")]
    public abstract partial class Layout : Component
    {
        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "";
            }
        }
        
        /// <summary>
        /// The layout type to be used in this Body Container. If not specified, a default is Container. Specific config values for the chosen layout type can be specified using layoutConfig.
        /// </summary>
        [Category("4. Layout")]
        [DefaultValue("container")]
        [Browsable(false)]
        [Description("The layout type to be used in this Body Container. If not specified, a default is Container. Specific config values for the chosen layout type can be specified using layoutConfig.")]
        public virtual string LayoutType
        {
            get
            {
                return "container";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("layout")]
        [DefaultValue("container")]
        [Description("")]
        protected string LayoutTypeProxy
        {
            get
            {
                return this.LayoutType;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public override Unit Height
        {
            get 
            { 
                return base.Height; 
            }
            set 
            { 
                base.Height = value; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public override Unit Width
        {
            get 
            { 
                return base.Width; 
            }
            set 
            { 
                base.Width = value; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Ignore)]
        [Description("")]
        protected override string ConfigIDProxy
        {
            get
            {
                return base.ConfigIDProxy;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Ignore)]
        [Description("")]
        protected internal override string RenderToProxy
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// An optional extra CSS class that will be added to the content Container (defaults to ''). This can be useful for adding customized styles to the content Container or any of its children using standard CSS rules.
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Ignore)]
        [Category("4. Layout")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]                
        [Description("An optional extra CSS class that will be added to the content Container (defaults to ''). This can be useful for adding customized styles to the content Container or any of its children using standard CSS rules.")]
        public virtual string ExtraCls
        {
            get
            {
                return (string)this.ViewState["ExtraCls"] ?? "";
            }
            set
            {
                this.ViewState["ExtraCls"] = value;
            }
        }

        /// <summary>
        /// True to hide each contained items on render (defaults to false).
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Ignore)]
        [Category("4. Layout")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]                
        [Description("True to hide each contained items on render (defaults to false).")]
        public virtual bool RenderHidden
        {
            get
            {
                object obj = this.ViewState["RenderHidden"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["RenderHidden"] = value;
            }
        }

        ItemsCollection<Component> items;

        /// <summary>
        /// Items collection
        /// </summary>
        [Meta]
        [Category("4. Layout")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Items collection")]
        public virtual ItemsCollection<Component> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new ItemsCollection<Component>();
                    this.items.AfterItemAdd += AfterItemAdd;
                    this.items.AfterItemRemove += AfterItemRemove;
                    this.items.SingleItemMode = this.SingleItemMode;
                }

                return this.items;
            }
        }
    }
}
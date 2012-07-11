/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Composite field allowing a number of form Fields to be rendered on the same row. The fields are rendered using an hbox layout internally, so all of the normal HBox layout config items are available.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:CompositeField runat=\"server\"></{0}:CompositeField>")]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(CompositeField), "Build.ToolboxIcons.MultiField.bmp")]
    [Description("Composite field allowing a number of form Fields to be rendered on the same row. The fields are rendered using an hbox layout internally, so all of the normal HBox layout config items are available.")]   
    public partial class CompositeField : Field
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public CompositeField() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "compositefield";
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
                return "Ext.form.CompositeField";
            }
        }

        private HBoxLayoutConfig layoutConfig;

        /// <summary>
        /// Layout config of the inner hbox layout
        /// </summary>
        [ConfigOption(JsonMode.Object)]
        [Category("6. CompositeField")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("Layout config of the inner hbox layout")]
        public HBoxLayoutConfig LayoutConfig
        {
            get
            {
                if (this.layoutConfig == null)
                {
                    this.layoutConfig = new HBoxLayoutConfig();
                }

                return this.layoutConfig;
            }
        }

        /// Added new AutoDoLayout property to Container. If .AutoDoLayout is true, the .doLayout() function will be called in the afterrender event. Default is false.
        /// </new>
        /// <summary>
        /// If true .doLayout() is called after render. Default is false.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. CompositeField")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("If true .doLayout() is called after render. Default is false.")]
        public virtual bool AutoDoLayout
        {
            get
            {
                object obj = this.ViewState["AutoDoLayout"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["AutoDoLayout"] = value;
            }
        }

        private JFunction buildLabel;

        /// <summary>
        /// Builds a label string from an array of subfield labels. Calls if CompositeField has no FieldLabel
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [Category("6. CompositeField")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Description("Builds a label string from an array of subfield labels. Calls if CompositeField has no FieldLabel")]
        public virtual JFunction BuildLabel
        {
            get
            {
                if (this.buildLabel == null)
                {
                    this.buildLabel = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.buildLabel.Args = new string[] { "segments" };
                    }
                }

                return this.buildLabel;
            }
        }
        
        private ItemsCollection<Component> items;

        /// <summary>
        /// A Collection of Field Components.
        /// </summary>
        [Meta]
        [ConfigOption("items", typeof(ItemCollectionJsonConverter))]
        [Category("6. CompositeField")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("A Collection of Field Components.")]
        public virtual ItemsCollection<Component> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new ItemsCollection<Component>();
                    this.items.AfterItemAdd += this.AfterItemAdd;
                    this.items.AfterItemRemove += this.AfterItemRemove;
                }

                return this.items;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        [Description("")]
        protected override void AfterItemAdd(Observable item)
        {
            if (item is CompositeField)
            {
                throw new Exception(string.Format("CompositeField (ID : {0}) can not contains another CompositeField Component.", this.ID));
            }

            item.LazyMode = LazyMode.Instance;

            base.AfterItemAdd(item);
        }

        /// <summary>
        ///  The margins to apply by default to each field in the composite
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. CompositeField")]
        [DefaultValue("0 5 0 0")]
        [NotifyParentProperty(true)]
        [Description("The margins to apply by default to each field in the composite")]
        public virtual string DefaultMargins
        {
            get
            {
                return (string)this.ViewState["DefaultMargins"] ?? "0 5 0 0";
            }
            set
            {
                this.ViewState["DefaultMargins"] = value;
            }
        }

        /// <summary>
        /// If true, the defaultMargins are not applied to the last item in the composite field set (defaults to true)
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. CompositeField")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("If true, the defaultMargins are not applied to the last item in the composite field set (defaults to true)")]
        public virtual bool SkipLastItemMargin
        {
            get
            {
                object obj = this.ViewState["SkipLastItemMargin"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["SkipLastItemMargin"] = value;
            }
        }

        /// <summary>
        /// True to combine errors from the individual fields into a single error message at the CompositeField level (defaults to true)
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. CompositeField")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to combine errors from the individual fields into a single error message at the CompositeField level (defaults to true)")]
        public virtual bool CombineErrors
        {
            get
            {
                object obj = this.ViewState["CombineErrors"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["CombineErrors"] = value;
            }
        }

        /// <summary>
        ///  The string to use when joining segments of the built label together (defaults to ', ')
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. CompositeField")]
        [DefaultValue(", ")]
        [NotifyParentProperty(true)]
        [Description("The string to use when joining segments of the built label together (defaults to ', ')")]
        public virtual string LabelConnector
        {
            get
            {
                return (string)this.ViewState["LabelConnector"] ?? ", ";
            }
            set
            {
                this.ViewState["LabelConnector"] = value;
            }
        }

        private ParameterCollection defaults;

        /// <summary>
        /// A config object that will be applied to all fields added to this CompositeField either via the items config. The defaults config can contain any number of name/value property pairs to be added to each items, and should be valid for the types of items being added to the CompositeField.
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.ArrayToObject)]
        [Category("6. CompositeField")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("A config object that will be applied to all fields added to this CompositeField either via the items config. The defaults config can contain any number of name/value property pairs to be added to each items, and should be valid for the types of items being added to the CompositeField.")]
        public virtual ParameterCollection Defaults
        {
            get
            {
                if (this.defaults == null)
                {
                    this.defaults = new ParameterCollection(true);
                    this.defaults.Owner = this;
                    this.defaults.AfterItemAdd += Defaults_AfterItemAdd;
                }

                return this.defaults;
            }
        }

        void Defaults_AfterItemAdd(Parameter item)
        {
            item.CamelName = true;
        }


        /*  Listeners & DirectEvents
            -----------------------------------------------------------------------------------------------*/

        private CompositeFieldListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ViewStateMember]
        [Description("Client-side JavaScript Event Handlers")]
        public CompositeFieldListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new CompositeFieldListeners();
                }

                return this.listeners;
            }
        }

        private CompositeFieldDirectEvents directEvents;

        /// <summary>
        /// Server-side Ajax Event Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [ViewStateMember]
        [Description("Server-side Ajax Event Handlers")]
        public CompositeFieldDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new CompositeFieldDirectEvents();
                }

                return this.directEvents;
            }
        }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Force this container's layout to be recalculated. A call to this function is required after adding a new component to an already rendered container, or possibly after changing sizing/position properties of child components.
        /// </summary>
        [Meta]
        [Description("Force this container's layout to be recalculated. A call to this function is required after adding a new component to an already rendered container, or possibly after changing sizing/position properties of child components.")]
        public virtual void DoLayout()
        {
            this.Call("doLayout");
        }

        /// <summary>
        /// Force this container's layout to be recalculated. A call to this function is required after adding a new component to an already rendered container, or possibly after changing sizing/position properties of child components.
        /// </summary>
        [Meta]
        [Description("Force this container's layout to be recalculated. A call to this function is required after adding a new component to an already rendered container, or possibly after changing sizing/position properties of child components.")]
        public virtual void DoLayout(bool shallow)
        {
            this.Call("doLayout", shallow);
        }

        /// <summary>
        /// Force this container's layout to be recalculated. A call to this function is required after adding a new component to an already rendered container, or possibly after changing sizing/position properties of child components.
        /// </summary>
        /// <param name="shallow"></param>
        /// <param name="force"></param>
        [Meta]
        [Description("Force this container's layout to be recalculated. A call to this function is required after adding a new component to an already rendered container, or possibly after changing sizing/position properties of child components.")]
        public virtual void DoLayout(bool shallow, bool force)
        {
            this.Call("doLayout", shallow, force);
        }
    }
}

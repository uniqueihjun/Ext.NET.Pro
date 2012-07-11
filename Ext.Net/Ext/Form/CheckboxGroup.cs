/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A grouping container for Ext.form.Checkbox controls.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:CheckboxGroup runat=\"server\" />")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(CheckboxGroup), "Build.ToolboxIcons.CheckboxGroup.bmp")]
    [Description("A grouping container for Ext.form.Checkbox controls.")]
    public partial class CheckboxGroup : CheckboxGroupBase, IItems
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CheckboxGroup() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "checkboxgroup";
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
                return "Ext.form.CheckboxGroup";
            }
        }

        /// <summary>
        /// The default type of content Container represented by this object as registered in Ext.ComponentMgr (defaults to 'checkbox').
        /// </summary>
        [Meta]
        [Category("5. Container")]
        [DefaultValue("Checkbox")]
        [TypeConverter(typeof(DefaultTypeConverter))]
        [NotifyParentProperty(true)]
        [Description("The default type of content Container represented by this object as registered in Ext.ComponentMgr (defaults to 'checkbox').")]
        public virtual string DefaultType
        {
            get
            {
                return (string)this.ViewState["DefaultType"] ?? "Checkbox";
            }
            set
            {
                this.ViewState["DefaultType"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("defaultType")]
        [DefaultValue("checkbox")]
        [Description("")]
        protected virtual string DefaultTypeProxy
        {
            get
            {
                return DefaultTypeConverter.GetXType(this.DefaultType);
            }
        }

        private CheckboxGroupListeners listeners;

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
        public CheckboxGroupListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new CheckboxGroupListeners();
                }

                return this.listeners;
            }
        }

        private CheckboxGroupDirectEvents directEvents;

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
        public CheckboxGroupDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new CheckboxGroupDirectEvents();
                }

                return this.directEvents;
            }
        }
        
        ItemsCollection<Checkbox> items;

        /// <summary>
        /// Items collection
        /// </summary>
        [Meta]
        [ConfigOption("items", typeof(ItemCollectionJsonConverter))]
        [Category("6. CheckboxGroup")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Items collection")]
        public virtual ItemsCollection<Checkbox> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new ItemsCollection<Checkbox>();
                    this.items.AfterItemAdd += AfterItemAdd;
                    this.items.AfterItemRemove += AfterItemRemove;
                }

                return this.items;
            }
        }

        IList IItems.ItemsList
        {
            get
            {
                return this.Items;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A List of Checkbox Controls in this CheckboxGroup that are Checked.")]
        public virtual List<Checkbox> CheckedItems
        {
            get
            {
                return Utilities.ControlUtils.FindControls<Checkbox>(this).FindAll(cb => cb.Checked);

                // TODO: OK... just in case rollback to .NET 2.0 pureness is required, see also RadioGroup.CheckedItems.
                //return Utilities.ControlUtils.FindControls<Checkbox>(this).FindAll(delegate(Checkbox checkbox)
                //{
                //    return checkbox.Checked;
                //});
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public virtual List<string> CheckedTags
        {
            get
            {
                return Utilities.ControlUtils.FindControls<Checkbox>(this).FindAll(cb => cb.Checked).ConvertAll(checkbox => checkbox.Tag);
            }
        }


        /*  DirectEvent Handler
            -----------------------------------------------------------------------------------------------*/

        static CheckboxGroup()
        {
            DirectEventChange = new object();
        }

        private static readonly object DirectEventChange;

        /// <summary>
        /// Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).
        /// </summary>
        [Description("Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).")]
        public event ComponentDirectEvent.DirectEventHandler DirectChange
        {
            add
            {
                this.DirectEvents.Change.Event += value;
            }
            remove
            {
                this.DirectEvents.Change.Event -= value;
            }
        }
    }
}
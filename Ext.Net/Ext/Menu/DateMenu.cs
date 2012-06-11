/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A menu containing a Ext.picker.Date component.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A menu containing a Ext.picker.Date component.")]
    public partial class DateMenu : MenuBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public DateMenu()
        {
            this.picker = new DatePicker();
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            this.Controls.Add(this.picker);
            this.LazyItems.Add(this.picker);
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "datemenu";
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
                return "Ext.menu.DatePicker";
            }
        }

        /// <summary>
        /// False to continue showing the menu after a date is selected, defaults to true.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DateMenu")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("False to continue showing the menu after a date is selected, defaults to true.")]
        public virtual bool HideOnClick
        {
            get
            {
                return this.State.Get<bool>("HideOnClick", true);
            }
            set
            {
                this.State.Set("HideOnClick", value);
            }
        }

        private DatePicker picker;

        /// <summary>
        /// The Ext.DatePicker object
        /// </summary>
        [Meta]
        [ConfigOption("pickerConfig", typeof(LazyControlJsonConverter))]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("The Ext.DatePicker object")]
        public DatePicker Picker
        {
            get
            {
                return this.picker;
            }
        }
        
        private DateMenuListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]        
        [Description("Client-side JavaScript Event Handlers")]
        public DateMenuListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new DateMenuListeners();
                }

                return this.listeners;
            }
        }


        private DateMenuDirectEvents directEvents;

        /// <summary>
        /// Server-side DirectEvent Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]        
        [Description("Server-side DirectEventHandlers")]
        public DateMenuDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new DateMenuDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}
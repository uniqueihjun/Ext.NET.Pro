/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A menu containing a Ext.picker.Color Component.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A menu containing a Ext.picker.Color Component.")]
    public partial class ColorMenu : MenuBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public ColorMenu()
        {
            this.palette = new ColorPicker();
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
                return "colormenu";
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
                return "Ext.menu.ColorPicker";
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            this.Controls.Add(this.palette);
            this.LazyItems.Add(this.palette);
        }

        private ColorPicker palette;

        /// <summary>
        /// The ColorPicker object
        /// </summary>
        [Meta]
        [ConfigOption("pickerConfig", typeof(LazyControlJsonConverter))]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("The ColorPalette object")]
        public ColorPicker Picker
        {
            get
            {
                return this.palette;
            }
        }
        
        private ColorMenuListeners listeners;

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
        public ColorMenuListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new ColorMenuListeners();
                }

                return this.listeners;
            }
        }

        private ColorMenuDirectEvents directEvents;

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
        public ColorMenuDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new ColorMenuDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}

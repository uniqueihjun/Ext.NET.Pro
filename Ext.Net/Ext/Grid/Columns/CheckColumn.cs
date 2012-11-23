/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;
using System;

namespace Ext.Net
{
    /// <summary>
    /// A Column subclass which renders a checkbox in each column cell which toggles the truthiness of the associated data field on click.
    /// </summary>
    [Meta]
    [Description("")]
    public partial class CheckColumn : ColumnBase, INoneEditable
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CheckColumn() { }

		/// <summary>
		/// 
		/// </summary>        
        [DefaultValue("")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "checkcolumn";
            }
        }

        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

            if (this.Editor.Primary != null && !this.IsRowEditing)
            {
                throw new Exception("CheckColumn doesn't support Editor as cell editor. Please use Editable property");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. CheckColumn")]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool Editable
        {
            get
            {
                return this.State.Get<bool>("Editable", false);
            }
            set
            {
                this.State.Set("Editable", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. CheckColumn")]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool SingleSelect
        {
            get
            {
                return this.State.Get<bool>("SingleSelect", false);
            }
            set
            {
                this.State.Set("SingleSelect", value);
            }
        }

        /// <summary>
        /// Prevent grid selection upon mousedown.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("3. CheckColumn")]
        [DefaultValue(true)]
        [Description("")]
        public virtual bool StopSelection
        {
            get
            {
                return this.State.Get<bool>("SingleSelect", true);
            }
            set
            {
                this.State.Set("SingleSelect", value);
            }
        }

        private CheckColumnListeners listeners;

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
        public CheckColumnListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new CheckColumnListeners();
                }

                return this.listeners;
            }
        }

        private CheckColumnDirectEvents directEvents;

        /// <summary>
        /// Server-side Ajax Event Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [Description("Server-side Ajax Event Handlers")]
        public CheckColumnDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new CheckColumnDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}

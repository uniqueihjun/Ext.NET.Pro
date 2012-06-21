/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A control that allows selection and form submission of multiple list items.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:MultiSelect runat=\"server\"></{0}:MultiSelect>")]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(MultiSelect), "Build.ToolboxIcons.MultiSelect.bmp")]
    [Description("A control that allows selection and form submission of multiple list items.")]
    public partial class MultiSelect : MultiSelectBase, IPostBackEventHandler
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public MultiSelect() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 3;

                baseList.Add(new ClientScriptItem(typeof(MultiSelect), "Ext.Net.Build.Ext.Net.ux.multiselect.multiselect.js", "/ux/multiselect/multiselect.js"));

                return baseList;
            }
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
                return "multiselect";
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
                return "Ext.ux.form.MultiSelect";
            }
        }
        
        private MultiSelectListeners listeners;

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
        public MultiSelectListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new MultiSelectListeners();
                }

                return this.listeners;
            }
        }


        private MultiSelectDirectEvents directEvents;

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
        public MultiSelectDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new MultiSelectDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}

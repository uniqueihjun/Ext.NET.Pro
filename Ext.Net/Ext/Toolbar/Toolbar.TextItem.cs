/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A simple class that renders text directly into a toolbar.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A simple class that renders text directly into a toolbar.")]
    public partial class ToolbarTextItem : ToolbarItem
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public ToolbarTextItem() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "tbtext";
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
                return "Ext.toolbar.TextItem";
            }
        }

        /// <summary>
        /// The text to be used as innerHTML (html tags are accepted). Defaults to: ""
        /// </summary>
        [Meta]
        [ConfigOption]
        [DirectEventUpdate(MethodName = "SetText")]
        [Category("Config Options")]
        [DefaultValue("")]
        [Description("The text to be used as innerHTML (html tags are accepted). Defaults to: \"\"")]
        public virtual string Text
        {
            get
            {
                return this.State.Get<string>("Text", "");
            }
            set
            {
                this.State.Set("Text", value);
            }
        }


        /*  Public Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Updates this item's text, setting the text to be used as innerHTML.
        /// </summary>
        [Description("Updates this item's text, setting the text to be used as innerHTML.")]
        protected virtual void SetText(string text)
        {
            this.Call("setText", text);
        }

        private AbstractComponentListeners listeners;

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
        public AbstractComponentListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new AbstractComponentListeners();
                }

                return this.listeners;
            }
        }

        private AbstractComponentDirectEvents directEvents;

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
        public AbstractComponentDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new AbstractComponentDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}
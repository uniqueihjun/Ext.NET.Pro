/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A combobox control with support for autocomplete, remote-loading, paging and many other features.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:ComboBox runat=\"server\"></{0}:ComboBox>")]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [SupportsEventValidation]
    [ValidationProperty("SelectedItem")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(ComboBox), "Build.ToolboxIcons.ComboBox.bmp")]
    [Description("A combobox control with support for autocomplete, remote-loading, paging and many other features.")]
    public partial class ComboBox : ComboBoxBaseSingle<ListItem>, IPostBackEventHandler
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public ComboBox() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.form.ComboBox";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        [Description("")]
        protected override void OnBeforeClientInit(Observable sender)
        {
            this.InitPostBack();

            if ((this.StoreID.IsNotEmpty() || this.Store.Primary != null))
            {
                if(this.IsDynamic)
                {
                    return;
                }

                Store store = this.Store.Primary ?? ControlUtils.FindControl<Store>(this, this.StoreID, true);

                if (store == null)
                {
                    throw new InvalidOperationException("The Control '{0}' could not find the StoreID of '{1}'.".FormatWith(this.ID, this.StoreID));
                }
            }
            else
            {
                this.TriggerAction = TriggerAction.All;
                this.Mode = DataLoadMode.Local;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="postDataKey"></param>
        /// <param name="postCollection"></param>
        /// <returns></returns>
        [Description("")]
        protected override bool LoadPostData(string postDataKey, NameValueCollection postCollection)
        {
            this.HasLoadPostData = true;

            string val = postCollection[this.HiddenName];
            string text = postCollection[this.UniqueName];
            string index = postCollection[this.UniqueName.ConcatWith("_SelIndex")] ?? "";

            this.SuspendScripting();
            this.RawValue = val;
            this.ResumeScripting();

            if (val == null && text == null)
            {
                return false;
            }

            if (!this.EmptyText.Equals(text) && (this.SelectedItem.Value == null || !this.SelectedItem.Value.Equals(val) || this.SelectedItem.Text == null || !this.SelectedItem.Text.Equals(text)))
            {
                try
                {
                    this.SuspendScripting();
                    this.SelectedItem.Text = text;
                    this.SelectedItem.Value = val;

                    int tmpIndex;

                    if (int.TryParse(index, out tmpIndex))
                    {
                        this.SelectedIndex = tmpIndex;
                    }
                }
                finally
                {
                    this.ResumeScripting();
                }

                return true;
            }
            else
            {
                if (this.EmptyText.Equals(text) && (this.SelectedItem.Value.IsNotEmpty() || this.SelectedItem.Text.IsNotEmpty()))
                {
                    try
                    {
                        this.SuspendScripting();
                        this.SelectedItem.Text = "";
                        this.SelectedItem.Value = null;
                        this.SelectedIndex = -1;
                    }
                    finally
                    {
                        this.RawValue = val;
                        this.ResumeScripting();
                    }

                    return true;
                }
            }

            return false;
        }

        protected override void RaisePostDataChangedEvent()
        {
            this.OnValueChanged(EventArgs.Empty);
        }

        public override void RaisePostBackEvent(string eventArgument)
        {
            switch (eventArgument)
            {
                case "select":
                    this.OnItemSelected(EventArgs.Empty);
                    break;
                case "change":
                    this.OnValueChanged(EventArgs.Empty);
                    break;
                default:
                    int index;

                    if (int.TryParse(eventArgument, out index))
                    {
                        this.OnTriggerClicked(new TriggerEventArgs(index));
                    }
                    break;
            }
        }

        private ComboBoxListeners listeners;

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
        public ComboBoxListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new ComboBoxListeners();
                }

                return this.listeners;
            }
        }

        private ComboBoxDirectEvents directEvents;

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
        public ComboBoxDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new ComboBoxDirectEvents();
                }

                return this.directEvents;
            }
        }


        /*  DirectEvent Handler
            -----------------------------------------------------------------------------------------------*/

        static ComboBox()
        {
            DirectEventSelect = new object();
        }

        private static readonly object DirectEventSelect;

        /// <summary>
        /// Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).
        /// </summary>
        [Description("Server-side DirectEvent handler. Method signature is (object sender, DirectEventArgs e).")]
        public event ComponentDirectEvent.DirectEventHandler DirectSelect
        {
            add
            {
                this.DirectEvents.Select.Event += value;
            }
            remove
            {
                this.DirectEvents.Select.Event -= value;
            }
        }
    }
}
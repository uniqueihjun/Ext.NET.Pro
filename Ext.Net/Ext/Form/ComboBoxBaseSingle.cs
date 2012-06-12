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
	[Description("")]
    public abstract partial class ComboBoxBaseSingle<T> : ComboBoxBase<T> where T : StateManagedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public override object Value
        {
            get
            {
                return this.SelectedItem.Value;
            }
            set
            {
                this.SelectedItem.Value = value == null ? null : value.ToString();
            }
        }

        private ListItem selectedItem;

        /// <summary>
        /// 
        /// </summary>
        [Category("Appearance")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [ViewStateMember]
        [DefaultValue(null)]
        [Description("")]
        public virtual ListItem SelectedItem
        {
            get
            {
                if (this.selectedItem == null)
                {
                    this.selectedItem = new ListItem(this);
                }

                return this.selectedItem;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("8. ComboBox")]
        [DirectEventUpdate(MethodName = "SetSelectedIndex")]
        [DefaultValue(-1)]
        [Description("")]
        public virtual int SelectedIndex
        {
            get
            {
                object obj = this.ViewState["SelectedIndex"];
                return (obj == null) ? -1 : (int)obj;
            }
            set
            {
                this.ViewState["SelectedIndex"] = value;
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
		[ConfigOption("initSelectedIndex")]
        [DefaultValue(-1)]
        [Description("")]
        protected virtual int SelectedIndexProperty
        {
            get
            {
                if (string.IsNullOrEmpty(this.SelectedItem.Value))
                {
                    return this.SelectedIndex;
                }

                return -1;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        [Description("")]
        protected virtual void SetSelectedIndex(int index)
        {
            this.Call("selectByIndex", index);
        }
    }
}
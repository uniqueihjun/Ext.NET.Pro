/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Text;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class HeaderColumn : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public HeaderColumn() { }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("target", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected string TargetProxy
        {
            get
            {
                if (this.Target.IsEmpty())
                {
                    return "";
                }

                return "Ext.net.getEl(".ConcatWith(TokenUtils.ParseAndNormalize(this.Target, this.Owner), ")");
            }
        }

        /// <summary>
        /// The target element which will be placed to the header.
        /// </summary>
        [Meta]
        [Category("3. GridView")]
        [DefaultValue("")]
        [Description("The target element which will be placed to the header.")]
        public virtual string Target
        {
            get
            {
                return (string)this.ViewState["Target"] ?? "";
            }
            set
            {
                this.ViewState["Target"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("autoWidth")]
        [Category("3. GridView")]
        [DefaultValue(true)]
        [Description("")]
        public virtual bool AutoWidthElement
        {
            get
            {
                object obj = this.ViewState["AutoWidthElement"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["AutoWidthElement"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("correction")]
        [Category("3. GridView")]
        [DefaultValue(3)]
        [Description("")]
        public virtual int AutoWidthCorrection
        {
            get
            {
                object obj = this.ViewState["AutoWidthCorrection"];
                return (obj == null) ? 3 : (int)obj;
            }
            set
            {
                this.ViewState["AutoWidthCorrection"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue("")]
        [Description("")]
        public virtual string Cls
        {
            get
            {
                return (string)this.ViewState["Cls"] ?? "";
            }
            set
            {
                this.ViewState["Cls"] = value;
            }
        }

        ItemsCollection<Component> component;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Category("3. GridView")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("component", typeof(ItemCollectionJsonConverter))]
        [Description("")]
        public virtual ItemsCollection<Component> Component
        {
            get
            {
                if (this.component == null)
                {
                    this.component = new ItemsCollection<Component>();
                    this.component.SingleItemMode = true;
                }

                return this.component;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class HeaderColumnCollection : StateManagedCollection<HeaderColumn> { }
}

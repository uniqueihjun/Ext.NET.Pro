/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Linq;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// A Grid header type which renders an icon, or a series of icons in a grid cell, and offers a scoped click handler for each icon.
    /// The action column can be at any index in the columns array, and a grid can have any number of action columns.
    /// </summary>
    [Meta]
    public partial class ActionColumn : ColumnBase, IIcon, INoneEditable
    {
        /// <summary>
        /// 
		/// </summary>
		[Description("")]
        public ActionColumn() { }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "actioncolumn";
            }
        }

        /// <summary>
        /// The alt text to use for the image element. Defaults to ''.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The alt text to use for the image element. Defaults to ''.")]
        public virtual string AltText
        {
            get
            {
                return this.State.Get<string>("AltText", "");
            }
            set
            {
                this.State.Set("AltText", value);
            }
        }

        /// <summary>
        /// Defaults to true. Prevent grid row selection upon mousedown.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(true)]
        [Description("Defaults to true. Prevent grid row selection upon mousedown.")]
        public virtual bool StopSelection
        {
            get
            {
                return this.State.Get<bool>("StopSelection", true);
            }
            set
            {
                this.State.Set("StopSelection", value);
            }
        }

        private ActionItemCollection items;

        /// <summary>
        /// An Array which may contain multiple icon definitions
        /// </summary>
        [Meta]
        [ConfigOption("items", JsonMode.AlwaysArray)]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]        
        [Description("")]
        public virtual ActionItemCollection Items
        {
            get
            {
                return this.items ?? (this.items = new ActionItemCollection());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual System.Collections.Generic.List<Icon> Icons
        {
            get
            {
                return (from item in this.Items where item.Icon != Icon.None select item.Icon).ToList();
            }
        }

        /// <summary>
        /// Disables this ActionColumn's action at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="silent"></param>
        public virtual void DisableAction(int index, bool silent)
        {
            this.Call("disableAction", index, silent);
        }

        /// <summary>
        /// Disables this ActionColumn's action at the specified index.
        /// </summary>
        /// <param name="index"></param>
        public virtual void DisableAction(int index)
        {
            this.Call("disableAction", index);
        }

        /// <summary>
        /// Enables this ActionColumn's action at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="silent"></param>
        public virtual void EnableAction(int index, bool silent)
        {
            this.Call("enableAction", index, silent);
        }

        /// <summary>
        /// Enables this ActionColumn's action at the specified index.
        /// </summary>
        /// <param name="index"></param>
        public virtual void EnableAction(int index)
        {
            this.Call("enableAction", index);
        }
    }
}

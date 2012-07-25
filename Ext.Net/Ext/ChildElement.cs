/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// The child element of the Component. It is used as an item of the AbstractComponenn's ChildEls.
    /// </summary>
    [Meta]
    [Description("The child element of the Component. It is used as an item of the AbstractComponenn's ChildEls.")]
    public partial class ChildElement : BaseItem
    {

        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ChildElement() { }

        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ChildElement(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public ChildElement(string name, string itemId)
        {
            this.Name = name;
            this.ItemID = itemId;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public ChildElement(string name, string itemId, string id)
        {
            this.Name = name;
            this.ItemID = itemId;
            this.ID = id;
        }

        /// <summary>
        /// The property name on the Component for the child element.
        /// </summary>
        [Meta]
        [ConfigOption("name")]
        [DefaultValue("")]
        [Description("The property name on the Component for the child element.")]
        public virtual string Name
        {
            get
            {
                return this.State.Get<string>("Name", "");
            }
            set
            {
                this.State.Set("Name", value);
            }
        }

        /// <summary>
        /// The id to combine with the Component's id that is the id of the child element.
        /// </summary>
        [Meta]
        [ConfigOption("itemId")]
        [DefaultValue("")]
        [Description("The id to combine with the Component's id that is the id of the child element.")]
        public virtual string ItemID
        {
            get
            {
                return this.State.Get<string>("ItemID", string.IsNullOrEmpty(this.ID) ? this.Name : "");
            }
            set
            {
                this.State.Set("ItemID", value);
            }
        }

        /// <summary>
        /// The id to combine with the Component's id that is the id of the child element.
        /// </summary>
        [Meta]
        [ConfigOption("id")]
        [DefaultValue("")]
        [Description("The id of the child element.")]
        public virtual string ID
        {
            get
            {
                return this.State.Get<string>("ID", "");
            }
            set
            {
                this.State.Set("ID", value);
            }
        }
    }
}

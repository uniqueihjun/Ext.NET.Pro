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

namespace Ext.Net
{
    /// <summary>
    /// This class is a base for all id generators. It also provides lookup of id generators by their id.
    ///
    /// Generally, id generators are used to generate a primary key for new model instances. There are different approaches to solving this problem, so this mechanism has both simple use cases and is open to custom implementations. A Ext.data.Model requests id generation using the Ext.data.Model.idgen property.
    /// </summary>
    [Meta]
    public abstract partial class ModelIdGenerator : BaseItem
    {
        /// <summary>
        /// The id by which to register a new instance. This instance can be found using the get static method.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [Description("The id by which to register a new instance. This instance can be found using the get static method.")]
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

        /// <summary>
        /// 
        /// </summary>
        protected abstract string Type
        {
            get;
        }

        private JFunction getRecId;
        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual JFunction GetRecId
        {
            get
            {
                if (this.getRecId == null)
                {
                    this.getRecId = new JFunction();

                    if (!this.DesignMode)
                    {
                        this.getRecId.Args = new string[] { "record" };
                    }
                }

                return this.getRecId;
            }
        }
    }
}
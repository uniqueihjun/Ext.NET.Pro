/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public partial class CustomIdGenerator : ModelIdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        public CustomIdGenerator() 
        { 
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("type")]
        protected override string Type
        {
            get
            {
                return "default";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("isGenerator")]
        protected virtual bool IsGenerator
        {
            get
            {
                return true;
            }
        }

        private JFunction generate;
        /// <summary>
        /// Generates and returns the next id. This method must be implemented by the derived class.
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Raw)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual JFunction Generate
        {
            get
            {
                if (this.generate == null)
                {
                    this.generate = new JFunction();
                }

                return this.generate;
            }
        }
    }
}
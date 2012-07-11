/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// This class generates UUID's according to RFC 4122. This class has a default id property. This means that a single instance is shared unless the id property is overridden.
    /// See http://www.ietf.org/rfc/rfc4122.txt for details.
    /// </summary>
    [Meta]
    public partial class UuidIdGenerator : ModelIdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        public UuidIdGenerator() 
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
                return "uuid";
            }
        }
    }
}
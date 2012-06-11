/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public class Group
    {    
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        public virtual int? CalendarId 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        public virtual string Title 
        { 
            get; 
            set; 
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //[DefaultValue("")]
        //public virtual string Color 
        //{ 
        //    get; 
        //    set; 
        //}
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class GroupCollection : List<Group> { }
}
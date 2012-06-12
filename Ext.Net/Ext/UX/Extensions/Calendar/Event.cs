/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ext.Net
{

    /// <summary>
    /// This is the specification for calendar event data used by the CalendarPanel's underlying store.
    /// It can be overridden as necessary to customize the fields supported by events, 
    /// although the existing column names should not be altered. If your model fields are named differently
    /// you should update the mapping configs accordingly.
    /// The only required fields when creating a new event record instance are StartDate and
    /// EndDate.  All other fields are either optional are will be defaulted if blank.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        public virtual int? EventId
        {
            get;
            set;
        }

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

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        public virtual DateTime? StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        public virtual DateTime? EndDate 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        public virtual string Location 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        public virtual string Notes 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        public virtual string Url 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        public virtual bool? IsAllDay 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        public virtual string Reminder 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(null)]
        public virtual bool? IsNew 
        { 
            get; 
            set;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class EventCollection : List<Event> { }
}
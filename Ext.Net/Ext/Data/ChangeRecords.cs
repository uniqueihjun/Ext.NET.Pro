/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
	[Description("")]
    public partial class ChangeRecords<T>
    {
        private List<T> deleted;
        private List<T> updated;
        private List<T> created;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public List<T> Deleted
        {
            get
            {
                if (deleted == null)
                {
                    deleted = new List<T>();
                }

                return deleted;
            }
            set { deleted = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public List<T> Updated
        {
            get
            {
                if (updated == null)
                {
                    updated = new List<T>();
                }

                return updated;
            }
            set { updated = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public List<T> Created
        {
            get
            {
                if (created == null)
                {
                    created = new List<T>();
                }

                return created;
            }
            set { created = value; }
        }
    }
}
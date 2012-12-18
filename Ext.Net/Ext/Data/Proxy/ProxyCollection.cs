/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ProxyCollection : SingleItemStateCollection<AbstractProxy>
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("proxy", JsonMode.Object)]
		[Description("")]
        public AbstractProxy Primary
        {
            get
            {
                if (this.Count>0)
                {
                    return this[0];
                }

                return null;
            }
        }
    }
}

/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class MenuCollection : ItemsCollection<MenuBase>
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.Object)]
		[Description("")]
        public MenuBase Primary
        {
            get
            {
                if (this.Count > 0)
                {
                    return this[0];
                }

                return null;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public MenuCollection()
        {
            this.SingleItemMode = true;
        }
    }
}
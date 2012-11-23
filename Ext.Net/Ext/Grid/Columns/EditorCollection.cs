/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class EditorCollection : ItemsCollection<Field>
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.Object)]
		[Description("")]
        public Field Primary
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
        public EditorCollection()
        {
            this.SingleItemMode = true;
        }
    }
}

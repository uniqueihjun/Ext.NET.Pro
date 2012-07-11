/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public abstract partial class ExtJsonConverter : JsonConverter
    {
        private string propertyName;
        private string name;
        private object owner;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string PropertyName
        {
            get { return propertyName; }
            set { propertyName = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public object Owner
        {
            get { return owner; }
            set { owner = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Control OwnerControl
        {
            get
            {
                if (this.Owner is StateManagedItem)
                {
                    return ((StateManagedItem)this.Owner).Owner;
                }
                else if (this.Owner is Control)
                {
                    return (Control)this.Owner;
                }

                return null;
            }
        }
    }
}
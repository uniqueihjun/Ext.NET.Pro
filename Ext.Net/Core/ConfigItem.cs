/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Text;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ConfigItem : BaseParameter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfigItem() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfigItem(string name, string value) : base(name, value) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfigItem(string name, string value, ParameterMode mode) : base(name, value, mode) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfigItem(string name, string value, bool encode) : base(name, value, encode) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfigItem(string name, string value, ParameterMode mode, bool encode) : base(name, value, mode, encode) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override ParameterMode DefaultMode
        {
            get
            {
                return ParameterMode.Raw;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ConfigItemCollection : StateManagedCollection<ConfigItem>
    {
        private bool camelName = true;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public virtual bool CamelName
        {
            get
            {
                return this.camelName;
            }
            set
            {
                this.camelName = value;
            }
        }
        
        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ToJson()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");

            if (this.Count > 0)
            {
                bool needComma = false;

                foreach (ConfigItem item in this)
                {
                    if (needComma)
                    {
                        sb.Append(",");
                    }
                    
                    sb.Append(item.Name);
                    sb.Append(":");
                    sb.Append(item.ValueToString());
                    needComma = true;
                }
            }

            sb.Append("}");

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Description("")]
        public virtual bool Contains(string name)
        {
            foreach (ConfigItem item in this)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
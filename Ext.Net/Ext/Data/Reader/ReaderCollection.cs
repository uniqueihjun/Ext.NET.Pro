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
    public partial class ReaderCollection : SingleItemStateCollection<AbstractReader>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AbstractReader Primary
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

        private LazyMode lazyMode = LazyMode.Config;

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(LazyMode.Config)]        
        public virtual LazyMode LazyMode
        {
            get
            {
                return this.lazyMode;
            }
            set
            {
                this.lazyMode = value;
            }
        }

        [ConfigOption("reader", JsonMode.Raw)]
        [DefaultValue("")]
        public virtual string PrimaryProxy
        {
            get
            {
                if(this.Primary == null)
                {
                    return "";
                }

                var config = new ClientConfig().Serialize(this.Primary, true);

                return this.LazyMode == Ext.Net.LazyMode.Instance ? string.Format("Ext.create({0}, {1})", JSON.Serialize(this.Primary.InstanceOf), config) : config;
            }
        }
    }
}
/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class SingleItemCollection<T> : Collection<T>, IXObject
    {
        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = new ConfigOptionsCollection();

                return list;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public virtual ConfigOptionsExtraction ConfigOptionsExtraction
        {
            get
            {
                return ConfigOptionsExtraction.List;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void InsertItem(int index, T item)
        {
            this.CheckCount();
            base.InsertItem(index, item);

            if (this.AfterItemAdd != null)
            {
                this.AfterItemAdd(item);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void SetItem(int index, T item)
        {
            this.CheckCount();
            base.SetItem(index, item);

            if (this.AfterItemAdd != null)
            {
                this.AfterItemAdd(item);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual string ExcessItemsMessage
        {
            get
            {
                return "Only one item can be added to this Items Collection.";
            }
        }

        private void CheckCount()
        {
            if (Count > 0)
            {
                throw new ExcessItemsException(ExcessItemsMessage);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        new public void Clear()
        {
            foreach (T item in this)
            {
                if (this.AfterItemRemove != null)
                {
                    this.AfterItemRemove(item);
                }
            }

            base.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        [Description("")]
        new public void Remove(T item)
        {
            base.Remove(item);

            if (this.AfterItemRemove != null)
            {
                this.AfterItemRemove(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public delegate void AfterItemAddHandler(T item);
        
        /// <summary>
        /// 
        /// </summary>
        public event AfterItemAddHandler AfterItemAdd;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public delegate void AfterItemRemoveHandler(T item);

        /// <summary>
        /// 
        /// </summary>
        public event AfterItemRemoveHandler AfterItemRemove;
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ExcessItemsException : Exception
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ExcessItemsException(string message) : base(message) { }
    }
}
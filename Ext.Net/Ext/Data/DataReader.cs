/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Abstract base class for reading structured data from a data source and
    /// converting it into an object containing RecordField objects and metadata
    /// for use by an Store. This class is intended to be extended and should
    /// not be created directly. For existing implementations, see ArrayReader,
    /// JsonReader and XmlReader.
    /// </summary>
    [Meta]
    [Description("Abstract base class for reading structured data from a data source and converting it into an object containing RecordField objects and metadata for use by an Store.")]
    public abstract partial class DataReader : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public abstract string IDField
        { 
            get;
        }
        
        private RecordFieldCollection fields;

        /// <summary>
        /// An array of field definition objects
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.AlwaysArray)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Either a Collection of RecordField definition objects")]
        public virtual RecordFieldCollection Fields
        {
            get
            {
                if (fields == null)
                {
                    fields = new RecordFieldCollection();
                }

                return fields;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
        [ConfigOption("fields", JsonMode.Raw)]
		[Description("")]
        protected virtual string EmptyFields
        {
            get
            {
                if (this.Fields.Count == 0)
                {
                    return "[]";
                }

                return "";
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
        [ConfigOption]
		[Description("")]
        public virtual string MessageProperty
        {
            get
            {
                object obj = this.ViewState["MessageProperty"];
                return obj == null ? "" : (string)obj;
            }
            set
            {
                this.ViewState["MessageProperty"] = value;
            }
        }
    }
}

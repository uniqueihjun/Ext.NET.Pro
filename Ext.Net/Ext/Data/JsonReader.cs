/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Data reader class to create an Array of Ext.data.Record objects from a JSON response based on mappings in a provided Ext.data.Record constructor.
    /// </summary>
    [Meta]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Data reader class to create an Array of Ext.data.Record objects from a JSON response based on mappings in a provided Ext.data.Record constructor.")]
    public partial class JsonReader : DataReader
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JsonReader() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.data.JsonReader";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string IDField
        {
            get
            {
                return this.IDProperty;
            }
        }
        
        /// <summary>
        /// [id] Name of the property within a row object that contains a record identifier value. Defaults to id
        /// </summary>
        [Meta]
        [ConfigOption("idProperty")]
        [Category("Config Options")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("[id] Name of the property within a row object that contains a record identifier value. Defaults to id")]
        public virtual string IDProperty
        {
            get
            {
                object obj = this.ViewState["IDProperty"];
                return obj == null ? "" : (string)obj;
            }
            set
            {
                this.ViewState["IDProperty"] = value;
            }
        }
        
        /// <summary>
        /// Name of the property which contains the Array of row objects.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Name of the property which contains the Array of row objects.")]
        public virtual string Root
        {
            get
            {
                object obj = this.ViewState["Root"];
                return obj == null ? "" : (string)obj;
            }
            set
            {
                this.ViewState["Root"] = value;
            }
        }

        /// <summary>
        /// Name of the property from which to retrieve the success attribute used by forms.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Name of the property from which to retrieve the success attribute used by forms.")]
        public virtual string SuccessProperty
        {
            get
            {
                object obj = this.ViewState["SuccessProperty"];
                return obj == null ? "" : (string)obj;
            }
            set
            {
                this.ViewState["SuccessProperty"] = value;
            }
        }

        /// <summary>
        /// Name of the property from which to retrieve the total number of records in the dataset.
        /// This is only needed if the whole dataset is not passed in one go, but is being paged
        /// from the remote server.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The DomQuery path from which to retrieve the total number of records in the dataset. This is only needed if the whole dataset is not passed in one go, but is being paged from the remote server.")]
        public virtual string TotalProperty
        {
            get
            {
                object obj = this.ViewState["TotalProperty"];
                return obj == null ? "" : (string)obj;
            }
            set
            {
                this.ViewState["TotalProperty"] = value;
            }
        }
    }
}

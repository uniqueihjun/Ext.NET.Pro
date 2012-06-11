/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// Data reader class to create an Array of Ext.data.Record objects from an XML document
    /// based on mappings in a provided Ext.data.Record constructor.
    ///
    /// Note that in order for the browser to parse a returned XML document, the Content-Type
    /// header in the HTTP response must be set to "text/xml".
    /// </summary>
    [Meta]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("Data reader class to create an Array of Ext.data.Record objects from an XML document based on mappings in a provided Ext.data.Record constructor.")]
    public partial class XmlReader : DataReader
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public XmlReader() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.data.XmlReader";
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
                return this.IDPath;
            }
        }
        
        /// <summary>
        /// The DomQuery path relative from the record element to the element that contains a record identifier value.
        /// </summary>
        [Meta]
        [ConfigOption("idPath")]
        [Category("Config Options")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The DomQuery path relative from the record element to the element that contains a record identifier value.")]
        public virtual string IDPath
        {
            get
            {
                object obj = this.ViewState["IDPath"];
                return obj == null ? "" : (string)obj;
            }
            set
            {
                this.ViewState["IDPath"] = value;
            }
        }
        
        /// <summary>
        /// The DomQuery path to the repeated element which contains record information.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The DomQuery path to the repeated element which contains record information.")]
        public virtual string Record
        {
            get
            {
                return (string)this.ViewState["Record"] ?? "";
            }
            set
            {
                this.ViewState["Record"] = value;
            }
        }

        /// <summary>
        /// The DomQuery path to the success attribute used by forms.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("Config Options")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The DomQuery path to the success attribute used by forms.")]
        public virtual string Success
        {
            get
            {
                return (string)this.ViewState["Success"] ?? "";
            }
            set
            {
                this.ViewState["Success"] = value;
            }
        }

        /// <summary>
        /// The DomQuery path from which to retrieve the total number of records in the dataset.
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
                return (string)this.ViewState["TotalProperty"] ?? "";
            }
            set
            {
                this.ViewState["TotalProperty"] = value;
            }
        }
    }
}

/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Data reader class to create an Array of Ext.data.Record objects from an Array.
    /// Each element of that Array represents a row of data fields. The fields are pulled
    /// into a Record object using as a subscript, the mapping property of the field
    /// definition if it exists, or the field's ordinal position in the definition.
    /// </summary>
    [Meta]
    [Description("Data reader class to create an Array of Ext.data.Record objects from an Array.")]
    public partial class ArrayReader : JsonReader
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ArrayReader() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.data.ArrayReader";
            }
        }

        /// <summary>
        /// [id] Name of the property within a row object that contains a record identifier value. Defaults to id
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Ignore)]
        [Category("Config Options")]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("[id] Name of the property within a row object that contains a record identifier value. Defaults to id")]
        public override string IDProperty
        {
            get
            {
                return (string)this.ViewState["IDProperty"] ?? "";
            }
            set
            {
                this.ViewState["IDProperty"] = value;
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
                if (this.IDProperty.IsNotEmpty())
                {
                    return this.IDProperty;
                }

                if (this.IDIndex < 0 || this.IDIndex >= this.Fields.Count)
                {
                    return "";
                }

                return this.Fields[this.IDIndex].Name;
            }
        }
        
        /// <summary>
        /// The subscript within row Array that provides an ID for the Record.
        /// </summary>
        [Meta]
        [Category("Config Options")]
        [DefaultValue(-1)]
        [NotifyParentProperty(true)]
        [Description("The subscript within row Array that provides an ID for the Record.")]
        public int IDIndex
        {
            get
            {
                object obj = this.ViewState["IDIndex"];
                return obj == null ? -1 : (int)obj;
            }
            set
            {
                this.ViewState["IDIndex"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("idIndex")]
        [DefaultValue(-1)]
		[Description("")]
        protected int IDIndexProxy
        {
            get
            {
                if (this.IDIndex < 0)
                {
                    if (this.IDProperty.IsNotEmpty())
                    {
                        for (int i = 0; i < this.Fields.Count; i++)
                        {
                            if (this.Fields[i].Name == this.IDProperty)
                            {
                                return i;
                            }
                        }
                    }
                    
                    return -1;
                }

                if (this.IDIndex < this.Fields.Count)
                {
                    return this.IDIndex;
                }

                throw new InvalidOperationException("Invalid index in the IDIndex of ArrayReader");
            }
        }
    }
}

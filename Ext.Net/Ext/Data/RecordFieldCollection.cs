/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Globalization;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class RecordFieldCollection : StateManagedCollection<RecordField> 
    {
		/// <summary>
		/// 
		/// </summary>
        public virtual void Add(params string[] names)
        {
            string[] parts;
            string name;

            foreach (string s in names)
            {
                name = s.Trim();

                if (name.Contains(":"))
                {
                    parts = name.Split(':');

                    try
                    {
                        this.Add(new RecordField(parts[0], (RecordFieldType)Enum.Parse(typeof(RecordFieldType), parts[1].ToTitleCase(CultureInfo.InvariantCulture))));
                        continue;
                    }
                    catch (ArgumentException) 
                    {
                        throw new ArgumentException("The RecordFieldType of \"" + parts[1] + "\" was not found");
                    }
                }
                
                this.Add(new RecordField(name));
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public virtual void Add(string name)
        {
            if (name.Contains(","))
            {
                this.Add(name.Split(','));
            }
            else
            {
                this.Add(new string[]{name});
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public virtual void Add(string name, RecordFieldType type)
        {
            this.Add(new RecordField(name, type));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="dateFormat"></param>
        public virtual void Add(string name, RecordFieldType type, string dateFormat)
        {
            this.Add(new RecordField(name, type, dateFormat));
        }

        /// <summary>
        ///  Get RecordField by name
        /// </summary>
        /// <param name="name">Field's name</param>
        /// <returns>RecordField</returns>
        public virtual RecordField Get(string name)
        {
            foreach (RecordField field in this)
            {
                if (field.Name == name)
                {
                    return field;
                }
            }

            return null;
        }
    }
}

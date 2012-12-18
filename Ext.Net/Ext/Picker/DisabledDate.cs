/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;

using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	///  These strings will be used to build a dynamic regular expression so they are very powerful. Some examples:
    ///  
    ///  ['03/08/2003', '09/16/2003'] would disable those exact dates
    ///  ['03/08', '09/16'] would disable those days for every year
    ///  ['03/08'] would only match the beginning (useful if you are using short years)
    ///  ['03/../2006'] would disable every day in March 2006
    ///  ['03'] would disable every day in every March
    ///  Note that the format of the dates included in the array should exactly match the format config. In order to support regular expressions, if you are using a date format that has '.' in it, you will have to escape the dot when restricting dates. For example: ['03\.08\.03'].
	/// </summary>
	[Description("")]
    public partial class DisabledDate : BaseItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DisabledDate() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DisabledDate(DateTime date)
        {
            this.Date = date;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DisabledDate(string regex)
        {
            this.regex = regex;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DisabledDate(int year, int month, int day)
        {
            this.Date = new DateTime(year,month,day);
        }

        private DateTime date;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value.Date; }
        }

        private string regex;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string RegEx
        {
            get { return this.regex; }
            set { this.regex = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ToString(string format, CultureInfo locale)
        {
            if (this.regex.IsNotEmpty())
            {
                return JSON.Serialize(this.regex);
            }

            if (this.Date == DateTime.MinValue)
            {
                throw new ArgumentException("The Date or RegEx must be specified for DisabledDate object.");
            }

            //clear time
            this.Date = new DateTime(this.Date.Year, this.Date.Month, this.Date.Day, 0,0,0,0);

            return JSON.Serialize(this.Date, JSON.ScriptConverters);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class DisabledDateCollection : BaseItemCollection<DisabledDate>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string ToString(string format, CultureInfo locale)
        {
            if (this.Count == 0)
            {
                return "";
            }

            StringWriter sw = new StringWriter();
            JsonTextWriter writer = new JsonTextWriter(sw);
            
            writer.WriteStartArray();

            foreach (DisabledDate disabledDate in this)
            {
                writer.WriteRawValue(disabledDate.ToString(format, locale));
            }

            writer.WriteEndArray();
            writer.Flush();

            return sw.GetStringBuilder().ToString();
        }
    }
}

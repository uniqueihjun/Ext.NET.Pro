/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Text;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ParameterCollection : StateManagedCollection<Parameter>
    {
        private readonly bool camelNames;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ParameterCollection() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ParameterCollection(bool camelNames)
        {
            this.camelNames = camelNames;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Parameter GetParameter(string name)
        {
            foreach (Parameter parameter in this)
            {
                if (parameter.Name == name)
                {
                    return parameter;
                }
            }

            return null;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string this[string name]
        {
            get
            {
                foreach (Parameter parameter in this)
                {
                    if (parameter.Name == name)
                    {
                        return parameter.Value;
                    }
                }

                return null;
            }
            set
            {
                foreach (Parameter parameter in this)
                {
                    if (parameter.Name == name)
                    {
                        parameter.Value = value;
                        return;
                    }
                }

                this.Add(new Parameter(name, value));
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ToJson()
        {
            return this.ToJson(0);
        }

        //typeParams=0 - all
        //typeParams=1 - service(start, limit, sort, dir)
        //typeParams=2 - all except service
        internal string ToJson(int typeParams)
        {
            if (this.Count == 0)
            {
                return "{}";
            }

            StringBuilder sb = new StringBuilder(256);
            sb.Append("{");
            bool removeComma = false;

            foreach (Parameter parameter in this)
            {
                if (typeParams == 0 || (typeParams == 1 && this.IsService(parameter.Name)) || (typeParams == 2 && !this.IsService(parameter.Name)))
                {
                    sb.AppendFormat("{0},", TokenUtils.ParseTokens(parameter.ToString(camelNames), parameter.Owner));
                    removeComma = true;
                }
            }
            
            if (removeComma)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            
            sb.Append("}");

            return sb.ToString();
        }

        private bool IsService(string name)
        {
            switch(name)
            {
                case "start":
                case "limit":
                case "sort":
                case "dir":
                    return true;
                default:
                    return false;
            }
        }
    }
}
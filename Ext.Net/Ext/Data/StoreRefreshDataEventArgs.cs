/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Xml;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class StoreRefreshDataEventArgs : EventArgs
    {
        private readonly XmlNode parameters;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreRefreshDataEventArgs() { }

        internal StoreRefreshDataEventArgs(XmlNode parameters)
        {
            this.parameters = parameters;
        }

        private int total = -1;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int Total
        {
           get
           {
               return total;
           }
            set
            {
                total = value;
            }
        }

        private ParameterCollection p;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ParameterCollection Parameters
        {
            get
            {
                if (p != null)
                {
                    return p;
                }

                if (this.parameters == null)
                {
                    return new ParameterCollection();
                }

                p = ResourceManager.XmlToParams(this.parameters);

                return p;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int Start
        {
            get
            {
                if (this.Parameters["start"].IsNotEmpty())
                {
                    return int.Parse(this.Parameters["start"]);
                }

                return -1;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int Limit
        {
            get
            {
                if (this.Parameters["limit"].IsNotEmpty())
                {
                    return int.Parse(this.Parameters["limit"]);
                }

                return -1;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Sort
        {
            get
            {
                if (this.Parameters["sort"].IsNotEmpty())
                {
                    return this.Parameters["sort"];
                }

                return "";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SortDirection Dir
        {
            get
            {
                if (this.Parameters["dir"].IsNotEmpty())
                {
                    return (SortDirection)Enum.Parse(typeof(SortDirection), this.Parameters["dir"], true);
                }

                return SortDirection.Default;
            }
        }
    }
}

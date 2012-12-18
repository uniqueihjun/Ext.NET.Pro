/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System;
using System.Globalization;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BuilderFactory
    {
        // PLACEHOLDER: Implemented as partial in each TBuilder.

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        internal static string FormatValueInternal(object value, string format)
        {
            if (value == null)
            {
                return String.Empty;
            }

            if (String.IsNullOrEmpty(format))
            {
                return Convert.ToString(value, CultureInfo.CurrentCulture);
            }
            else
            {
                return String.Format(CultureInfo.CurrentCulture, format, value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        new public Type GetType()
        {
            return base.GetType();
        }        
    }

    /*  X
        -----------------------------------------------------------------------------------------------*/

    /// <summary>
    /// 
    /// </summary>
    public partial class X
    {
        private static BuilderFactory builder = null;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static BuilderFactory Builder
        {
            get
            {
                if (X.builder == null)
                {
                    X.builder = new BuilderFactory();
                }

                return X.builder;
            }
        }
    }
}
/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Reflection;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class BaseItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public partial class Config : IApply
        {
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Description("")]
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
            [Description("")]
            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Description("")]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Description("")]
            new public Type GetType()
            {
                return base.GetType();
            }


            /*  Methods
                -----------------------------------------------------------------------------------------------*/

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            [Description("")]
            public object ApplyIf(object obj)
            {
                return this.Apply(obj);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="obj"></param>
            /// <returns></returns>
            [Description("")]
            public T Apply<T>(object obj) where T : IApply
            {
                return (T)this.Apply(obj);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            [Description("")]
            public object Apply(object obj)
            {
                return X.Apply(this, obj);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            [Description("")]
            public virtual string Serialize()
            {
                return JSON.Serialize(this);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="config"></param>
            /// <returns></returns>
            [Description("")]
            public static Config Deserialize(string config)
            {
                return JSON.Deserialize<Config>(config); 
            }

            /// <summary>
            /// 
            /// </summary>
            /// <typeparam name="TConfig"></typeparam>
            /// <param name="config"></param>
            /// <returns></returns>
            [Description("")]
            public static TConfig Deserialize<TConfig>(string config)
                where TConfig : Config
            {
                return JSON.Deserialize<TConfig>(config) as TConfig;
            }
        }
    }
}
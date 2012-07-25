/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ChainingPropertyInfo : PropertyInfo
    {
        private readonly PropertyInfo root;
        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected PropertyInfo Root 
        { 
            get 
            { 
                return this.root; 
            } 
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        [Description("")]
        public ChainingPropertyInfo(PropertyInfo root)
        {
            this.root = root;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool Equals(object obj)
        {
            return this.Root.Equals(obj);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override int GetHashCode()
        {
            return this.Root.GetHashCode();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual object GetValue(object component)
        {
            return this.Root.GetValue(component, null);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="component"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [Description("")]
        public override object GetValue(object component, object[] index)
        {
            return this.Root.GetValue(component, index);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string Name
        {
            get
            {
                return this.Root.Name;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            return this.Root.ToString();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override Type DeclaringType
        {
            get
            {
                return this.Root.DeclaringType;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override Type ReflectedType
        {
            get
            {
                return this.Root.ReflectedType;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override Type PropertyType
        {
            get
            {
                return this.Root.PropertyType;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override PropertyAttributes Attributes
        {
            get
            {
                return this.Root.Attributes;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanRead
        {
            get
            {
                return this.Root.CanRead;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanWrite
        {
            get
            {
                return this.Root.CanWrite;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object[] GetCustomAttributes(bool inherit)
        {
            return this.Root.GetCustomAttributes(inherit);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool IsDefined(Type attributeType, bool inherit)
        {
            return this.Root.IsDefined(attributeType, inherit);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return this.Root.GetCustomAttributes(attributeType, inherit);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override ParameterInfo[] GetIndexParameters()
        {
            return GetIndexParameters();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
            return this.Root.GetValue(obj, invokeAttr, binder, index, culture);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
            this.Root.SetValue(obj, value, invokeAttr, binder, index, culture);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override MethodInfo[] GetAccessors(bool nonPublic)
        {
            return this.Root.GetAccessors(nonPublic);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override MethodInfo GetGetMethod(bool nonPublic)
        {
            return this.Root.GetGetMethod(nonPublic);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override MethodInfo GetSetMethod(bool nonPublic)
        {
            return this.Root.GetSetMethod(nonPublic);
        }
    }
}
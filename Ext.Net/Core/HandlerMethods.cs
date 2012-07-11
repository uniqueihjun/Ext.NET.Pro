/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Web;
using System.Web.Caching;
using System.Web.Compilation;

using Ext.Net.Utilities;

namespace Ext.Net
{
    internal class HandlerMethods
    {
        private DirectMethod[] staticMethods;
        private DirectMethod[] instanceMethods;
        private readonly Type handlerType;

        private const string CACHE_PREFIX = "ExtNetHandlerMethods_";

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public HandlerMethods(Type handlerType)
        {
            this.handlerType = handlerType;
        }

        internal DirectMethod[] StaticMethods
        {
            get
            {
                if (this.staticMethods == null)
                {
                    this.staticMethods = this.GetMethods(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Static);
                }

                return this.staticMethods;
            }
        }

        internal DirectMethod[] InstanceMethods
        {
            get
            {
                if (this.instanceMethods == null)
                {
                    this.instanceMethods = this.GetMethods(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);
                }

                return this.instanceMethods;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DirectMethod GetStaticMethod(string name)
        {
            foreach (DirectMethod method in this.StaticMethods)
            {
                if (method.Name == name)
                {
                    return method;
                }
            }

            this.staticMethods = null;

            foreach (DirectMethod method in this.StaticMethods)
            {
                if (method.Name == name)
                {
                    return method;
                }
            }

            return null;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DirectMethod GetInstanceMethod(string name)
        {
            foreach (DirectMethod method in this.InstanceMethods)
            {
                if (method.Name == name)
                {
                    return method;
                }
            }

            this.instanceMethods = null;

            foreach (DirectMethod method in this.InstanceMethods)
            {
                if (method.Name == name)
                {
                    return method;
                }
            }

            return null;
        }
        
        private DirectMethod[] GetMethods(BindingFlags bindingAttrs)
        {
            List<DirectMethod> list = new List<DirectMethod>();
            Type tmpType = this.handlerType;

            while (tmpType != null)
            {
                MethodInfo[] methodInfos = tmpType.GetMethods(bindingAttrs);

                foreach (MethodInfo method in methodInfos)
                {
                    if (!method.IsAbstract)
                    {
                        object[] attrs = method.GetCustomAttributes(typeof (DirectMethodAttribute), true);
                
                        if (attrs.Length > 0)
                        {
                            list.Add(new DirectMethod(method, (DirectMethodAttribute)attrs[0]));
                        }
                    }
                }

                tmpType = tmpType.BaseType;
            }

            return list.ToArray();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static string GetMethodName(HttpContext context)
        {
            return context.Request["_methodName_"] ?? "";
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public static bool RethrowException(HttpContext context)
        {
            bool success;
            bool boolValue = bool.TryParse(context.Request["_rethrowException_"], out success);

            if (success)
            {
                return boolValue;
            }

            return false;
        }

        private static bool IsDebugging
        {
            get
            {
                bool result = false;

                if (HttpContext.Current != null)
                {
                    result = HttpContext.Current.IsDebuggingEnabled;
                }

                return result;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static HandlerMethods GetHandlerMethods(HttpContext context, string requestPath)
        {
            string path = VirtualPathUtility.ToAbsolute(requestPath);

            string cacheKey = HandlerMethods.CACHE_PREFIX + path;
            HandlerMethods handlerMethods = null;
            
            if (!IsDebugging)
            {
                handlerMethods = context.Cache[cacheKey] as HandlerMethods;
            }

            if (handlerMethods == null)
            {
                Type requestedType = BuildManager.GetCompiledType(path);

                if (requestedType == null)
                {
                    requestedType = BuildManager.CreateInstanceFromVirtualPath(path, typeof(System.Web.UI.Page)).GetType();
                }
                handlerMethods = new HandlerMethods(requestedType);

                if (!IsDebugging)
                {
                    PutToCache(path, context, cacheKey, handlerMethods);
                }
            }

            return handlerMethods;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static HandlerMethods GetHandlerMethodsByType(HttpContext context, Type type, string requestPath, bool ignoreCache)
        {
            string cacheKey = HandlerMethods.CACHE_PREFIX.ConcatWith(requestPath, type.Namespace, type.Name);
            HandlerMethods handlerMethods = null;

            if (!IsDebugging && !ignoreCache)
            {
                handlerMethods = context.Cache[cacheKey] as HandlerMethods;
            }

            if (handlerMethods == null)
            {
                handlerMethods = new HandlerMethods(type);

                if (!IsDebugging && !ignoreCache)
                {
                    if (requestPath.IsEmpty() || !Directory.Exists(requestPath))
                    {
                        context.Cache.Insert(cacheKey, handlerMethods);
                    }
                    else
                    {
                        context.Cache.Insert(cacheKey, handlerMethods, new CacheDependency(context.Server.MapPath(requestPath)));
                    }
                }
            }

            return handlerMethods;
        }

        private static void PutToCache(string path, HttpContext context, string cacheKey, HandlerMethods handlerMethods)
        {
            BuildDependencySet dependencySet = BuildManager.GetCachedBuildDependencySet(context, path);

            if (dependencySet != null)
            {
                IEnumerable virtualPaths = dependencySet.VirtualPaths;

                if (virtualPaths != null)
                {
                    List<string> paths = new List<string>();

                    foreach (string _path in virtualPaths)
                    {
                        paths.Add(context.Server.MapPath(_path));
                    }
                    context.Cache.Insert(cacheKey, handlerMethods, new CacheDependency(paths.ToArray()));
                    return;
                }
            }

            context.Cache.Insert(cacheKey, handlerMethods);
        }
    }
}
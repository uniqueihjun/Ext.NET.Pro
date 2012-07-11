/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net.MVC
{
    /// <summary>
    /// 
    /// </summary>
    public static class XExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static MvcResourceManagerBuilder ResourceManager(this BuilderFactory factory)
        {
            return new MvcResourceManagerBuilder();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static MvcResourceManagerBuilder ResourceManager(this BuilderFactory factory, MvcResourceManagerConfig config)
        {
            return new MvcResourceManagerBuilder(config);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static MvcResourcePlaceHolderBuilder ResourcePlaceHolder(this BuilderFactory factory)
        {
            return new MvcResourcePlaceHolderBuilder();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static MvcResourcePlaceHolderBuilder ResourcePlaceHolder(this BuilderFactory factory, ResourceMode mode)
        {
            return new MvcResourcePlaceHolderBuilder(mode);
        }
    }
}
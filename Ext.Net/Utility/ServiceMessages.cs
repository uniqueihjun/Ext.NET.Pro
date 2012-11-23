/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ServiceMessages
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DEFINE_READER_FOR_PROXY = "Please define Reader for the Proxy (store's Reader is used if proxy is undefined)";

        /// <summary>
        /// 
        /// </summary>
        public const string DEFINE_WRITER_FOR_PROXY = "Please define Writer for the Proxy (store's Writer is used if proxy is undefined)";
        
        /// <summary>
        /// 
        /// </summary>
        public const string DEFINE_ARRAY_READER = "Please use ArrayReader for binding items which have Array type";
        
        /// <summary>
        /// 
        /// </summary>
        public const string LAYOUT_AMBIGUITY = "Different layout type is defined in Layout and LayoutConfig properties";
        
        /// <summary>
        /// 
        /// </summary>
        public const string NON_LAYOUT_CONTROL = "Control with type '{0}' cannot be handled by layout";
        
        /// <summary>
        /// 
        /// </summary>
        public const string TURN_OFF_AUTOREGISTER = "Please set AutoRegister=false if you plan to use ToScript method of NodeProxy";
        
        /// <summary>
        /// 
        /// </summary>
        public const string INVALID_DATASOURCE = "TreeStore supports IHierarchicalEnumerable or IHierarchicalDataSource only";

        /// <summary>
        /// 
        /// </summary>
        public const string TREESTORE_INVALID_DATA_BINDING = "Could not bind to the '{0}' property (specified by {1}) while data binding TreeStore. Please check the Bindings fields.";

        /// <summary>
        /// 
        /// </summary>
        public const string ITEMTEMPLATE_FUNCTIONS = "Item template doesn't support functions definitions";
    }
}

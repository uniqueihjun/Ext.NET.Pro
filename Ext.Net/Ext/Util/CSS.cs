/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CSS : ScriptClass
    {
        /// <summary>
        /// 
        /// </summary>
        public override string InstanceOf
        {
            get
            {
                return "Ext.util.CSS";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToScript()
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="args"></param>
        protected virtual void CallCSS(string name, params object[] args)
        {
            this.Call(name, args);
        }

        /// <summary>
        /// Creates a stylesheet from a text blob of rules. These rules will be wrapped in a STYLE tag and appended to the HEAD of the document.
        /// </summary>
        /// <param name="cssText">The text containing the css rules</param>
        /// <param name="id">An id to add to the stylesheet for later removal</param>
        public static void CreateStyleSheet(string cssText, string id)
        {
            new CSS().Call("createStyleSheet", cssText, id);
        }

        /// <summary>
        /// Refresh the rule cache if you have dynamically added stylesheets
        /// </summary>
        public static void RefreshCache()
        {
            new CSS().Call("refreshCache");
        }

        /// <summary>
        /// Removes a style or link tag by id
        /// </summary>
        /// <param name="id">The id of the tag</param>
        public static void RemoveStyleSheet(string id)
        {
            new CSS().Call("removeStyleSheet", id);
        }

        /// <summary>
        /// Dynamically swaps an existing stylesheet reference for a new one
        /// </summary>
        /// <param name="id">The id of an existing link tag to remove</param>
        /// <param name="url">The href of the new stylesheet to include</param>
        public static void SwapStyleSheet(string id, string url)
        {
            new CSS().Call("swapStyleSheet", id, url);
        }

        /// <summary>
        /// Updates a rule property
        /// </summary>
        /// <param name="selector">Selector to update</param>
        /// <param name="property">The css property</param>
        /// <param name="value">The new value for the property</param>
        public static void UpdateRule(string selector, string property, string value)
        {
            new CSS().Call("updateRule", selector, property, value);
        }

        /// <summary>
        /// Updates a rule property
        /// </summary>
        /// <param name="selectors">Array of selectors - it tries each selector until it finds one. Stops immediately once one is found.</param>
        /// <param name="property">The css property</param>
        /// <param name="value">The new value for the property</param>
        public static void UpdateRule(string[] selectors, string property, string value)
        {
            new CSS().Call("updateRule", selectors, property, value);
        }
    }
}
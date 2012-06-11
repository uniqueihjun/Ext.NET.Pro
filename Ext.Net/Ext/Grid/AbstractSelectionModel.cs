/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// Abstract base class for grid SelectionModels. It provides the interface that should
    /// be implemented by descendant classes. This class should not be directly instantiated.
    /// </summary>
    [Meta]
    [Description("Abstract base class for grid SelectionModels. It provides the interface that should be implemented by descendant classes. This class should not be directly instantiated.")]
    public abstract partial class AbstractSelectionModel : LazyObservable
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public abstract void UpdateSelection();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="args"></param>
        [Description("")]
        protected virtual void CallGrid(string name, params object[] args)
        {
            this.CallTemplate("if({0}.grid){{{0}.grid.{1}({2});}}", name, args);
        }

        /*  Public Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Locks the selections.
        /// </summary>
        [Meta]
        [Description("Locks the selections.")]
        public virtual void Lock()
        {
            this.Call("lock");
        }

        /// <summary>
        /// Unlocks the selections.
        /// </summary>
        [Meta]
        [Description("Unlocks the selections.")]
        public virtual void Unlock()
        {
            this.Call("unlock");
        }
    }
}
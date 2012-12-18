/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;

namespace Ext.Net
{
    /// <summary>
    /// Selection mode for selection model
    /// </summary>
    public enum SelectionMode
    {
        ///<summary>
        /// Enable multiselection by clicking on multiple items without requiring the user to hold Shift or Ctrl, false to force the user to hold Ctrl or Shift to select more than on item
        ///</summary>
        Simple,
        ///<summary>
        /// Allow selection of exactly one item at a time, false to allow no selection at all
        ///</summary>
        Single,
        ///<summary>
        /// Allow selection of more than one item at a time, false to allow selection of only a single item at a time or no selection at all, depending on the value of singleSelect
        ///</summary>
        Multi
    }
}

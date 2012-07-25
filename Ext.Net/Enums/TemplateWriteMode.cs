/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;

namespace Ext.Net
{
    ///<summary>
    /// The Ext.XTemplate method to use when updating the content area of the AbstractComponent
    ///</summary>
    public enum TemplateWriteMode
    {
        ///<summary>
        /// Applies the supplied values to the template and appends the new node(s) to the specified el.
        ///</summary>
        Append,

        ///<summary>
        /// Applies the supplied values to the template and inserts the new node(s) after el.
        ///</summary>
        InsertAfter,

        ///<summary>
        /// Applies the supplied values to the template and inserts the new node(s) before el.
        ///</summary>
        InsertBefore,

        ///<summary>
        /// Applies the supplied values to the template and inserts the new node(s) as the first child of el.
        ///</summary>
        InsertFirst,

        ///<summary>
        /// Applies the supplied values to the template and overwrites the content of el with the new node(s).
        ///</summary>
        Overwrite
    }
}

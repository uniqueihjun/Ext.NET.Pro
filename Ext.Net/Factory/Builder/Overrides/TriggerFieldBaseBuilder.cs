/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class TriggerFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTriggerFieldBase, TBuilder> : TextFieldBase.Builder<TTriggerFieldBase, TBuilder>
            where TTriggerFieldBase : TriggerFieldBase
            where TBuilder : Builder<TTriggerFieldBase, TBuilder>
        {            
 			/// <summary>
			/// 
 			/// </summary>
            /// <param name="triggers"></param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Triggers(params FieldTrigger[] triggers)
            {
                this.ToComponent().Triggers.AddRange(triggers);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="triggers"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Triggers(IEnumerable<FieldTrigger> triggers)
            {
                this.ToComponent().Triggers.AddRange(triggers);
                return this as TBuilder;
            }
        }        
    }
}
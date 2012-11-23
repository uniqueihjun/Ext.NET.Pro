/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ext.Net
{
    public partial class ComponentColumn
    {
        new public abstract partial class Builder<TComponentColumn, TBuilder> : ColumnBase.Builder<TComponentColumn, TBuilder>
            where TComponentColumn : ComponentColumn
            where TBuilder : Builder<TComponentColumn, TBuilder>
        {
            public virtual TBuilder Component(AbstractComponent cmp)
            {
                this.ToComponent().Component.Add(cmp);
                return this as TBuilder;
            }

            /// <summary>
            /// An array of events to pin the component in a row (uses with OverOnly=true)
            /// </summary>
            public virtual TBuilder PinEvents(string pinEvent)
            {
                this.ToComponent().PinEvents = new string[] { pinEvent };
                return this as TBuilder;
            }

            /// <summary>
            /// An array of events to unpin the component in a row (uses with OverOnly=true)
            /// </summary>
            public virtual TBuilder UnpinEvents(string unpinEvent)
            {
                this.ToComponent().UnpinEvents = new string[] { unpinEvent };
                return this as TBuilder;
            }
        }
    }
}
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
    public partial class TaskManager
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TTaskManager, TBuilder> : LazyObservable.Builder<TTaskManager, TBuilder>
            where TTaskManager : TaskManager
            where TBuilder : Builder<TTaskManager, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="tasks"></param>
            /// <returns></returns>
            public virtual TBuilder Tasks(params Task[] tasks)
            {
                this.ToComponent().Tasks.AddRange(tasks);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="tasks"></param>
            /// <returns></returns>
            public virtual TBuilder Tasks(IEnumerable<Task> tasks)
            {
                this.ToComponent().Tasks.AddRange(tasks);
                return this as TBuilder;
            }
        }
    }
}
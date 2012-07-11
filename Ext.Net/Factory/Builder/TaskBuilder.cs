/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class Task
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<Task, Task.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Task()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Task component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Task.Config config) : base(new Task(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Task component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// (optional) The TaskID.
			/// </summary>
            public virtual Task.Builder TaskID(string taskID)
            {
                this.ToComponent().TaskID = taskID;
                return this as Task.Builder;
            }
             
 			/// <summary>
			/// True to auto run task (defaults to false).
			/// </summary>
            public virtual Task.Builder AutoRun(bool autoRun)
            {
                this.ToComponent().AutoRun = autoRun;
                return this as Task.Builder;
            }
             
 			/// <summary>
			/// The frequency in milliseconds with which the task should be executed (defaults to 1000)
			/// </summary>
            public virtual Task.Builder Interval(int interval)
            {
                this.ToComponent().Interval = interval;
                return this as Task.Builder;
            }
             
 			/// <summary>
			/// (optional) An array of arguments to be passed to the function specified by run
			/// </summary>
            public virtual Task.Builder Args(string[] args)
            {
                this.ToComponent().Args = args;
                return this as Task.Builder;
            }
             
 			/// <summary>
			/// (optional) The scope in which to execute the run function.
			/// </summary>
            public virtual Task.Builder Scope(string scope)
            {
                this.ToComponent().Scope = scope;
                return this as Task.Builder;
            }
             
 			/// <summary>
			/// (optional) The length of time in milliseconds to execute the task before stopping automatically (defaults to indefinite).
			/// </summary>
            public virtual Task.Builder Duration(int duration)
            {
                this.ToComponent().Duration = duration;
                return this as Task.Builder;
            }
             
 			/// <summary>
			/// (optional) The number of times to execute the task before stopping automatically (defaults to indefinite).
			/// </summary>
            public virtual Task.Builder Repeat(int repeat)
            {
                this.ToComponent().Repeat = repeat;
                return this as Task.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Task.Builder OnStart(string onStart)
            {
                this.ToComponent().OnStart = onStart;
                return this as Task.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Task.Builder OnStop(string onStop)
            {
                this.ToComponent().OnStop = onStop;
                return this as Task.Builder;
            }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(TaskListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side DirectEventHandlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(TaskDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Task.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Task(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Task.Builder Task()
        {
            return this.Task(new Task());
        }

        /// <summary>
        /// 
        /// </summary>
        public Task.Builder Task(Task component)
        {
            return new Task.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Task.Builder Task(Task.Config config)
        {
            return new Task.Builder(new Task(config));
        }
    }
}
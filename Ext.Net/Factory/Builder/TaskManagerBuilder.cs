/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class TaskManager
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<TaskManager, TaskManager.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TaskManager()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TaskManager component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TaskManager.Config config) : base(new TaskManager(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TaskManager component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The minimum precision in milliseconds supported by this TaskRunner instance (defaults to 10)
			/// </summary>
            public virtual TaskManager.Builder Interval(int interval)
            {
                this.ToComponent().Interval = interval;
                return this as TaskManager.Builder;
            }
             
 			/// <summary>
			/// The start delay in milliseconds for autorun tasks
			/// </summary>
            public virtual TaskManager.Builder AutoRunDelay(int autoRunDelay)
            {
                this.ToComponent().AutoRunDelay = autoRunDelay;
                return this as TaskManager.Builder;
            }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder Tasks(TaskCollection tasks)
            // {
            //    this.ToComponent().Tasks = tasks;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TaskManager.Builder AddTask(Task task)
            {
                this.ToComponent().AddTask(task);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TaskManager.Builder RemoveTask(int index)
            {
                this.ToComponent().RemoveTask(index);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TaskManager.Builder RemoveTask(string name)
            {
                this.ToComponent().RemoveTask(name);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TaskManager.Builder StartAll()
            {
                this.ToComponent().StartAll();
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TaskManager.Builder StopAll()
            {
                this.ToComponent().StopAll();
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TaskManager.Builder StartTask(int index)
            {
                this.ToComponent().StartTask(index);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TaskManager.Builder StopTask(int index)
            {
                this.ToComponent().StopTask(index);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TaskManager.Builder StartTask(string name)
            {
                this.ToComponent().StartTask(name);
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TaskManager.Builder StopTask(string name)
            {
                this.ToComponent().StopTask(name);
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public TaskManager.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TaskManager(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TaskManager.Builder TaskManager()
        {
            return this.TaskManager(new TaskManager());
        }

        /// <summary>
        /// 
        /// </summary>
        public TaskManager.Builder TaskManager(TaskManager component)
        {
            return new TaskManager.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TaskManager.Builder TaskManager(TaskManager.Config config)
        {
            return new TaskManager.Builder(new TaskManager(config));
        }
    }
}
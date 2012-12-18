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
    public partial class TaskManager
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TaskManager(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TaskManager.Config Conversion to TaskManager
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TaskManager(TaskManager.Config config)
        {
            return new TaskManager(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : LazyObservable.Config 
        { 
			/*  Implicit TaskManager.Config Conversion to TaskManager.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TaskManager.Builder(TaskManager.Config config)
			{
				return new TaskManager.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int interval = 10;

			/// <summary>
			/// The minimum precision in milliseconds supported by this TaskRunner instance (defaults to 10)
			/// </summary>
			[DefaultValue(10)]
			public virtual int Interval 
			{ 
				get
				{
					return this.interval;
				}
				set
				{
					this.interval = value;
				}
			}

			private int autoRunDelay = 50;

			/// <summary>
			/// The start delay in milliseconds for autorun tasks
			/// </summary>
			[DefaultValue(50)]
			public virtual int AutoRunDelay 
			{ 
				get
				{
					return this.autoRunDelay;
				}
				set
				{
					this.autoRunDelay = value;
				}
			}
        
			private TaskCollection tasks = null;

			/// <summary>
			/// 
			/// </summary>
			public TaskCollection Tasks
			{
				get
				{
					if (this.tasks == null)
					{
						this.tasks = new TaskCollection();
					}
			
					return this.tasks;
				}
			}
			
        }
    }
}
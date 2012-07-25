/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class TrayClock
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolbarTextItem.Builder<TrayClock, TrayClock.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TrayClock()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TrayClock component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TrayClock.Config config) : base(new TrayClock(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TrayClock component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TrayClock.Builder TimeFormat(string timeFormat)
            {
                this.ToComponent().TimeFormat = timeFormat;
                return this as TrayClock.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TrayClock.Builder Template(string template)
            {
                this.ToComponent().Template = template;
                return this as TrayClock.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TrayClock.Builder RefreshInterval(int refreshInterval)
            {
                this.ToComponent().RefreshInterval = refreshInterval;
                return this as TrayClock.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TrayClock.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TrayClock(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TrayClock.Builder TrayClock()
        {
            return this.TrayClock(new TrayClock());
        }

        /// <summary>
        /// 
        /// </summary>
        public TrayClock.Builder TrayClock(TrayClock component)
        {
            return new TrayClock.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TrayClock.Builder TrayClock(TrayClock.Config config)
        {
            return new TrayClock.Builder(new TrayClock(config));
        }
    }
}
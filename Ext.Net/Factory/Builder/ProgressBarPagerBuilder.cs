/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class ProgressBarPager
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<ProgressBarPager, ProgressBarPager.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ProgressBarPager()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ProgressBarPager component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ProgressBarPager.Config config) : base(new ProgressBarPager(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ProgressBarPager component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ProgressBarPager.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ProgressBarPager(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ProgressBarPager.Builder ProgressBarPager()
        {
            return this.ProgressBarPager(new ProgressBarPager());
        }

        /// <summary>
        /// 
        /// </summary>
        public ProgressBarPager.Builder ProgressBarPager(ProgressBarPager component)
        {
            return new ProgressBarPager.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ProgressBarPager.Builder ProgressBarPager(ProgressBarPager.Config config)
        {
            return new ProgressBarPager.Builder(new ProgressBarPager(config));
        }
    }
}
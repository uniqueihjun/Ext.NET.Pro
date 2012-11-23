/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class SaveMask
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : LoadMask.Builder<SaveMask, SaveMask.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SaveMask()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SaveMask component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SaveMask.Config config) : base(new SaveMask(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SaveMask component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The text to display in a centered saving message box (defaults to 'Saving...').
			/// </summary>
            public virtual SaveMask.Builder Msg(string msg)
            {
                this.ToComponent().Msg = msg;
                return this as SaveMask.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public SaveMask.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SaveMask(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SaveMask.Builder SaveMask()
        {
            return this.SaveMask(new SaveMask());
        }

        /// <summary>
        /// 
        /// </summary>
        public SaveMask.Builder SaveMask(SaveMask component)
        {
            return new SaveMask.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SaveMask.Builder SaveMask(SaveMask.Config config)
        {
            return new SaveMask.Builder(new SaveMask(config));
        }
    }
}
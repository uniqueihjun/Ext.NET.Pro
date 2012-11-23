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
    public partial class XScript
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : XControl.Builder<XScript, XScript.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new XScript()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XScript component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(XScript.Config config) : base(new XScript(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(XScript component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Script text
			/// </summary>
            public virtual XScript.Builder ScriptBlock(string scriptBlock)
            {
                this.ToComponent().ScriptBlock = scriptBlock;
                return this as XScript.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public XScript.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.XScript(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public XScript.Builder XScript()
        {
            return this.XScript(new XScript());
        }

        /// <summary>
        /// 
        /// </summary>
        public XScript.Builder XScript(XScript component)
        {
            return new XScript.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public XScript.Builder XScript(XScript.Config config)
        {
            return new XScript.Builder(new XScript(config));
        }
    }
}
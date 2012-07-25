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
    public partial class LinkButton
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Button.Builder<LinkButton, LinkButton.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new LinkButton()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LinkButton component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LinkButton.Config config) : base(new LinkButton(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(LinkButton component)
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
        public LinkButton.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.LinkButton(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public LinkButton.Builder LinkButton()
        {
            return this.LinkButton(new LinkButton());
        }

        /// <summary>
        /// 
        /// </summary>
        public LinkButton.Builder LinkButton(LinkButton component)
        {
            return new LinkButton.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public LinkButton.Builder LinkButton(LinkButton.Config config)
        {
            return new LinkButton.Builder(new LinkButton(config));
        }
    }
}
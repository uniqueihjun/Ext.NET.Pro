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
    public partial class TreePanel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TreePanelBase.Builder<TreePanel, TreePanel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TreePanel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreePanel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreePanel.Config config) : base(new TreePanel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TreePanel component)
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
        public TreePanel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreePanel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TreePanel.Builder TreePanel()
        {
            return this.TreePanel(new TreePanel());
        }

        /// <summary>
        /// 
        /// </summary>
        public TreePanel.Builder TreePanel(TreePanel component)
        {
            return new TreePanel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreePanel.Builder TreePanel(TreePanel.Config config)
        {
            return new TreePanel.Builder(new TreePanel(config));
        }
    }
}
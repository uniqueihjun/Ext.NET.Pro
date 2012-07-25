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
    public partial class TreeDragZone
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DragZone.Builder<TreeDragZone, TreeDragZone.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TreeDragZone()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeDragZone component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeDragZone.Config config) : base(new TreeDragZone(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TreeDragZone component)
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
        public TreeDragZone.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreeDragZone(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TreeDragZone.Builder TreeDragZone()
        {
            return this.TreeDragZone(new TreeDragZone());
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeDragZone.Builder TreeDragZone(TreeDragZone component)
        {
            return new TreeDragZone.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeDragZone.Builder TreeDragZone(TreeDragZone.Config config)
        {
            return new TreeDragZone.Builder(new TreeDragZone(config));
        }
    }
}
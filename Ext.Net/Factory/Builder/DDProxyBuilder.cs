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
    public partial class DDProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DD.Builder<DDProxy, DDProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DDProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DDProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DDProxy.Config config) : base(new DDProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DDProxy component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// By default the frame is positioned exactly where the drag element is, so we use the cursor offset provided by Ext.dd.DD. Another option that works only if you do not have constraints on the obj is to have the drag frame centered around the cursor. Set centerFrame to true for this effect. Defaults to: false
			/// </summary>
            public virtual DDProxy.Builder CenterFrame(bool centerFrame)
            {
                this.ToComponent().CenterFrame = centerFrame;
                return this as DDProxy.Builder;
            }
             
 			/// <summary>
			/// By default we resize the drag frame to be the same size as the element we want to drag (this is to get the frame effect). We can turn it off if we want a different behavior.
			/// </summary>
            public virtual DDProxy.Builder ResizeFrame(bool resizeFrame)
            {
                this.ToComponent().ResizeFrame = resizeFrame;
                return this as DDProxy.Builder;
            }
             
 			/// <summary>
			/// Abstract method runs on drag end
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DDProxy.Builder</returns>
            public virtual DDProxy.Builder AfterDrag(Action<JFunction> action)
            {
                action(this.ToComponent().AfterDrag);
                return this as DDProxy.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DDProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DDProxy(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DDProxy.Builder DDProxy()
        {
            return this.DDProxy(new DDProxy());
        }

        /// <summary>
        /// 
        /// </summary>
        public DDProxy.Builder DDProxy(DDProxy component)
        {
            return new DDProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DDProxy.Builder DDProxy(DDProxy.Config config)
        {
            return new DDProxy.Builder(new DDProxy(config));
        }
    }
}
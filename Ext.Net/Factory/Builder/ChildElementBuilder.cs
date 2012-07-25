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
    public partial class ChildElement
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<ChildElement, ChildElement.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ChildElement()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChildElement component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChildElement.Config config) : base(new ChildElement(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ChildElement component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The property name on the Component for the child element.
			/// </summary>
            public virtual ChildElement.Builder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as ChildElement.Builder;
            }
             
 			/// <summary>
			/// The id to combine with the Component's id that is the id of the child element.
			/// </summary>
            public virtual ChildElement.Builder ItemID(string itemID)
            {
                this.ToComponent().ItemID = itemID;
                return this as ChildElement.Builder;
            }
             
 			/// <summary>
			/// The id of the child element.
			/// </summary>
            public virtual ChildElement.Builder ID(string iD)
            {
                this.ToComponent().ID = iD;
                return this as ChildElement.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ChildElement.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ChildElement(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ChildElement.Builder ChildElement()
        {
            return this.ChildElement(new ChildElement());
        }

        /// <summary>
        /// 
        /// </summary>
        public ChildElement.Builder ChildElement(ChildElement component)
        {
            return new ChildElement.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ChildElement.Builder ChildElement(ChildElement.Config config)
        {
            return new ChildElement.Builder(new ChildElement(config));
        }
    }
}
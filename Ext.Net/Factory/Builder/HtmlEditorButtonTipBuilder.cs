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
    public partial class HtmlEditorButtonTip
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<HtmlEditorButtonTip, HtmlEditorButtonTip.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HtmlEditorButtonTip()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditorButtonTip component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HtmlEditorButtonTip.Config config) : base(new HtmlEditorButtonTip(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HtmlEditorButtonTip component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditorButtonTip.Builder Title(string title)
            {
                this.ToComponent().Title = title;
                return this as HtmlEditorButtonTip.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditorButtonTip.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as HtmlEditorButtonTip.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual HtmlEditorButtonTip.Builder Cls(string cls)
            {
                this.ToComponent().Cls = cls;
                return this as HtmlEditorButtonTip.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HtmlEditorButtonTip(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder HtmlEditorButtonTip()
        {
            return this.HtmlEditorButtonTip(new HtmlEditorButtonTip());
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder HtmlEditorButtonTip(HtmlEditorButtonTip component)
        {
            return new HtmlEditorButtonTip.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip.Builder HtmlEditorButtonTip(HtmlEditorButtonTip.Config config)
        {
            return new HtmlEditorButtonTip.Builder(new HtmlEditorButtonTip(config));
        }
    }
}
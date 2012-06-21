/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public HtmlEditorButtonTip(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit HtmlEditorButtonTip.Config Conversion to HtmlEditorButtonTip
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HtmlEditorButtonTip(HtmlEditorButtonTip.Config config)
        {
            return new HtmlEditorButtonTip(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit HtmlEditorButtonTip.Config Conversion to HtmlEditorButtonTip.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator HtmlEditorButtonTip.Builder(HtmlEditorButtonTip.Config config)
			{
				return new HtmlEditorButtonTip.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string title = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Title 
			{ 
				get
				{
					return this.title;
				}
				set
				{
					this.title = value;
				}
			}

			private string text = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Text 
			{ 
				get
				{
					return this.text;
				}
				set
				{
					this.text = value;
				}
			}

			private string cls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Cls 
			{ 
				get
				{
					return this.cls;
				}
				set
				{
					this.cls = value;
				}
			}

        }
    }
}
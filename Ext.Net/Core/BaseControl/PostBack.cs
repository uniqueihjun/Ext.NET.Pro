/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class BaseControl
    {
        /*  PostBack
            -----------------------------------------------------------------------------------------------*/

        private string postBackArgument = "";

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual string PostBackArgument
        {
            get
            {
                return this.postBackArgument;
            }
            set
            {
                this.postBackArgument = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("postback", JsonMode.Raw)]
        [DefaultValue("")]
        protected virtual string PostBackConfig
        {
            get
            {
                if (this is IAutoPostBack)
                {
                    IAutoPostBack control = (IAutoPostBack)this;

                    if (control.AutoPostBack)
                    {
                        return JSON.Serialize(new { eventName = control.PostBackEvent, fn = new JFunction(this.PostBackFunction) });
                    }
                }

                return "";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual string PostBackFunction
        {
            get
            {
                if (this is IAutoPostBack)
                {
                    IAutoPostBack control = (IAutoPostBack)this;

                    if (control.AutoPostBack)
                    {
                        if (control.CausesValidation)
                        {
                            PostBackOptions options = new PostBackOptions(this, this.PostBackArgument);
                            options.ValidationGroup = control.ValidationGroup;

                            options.AutoPostBack = control.AutoPostBack;
                            options.PerformValidation = control.CausesValidation;

                            if (control is Button)
                            {
                                Button button = (Button)control;

                                if (button.PostBackUrl.IsNotEmpty())
                                {
                                    options.ActionUrl = HttpUtility.UrlPathEncode(base.ResolveClientUrl(button.PostBackUrl));
                                }
                            }

                            if (RequestManager.IsIE)
                            {
                                string ps = this.Page.ClientScript.GetPostBackEventReference(options, false);
                                Regex re = new Regex("setTimeout\\('(.+)',(\\s*)\\d+\\)");
                                Match m = re.Match(ps);
                                if (m != null && m.Success)
                                {
                                    ps = m.Groups[1].Value;
                                }
                                ps = ps.Replace("'", "\"");
                                return string.Format("window.location = 'javascript:{0}';", ps);
                            }
                            else
                            {
                                return this.Page.ClientScript.GetPostBackEventReference(options, false) + ";";
                            }
                        }
                        else
                        {
                            return RequestManager.IsIE ? string.Format("window.location = 'javascript:{0}';", this.Page.ClientScript.GetPostBackEventReference(this, this.PostBackArgument).Replace("'", "\""))
                                            : string.Concat(this.Page.ClientScript.GetPostBackEventReference(this, this.PostBackArgument), ";");
                        }
                    }
                }

                return "";
            }
        }
    }
}
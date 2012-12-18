/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Configuration;
using System.Web.UI.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class WebConfigUtils
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static IDMode GetIDModeFromWebConfig(ISite site)
        {
            IDMode idMode = IDMode.Explicit;

            GlobalConfig extnet = GetExtNetSection(site);

            if (extnet != null)
            {
                idMode = extnet.IDMode;
            }

            return idMode;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static InitScriptMode GetInitScriptModeFromWebConfig(ISite site)
        {
            InitScriptMode mode = InitScriptMode.Inline;

            GlobalConfig extnet = GetExtNetSection(site);

            if (extnet != null)
            {
                mode = extnet.InitScriptMode;
            }

            return mode;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static Theme GetThemeFromWebConfig(ISite site)
        {
            Theme theme = Theme.Default;

            GlobalConfig config = GetExtNetSection(site);

            if (config != null)
            {
                theme = config.Theme;
            }

            return theme;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static ScriptMode GetScriptModeFromWebConfig(ISite site)
        {
            ScriptMode mode = ScriptMode.Release;

            GlobalConfig config = GetExtNetSection(site);

            if (config != null)
            {
                mode = config.ScriptMode;
            }

            return mode;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static ViewStateMode GetAjaxViewStateFromWebConfig(ISite site)
        {
            ViewStateMode mode = ViewStateMode.Inherit;

            GlobalConfig config = GetExtNetSection(site);

            if (config != null)
            {
                mode = config.AjaxViewStateMode;
            }

            return mode;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static string GetLocaleFromWebConfig(ISite site)
        {
            string locale = "Invariant";
            GlobalConfig config = GetExtNetSection(site);

            if (config != null)
            {
                locale = config.Locale;
            }

            return locale;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static ClientProxy GetDirectMethodProxyFromWebConfig(ISite site)
        {
            ClientProxy mode = ClientProxy.Default;

            GlobalConfig config = GetExtNetSection(site);

            if (config != null)
            {
                mode = config.DirectMethodProxy;
            }

            return mode;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static StateProvider GetStateProviderFromWebConfig(ISite site)
        {
            StateProvider stateProvider = StateProvider.PostBack;

            GlobalConfig extnet = GetExtNetSection(site);

            if (extnet != null)
            {
                stateProvider = extnet.StateProvider;
            }

            return stateProvider;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static GlobalConfig GetExtNetSection(ISite site)
        {
            if (site != null)
            {
                IWebApplication app = (IWebApplication)site.GetService(typeof(IWebApplication));

                if (app != null)
                {
                    Configuration config = app.OpenWebConfiguration(false);

                    if (config != null)
                    {
                        ConfigurationSection section = config.GetSection("extnet");

                        if (section != null)
                        {
                            return section as GlobalConfig;
                        }
                    }
                }
            }

            return null;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static LazyMode GetLazyModeFromWebConfig(ISite site)
        {
            LazyMode lazyMode = LazyMode.Inherit;

            GlobalConfig extnet = GetExtNetSection(site);

            if (extnet != null)
            {
                lazyMode = extnet.LazyMode;
            }

            return lazyMode;
        }
    }
}
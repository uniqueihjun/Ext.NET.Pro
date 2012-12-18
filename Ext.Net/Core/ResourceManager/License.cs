/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Globalization;

using Ext.Net.Utilities;
using System.Web;

namespace Ext.Net
{
    public partial class ResourceManager
    {
        private bool? isValidLicenseKey;

        /// <summary>
        /// Checks if the Ext.Net.LicenseKey is Valid
        /// </summary>
        public bool IsValidLicenseKey
        {
            get
            {
                if (!this.isValidLicenseKey.HasValue)
                {
                    this.isValidLicenseKey = false;

                    string key = this.LicenseKey;
                    
                    if (key.IsNotEmpty())
                    {
                        try
                        {
                            key = key.Base64Decode();
                        }
                        catch (FormatException)
                        {
                            //return false;
                        }

                        if (key.IsNotEmpty())
                        {
                            string[] credentials = key.Split(',');

                            if (credentials.Length == 3)
                            {
                                int ver;

                                if (Int32.TryParse(credentials[1], out ver) && ver >= 1)
                                {
                                    DateTime dt;

                                    if (DateTime.TryParseExact(credentials[2], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt) && dt >= DateTime.Now)
                                    {
                                        this.isValidLicenseKey = true;
                                    }
                                }
                            }
                        }
                    }
                }

                return this.isValidLicenseKey.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected void CheckLicense()
        {
            if (!this.DesignMode && HttpContext.Current != null)
            {
                if (this.IsPro &&
                    !X.IsAjaxRequest &&
                    !RequestManager.IsMicrosoftAjaxRequest &&
                    !HttpContext.Current.Request.IsLocal &&
                    !this.IsValidLicenseKey)
                {
                    this.ShowUnlicenseMessage();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowUnlicenseMessage()
        {
            this.RegisterClientStyleInclude("Ext.Net.Build.Ext.Net.extnet.unlicensed.css.un.css");
            this.RegisterClientScriptInclude("Ext.Net.Build.Ext.Net.extnet.unlicensed.un.js");
        }
    }
}

/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Ext.Net.MVC
{
    /// <summary>
    /// 
    /// </summary>
    public class DirectControllerAttribute : Attribute
    {
        public string AreaName
        {
            get;
            set;
        }

        private bool generateProxyForOtherAreas = false;
        public bool GenerateProxyForOtherAreas
        {
            get
            {
                return this.generateProxyForOtherAreas;
            }
            set
            {
                this.generateProxyForOtherAreas = value;
            }
        }

        private bool generateProxyForOtherControllers = true;
        public bool GenerateProxyForOtherControllers
        {
            get
            {
                return this.generateProxyForOtherControllers;
            }
            set
            {
                this.generateProxyForOtherControllers = true;
            }
        }

        private DirectMethodProxyIDMode idMode = DirectMethodProxyIDMode.ClientID;
        private string alias;

        /// <summary>
        /// 
        /// </summary>
        public DirectMethodProxyIDMode IDMode
        {
            get
            {
                return this.idMode;
            }
            set
            {
                this.idMode = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Alias
        {
            get
            {
                return this.alias;
            }
            set
            {
                this.alias = value;
            }
        }
    }
}
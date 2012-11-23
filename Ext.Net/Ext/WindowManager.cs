/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class WindowManager : ScriptClass
    {
        /*  IScriptable
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.WindowMgr";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToScript()
        {
            return "";
        }


        /*  Public Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Brings the specified window to the front of any other active windows.
        /// </summary>
        /// <param name="windowID">The id of the window</param>
        /// <returns>WindowMgr</returns>
        public virtual void BringToFront(string windowID)
        {
            this.Call("bringToFront", windowID);
        }

        /// <summary>
        /// Brings the specified window to the front of any other active windows.
        /// </summary>
        /// <param name="window">Window</param>
        /// <returns>WindowMgr</returns>
        public virtual void BringToFront(WindowBase window)
        {
            this.BringToFront(window.ClientID);
        }

        /// <summary>
        /// Hides all windows in the group.
        /// </summary>
        /// <returns>WindowMgr</returns>
        public virtual void HideAll()
        {
            this.Call("hideAll");
        }

        /// <summary>
        /// Sends the specified window to the back of other active windows.
        /// </summary>
        /// <param name="windowID">The id of the window</param>
        /// <returns>WindowMgr</returns>
        public virtual void SendToBack(string windowID)
        {
            this.Call("sendToBack", windowID);
        }

        /// <summary>
        /// Sends the specified window to the back of other active windows.
        /// </summary>
        /// <param name="window">Window</param>
        /// <returns>WindowMgr</returns>
        public virtual void SendToBack(WindowBase window)
        {
            this.SendToBack(window.ClientID);
        }
    }
}
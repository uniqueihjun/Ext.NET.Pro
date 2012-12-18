/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// The default global floating Component group that is available automatically.
    ///
    /// This manages instances of floating Components which were rendered programatically without being added to a Container, and for floating Components which were added into non-floating Containers.
    ///
    /// Floating Containers create their own instance of ZIndexManager, and floating Components added at any depth below there are managed by that ZIndexManager.
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
        /// Brings the specified Component to the front of any other active Components in this ZIndexManager.
        /// </summary>
        /// <param name="compID">The id of the Component or a Ext.Component instance</param>
        public virtual void BringToFront(string compID)
        {
            this.Call("bringToFront", compID);
        }

        /// <summary>
        /// Brings the specified Component to the front of any other active Components in this ZIndexManager.
        /// </summary>
        /// <param name="comp">The id of the Component or a Ext.Component instance</param>
        public virtual void BringToFront(AbstractComponent comp)
        {
            this.BringToFront(comp.ClientID);
        }

        /// <summary>
        /// Executes the specified function once for every Component in this ZIndexManager, passing each Component as the only parameter. Returning false from the function will stop the iteration.
        /// </summary>
        /// <param name="fn">The function to execute for each item</param>
        public virtual void Each(JFunction fn)
        {
            this.Call("each", fn);
        }

        /// <summary>
        /// Executes the specified function once for every Component in this ZIndexManager, passing each Component as the only parameter. Returning false from the function will stop the iteration.
        /// </summary>
        /// <param name="fn">The function to execute for each item</param>
        /// <param name="scope">(optional) The scope (this reference) in which the function is executed. Defaults to the current Component in the iteration.</param>
        public virtual void Each(JFunction fn, string scope)
        {
            this.Call("each", fn, new JRawValue(scope));
        }

        /// <summary>
        /// Hides all Components managed by this ZIndexManager.
        /// </summary>
        public virtual void HideAll()
        {
            this.Call("hideAll");
        }

        /// <summary>
        /// Sends the specified Component to the back of other active Components in this ZIndexManager.
        /// </summary>
        /// <param name="compID">The id of the Component or a Ext.Component instance</param>
        public virtual void SendToBack(string compID)
        {
            this.Call("sendToBack", compID);
        }

        /// <summary>
        /// Sends the specified Component to the back of other active Components in this ZIndexManager.
        /// </summary>
        /// <param name="comp">The id of the Component or a Ext.Component instance</param>
        public virtual void SendToBack(AbstractComponent comp)
        {
            this.SendToBack(comp.ClientID);
        }
    }
}
/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    public partial class ResourceManager
    {
        List<Control> allUpdatePanels;

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public virtual List<Control> AllUpdatePanels
        {
            get
            {
                if (this.allUpdatePanels == null)
                {
                    this.allUpdatePanels = ControlUtils.FindControls<Control>(this.Page, "System.Web.UI.UpdatePanel", false);
                }

                return this.allUpdatePanels;
            }
        }

        List<Control> updatePanelsToRefresh;

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public virtual List<Control> UpdatePanelsToRefresh
        {
            get
            {
                return this.updatePanelsToRefresh ?? (this.updatePanelsToRefresh = new List<Control>());
            }
        }

        List<string> updatePanelIDsToRefresh;

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public virtual List<string> UpdatePanelIDsToRefresh
        {
            get
            {
                return this.updatePanelIDsToRefresh ?? (this.updatePanelIDsToRefresh = new List<string>());
            }
        }

        Control triggerUpdatePanel;

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public virtual Control TriggerUpdatePanel
        {
            get
            {
                return this.triggerUpdatePanel;
            }
        }

        string triggerUpdatePanelID = "";

        /// <summary>
        /// 
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public virtual string TriggerUpdatePanelID
        {
            get
            {
                return this.triggerUpdatePanelID;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="updatePanel"></param>
        [Description("")]
        public virtual void AddUpdatePanelToRefresh(Control updatePanel)
        {
            if (ReflectionUtils.IsTypeOf(updatePanel, "System.Web.UI.UpdatePanel", false))
            {
                if (!this.UpdatePanelIDsToRefresh.Contains(updatePanel.UniqueID))
                {
                    this.UpdatePanelsToRefresh.Add(updatePanel);
                    this.UpdatePanelIDsToRefresh.Add(updatePanel.UniqueID);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="updatePanel"></param>
        [Description("")]
        public virtual void RemoveUpdatePanelToRefresh(Control updatePanel)
        {
            if (ReflectionUtils.IsTypeOf(updatePanel, "System.Web.UI.UpdatePanel", false))
            {
                if (this.UpdatePanelIDsToRefresh.Contains(updatePanel.UniqueID))
                {
                    this.UpdatePanelsToRefresh.Remove(updatePanel);
                    this.UpdatePanelIDsToRefresh.Remove(updatePanel.UniqueID);
                }
            }
        }

        private void SetUpdatePanels(Control updatePanel)
        {
            this.triggerUpdatePanel = updatePanel;

            if (this.TriggerUpdatePanel != null)
            {
                this.AddUpdatePanelToRefresh(this.triggerUpdatePanel);

                foreach (Control control in this.AllUpdatePanels)
                {
                    if (!control.UniqueID.Equals(this.TriggerUpdatePanel.UniqueID))
                    {
                        PropertyInfo updateMode = control.GetType().GetProperty("UpdateMode");
                        string mode = updateMode.GetValue(control, null).ToString();

                        if (mode.Equals("Always") || ControlUtils.IsChildOfParent(this.TriggerUpdatePanel, control))
                        {
                            this.AddUpdatePanelToRefresh(control);
                        }
                    }
                }
            }
        }

        bool IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection)
        {
            this.HasLoadPostData = true;

            if (RequestManager.IsMicrosoftAjaxRequest && this.MicrosoftScriptManager != null)
            {
                this.triggerUpdatePanelID = postCollection[this.MicrosoftScriptManager.UniqueID].LeftOf('|');

                this.SetUpdatePanels(ControlUtils.FindControl(this.Page.Form, this.TriggerUpdatePanelID));
            }

            return false;
        }
    }
}

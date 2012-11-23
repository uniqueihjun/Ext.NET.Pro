/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Slider which supports vertical or horizontal orientation, keyboard adjustments, configurable snapping, axis clicking and animation.
    /// </summary>
    [Meta]
    [ToolboxBitmap(typeof(Slider), "Build.ToolboxIcons.Slider.bmp")]
    [ToolboxData("<{0}:Slider runat=\"server\" />")]
    [Designer(typeof(EmptyDesigner))]
    [Description("Slider which supports vertical or horizontal orientation, keyboard adjustments, configurable snapping, axis clicking and animation.")]
    public partial class Slider : SliderBase, IPostBackDataHandler
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public Slider() { }

        private SliderListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ViewStateMember]
        [Description("Client-side JavaScript Event Handlers")]
        public SliderListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new SliderListeners();
                }

                return this.listeners;
            }
        }


        private SliderDirectEvents directEvents;

        /// <summary>
        /// Server-side DirectEvent Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [ViewStateMember]
        [Description("Server-side DirectEventHandlers")]
        public SliderDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new SliderDirectEvents();
                }

                return this.directEvents;
            }
        }


        /*  Lifecycle
            -----------------------------------------------------------------------------------------------*/

        private static readonly object EventValueChanged = new object();

        /// <summary>
        /// Fires when the Value property has been changed
        /// </summary>
        [Category("Action")]
        [Description("Fires when the Value property has been changed")]
        public event EventHandler ValueChanged
        {
            add
            {
                Events.AddHandler(EventValueChanged, value);
            }
            remove
            {
                Events.RemoveHandler(EventValueChanged, value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        [Description("")]
        protected virtual void OnValueChanged(EventArgs e)
        {
            EventHandler handler = (EventHandler)Events[EventValueChanged];

            if (handler != null)
            {
                handler(this, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="postDataKey"></param>
        /// <param name="postCollection"></param>
        /// <returns></returns>
        [Description("")]
        public bool LoadPostData(string postDataKey, NameValueCollection postCollection)
        {
            string val = postCollection[this.ConfigID.ConcatWith("_Value")];

            if (val.IsEmpty())
            {
                return false;
            }

            string[] values = val.Split(',');
            int[] numbers = Array.ConvertAll(values, delegate(string input) { return int.Parse(input); });

            this.SuspendScripting();
            
            if (numbers.Length == 1)
            {
                this.Value = numbers[0];
            }
            else
            {
                this.Values = numbers;
            }

            this.ResumeScripting();

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public void RaisePostDataChangedEvent()
        {
            this.OnValueChanged(EventArgs.Empty);
        }
    }
}
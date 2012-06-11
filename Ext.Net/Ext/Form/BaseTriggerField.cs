/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    [Meta]
    [Description("")]
    public abstract partial class BaseTriggerField : TriggerFieldBase, IPostBackEventHandler
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override void OnBeforeClientInit(Observable sender)
        {
            if (this.AutoPostBack)
            {
                string replace = "'".ConcatWith(this.PostBackArgument, "'");
                this.On("triggerclick", new JFunction(this.PostBackFunction.Replace(replace, "index"), "el", "t", "index"));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override string PostBackArgument
        {
            get
            {
                return "_index_";
            }
        }

        private static readonly object EventTriggerClicked = new object();

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public delegate void TriggerClickedHandler(object sender, TriggerEventArgs e);

        /// <summary>
        /// 
        /// </summary>
        [Category("Action")]
        [Description("Fires when a trigger has been clicked")]
        public event TriggerClickedHandler TriggerClicked
        {
            add
            {
                Events.AddHandler(EventTriggerClicked, value);
            }
            remove
            {
                Events.RemoveHandler(EventTriggerClicked, value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected virtual void OnTriggerClicked(TriggerEventArgs e)
        {
            TriggerClickedHandler handler = (TriggerClickedHandler)Events[EventTriggerClicked];

            if (handler != null)
            {
                handler(this, e);
            }
        }

        void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
        {
            int index;

            if (int.TryParse(eventArgument, out index))
            {
                this.OnTriggerClicked(new TriggerEventArgs(index));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override void OnPreRender(EventArgs e)
        {
            this.CheckTriggers();

            base.OnPreRender(e);
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected virtual void CheckTriggers()
        {
            if (this.Triggers.Count == 0)
            {
                this.Triggers.Add(new FieldTrigger());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override void RegisterIcons()
        {
            base.RegisterIcons();

            if (!Ext.Net.X.IsAjaxRequest || this.IsDynamic)
            {
                foreach (FieldTrigger trigger in this.Triggers)
                {
                    this.RegisterIcon(trigger.Icon);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Browsable(false)]
        [DefaultValue("")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("")]
        public override string TriggerClass
        {
            get
            {
                return base.TriggerClass;
            }
            set
            {
                base.TriggerClass = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class TriggerEventArgs : EventArgs
    {
        private readonly int index;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public TriggerEventArgs(int index)
        {
            this.index = index;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Index
        {
            get
            {
                return index;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class FieldTrigerCollection : StateManagedCollection<FieldTrigger> { }
}

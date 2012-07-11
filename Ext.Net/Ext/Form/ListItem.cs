/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using System.Text;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class ListItem : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        public ListItem() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public ListItem(string text)
        {
            this.Text = text;
            this.Value = text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        public ListItem(string text, string value)
        {
            this.Value = value;
            this.Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public ListItem(string text, string value, int index)
        {
            this.Value = value;
            this.Text = text;
            this.Index = index;
        }        

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Description("")]
        public string Text
        {
            get
            {
                return this.State.Get<string>("Text", null);
            }
            set
            {
                this.State.Set("Text", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Description("")]
        public string Value
        {
            get
            {
                return this.State.Get<string>("Value", null);
            }
            set
            {
                this.State.Set("Value", value);                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("value", JsonMode.Raw)]
        [DefaultValue(null)]
        protected virtual string ValueProxy
        {
            get
            {
                if (this.Value == null)
                {
                    return null;
                }

                return this.Mode == ParameterMode.Value ? JSON.Serialize(this.Value) : this.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(-1)]
        [NotifyParentProperty(true)]
        [Description("")]
        public int Index
        {
            get
            {
                return this.State.Get<int>("Index", -1);
            }
            set
            {
                this.State.Set("Index", value);
            }
        }

        /// <summary>
        /// Wrap in quotes or not
        /// </summary>
        [Meta]
        [DefaultValue(ParameterMode.Value)]
        [Description("Wrap in quotes or not")]
        public virtual ParameterMode Mode
        {
            get
            {
                return this.State.Get<ParameterMode>("Mode", ParameterMode.Value);
            }
            set
            {
                this.State.Set("Mode", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool IsDefault
        {
            get
            {
                return this.Text == null && this.Value == null && this.Index < 0;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>    
    public partial class ListItemCollection : BaseItemCollection<ListItem>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Serialize()
        {
            var comma = false;
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var item in this)
            {
                if (comma)
                {
                    sb.Append(",");
                }
                comma = true;

                sb.Append(new ClientConfig().Serialize(item));
            }
            sb.Append("]");

            return sb.ToString();
        }
    }
}

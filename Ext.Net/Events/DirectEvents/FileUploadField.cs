/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class FileUploadFieldDirectEvents : TextFieldDirectEvents
    {
        private ComponentDirectEvent fileSelected;

        /// <summary>
        /// Fires when the underlying file input field's value has changed from the user selecting a new file from the system file selection dialog.
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This file upload field")]
        [ListenerArgument(1, "value", typeof(int), "The file value returned by the underlying file input field")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("fileselected", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the underlying file input field's value has changed from the user selecting a new file from the system file selection dialog.")]
        public virtual ComponentDirectEvent FileSelected
        {
            get
            {
                if (this.fileSelected == null)
                {
                    this.fileSelected = new ComponentDirectEvent();
                }

                return this.fileSelected;
            }
        }
    }
}
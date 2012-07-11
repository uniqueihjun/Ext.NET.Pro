/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class LayoutConverter : StringConverter
    {
        private TypeConverter.StandardValuesCollection values;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {            
            if (this.values == null)
            {
                this.values = new TypeConverter.StandardValuesCollection(new string[] { 
                    "AbsoluteLayout", 
                    "AccordionLayout", 
                    "AnchorLayout", 
                    "BorderLayout", 
                    "CardLayout", 
                    "ColumnLayout", 
                    "AutoLayout", 
                    "FitLayout", 
                    "FormLayout",
                    "HBoxLayout", 
                    "MenuLayout", 
                    "TableLayout", 
                    "ToolbarLayout", 
                    "VBoxLayout" 
                });
            }

            return this.values;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }
}
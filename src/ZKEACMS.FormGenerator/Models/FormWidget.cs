/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Linq;
using ZKEACMS.FormGenerator.Service;
using ZKEACMS.MetaData;
using ZKEACMS.Widget;

namespace ZKEACMS.FormGenerator.Models
{
    public class FormWidget : SimpleWidgetBase
    {
        public string FormID { get; set; }
    }

    class FormWidgetMetaData : WidgetMetaData<FormWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.Title).AsHidden();
            ViewConfig(m => m.FormID).AsDropDownList().DataSource(() =>
            {
                return Easy.ServiceLocator.GetService<IFormService>().Get().ToDictionary(f => f.ID, f => f.Title);
            }).Required();
        }
    }
}

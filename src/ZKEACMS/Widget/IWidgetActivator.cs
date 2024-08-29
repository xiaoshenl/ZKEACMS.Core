/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */
namespace ZKEACMS.Widget
{
    public interface IWidgetActivator
    {
        IWidgetPartDriver Create(WidgetBase widget);
        WidgetBase CreateWidgetViewModel(WidgetBase widget);
    }
}

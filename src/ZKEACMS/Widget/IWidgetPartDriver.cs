/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;

namespace ZKEACMS.Widget
{
    public interface IWidgetPartDriver : IDisposable
    {
        void AddWidget(WidgetBase widget);
        void DeleteWidget(string widgetId);
        void UpdateWidget(WidgetBase widget);
        void Publish(WidgetBase widget);
        WidgetBase GetWidget(WidgetBase widget);
        object Display(WidgetDisplayContext widgetDisplayContext);
        WidgetPackage PackWidget(WidgetBase widget);
        void InstallWidget(WidgetPackage pack);
    }

}

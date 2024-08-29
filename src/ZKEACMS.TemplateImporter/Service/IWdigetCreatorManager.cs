/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using ZKEACMS.Widget;

namespace ZKEACMS.TemplateImporter.Service
{
    public interface IWdigetCreatorManager
    {
        WidgetBase Create(string section, string themeName);
    }
}

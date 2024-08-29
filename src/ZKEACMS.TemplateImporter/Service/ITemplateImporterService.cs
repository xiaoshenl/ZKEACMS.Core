/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using ZKEACMS.Theme;

namespace ZKEACMS.TemplateImporter.Service
{
    public interface ITemplateImporterService
    {
        ThemeEntity Import(string zipFile);
    }
}

/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using ZKEACMS.PackageManger;

namespace ZKEACMS.Theme
{
    public class ThemePackage : FilePackage
    {
        public ThemePackage(string installer) : base(installer)
        {

        }
        public ThemeEntity Theme { get; set; }
    }
}

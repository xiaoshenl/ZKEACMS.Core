/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Modules.DataDictionary;
using ZKEACMS.PackageManger;

namespace ZKEACMS.Widget
{
    public class WidgetPackage : FilePackage
    {
        public WidgetPackage(string installer) : base(installer)
        {

        }
        public WidgetBase Widget { get; set; }
    }
    public class DataDictionaryPackage : FilePackage
    {
        public DataDictionaryPackage(string installer) : base(installer)
        {

        }
        public DataDictionaryEntity DataDictionary { get; set; }
    }
}
